using System;
using System.Collections.Generic;

namespace _09_StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SOLID - OCP para cálculo de salarios según nivel de desarrollador

            //var devCalculations = new List<BaseSalaryCalculator>
            //{
            //    new SeniorDevSalaryCalculator (new DeveloperReport { Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 160 }),
            //    new JuniorDevSalaryCalculator (new DeveloperReport { Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate = 20, WorkingHours = 150 }),
            //    new SeniorDevSalaryCalculator (new DeveloperReport { Id = 3, Name = "Dev3", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 180 })
            //};

            //var calculator = new SalaryCalculator(devCalculations);
            //Console.WriteLine($"Sum of all the developer salaries is {calculator.CalculateTotalSalaries()} dollars");

            #endregion SOLID - OCP para cálculo de salarios según nivel de desarrollador

            #region SOLID - OCP para filtro de monitores

            //var monitors = new List<ComputerMonitor>
            //{
            //    new ComputerMonitor { Name = "Samsung S345", Screen = Screen.CurvedScreen, Type = MonitorType.OLED },
            //    new ComputerMonitor { Name = "Philips P532", Screen = Screen.WideScreen, Type = MonitorType.LCD },
            //    new ComputerMonitor { Name = "LG L888", Screen = Screen.WideScreen, Type = MonitorType.LED },
            //    new ComputerMonitor { Name = "Samsung S999", Screen = Screen.WideScreen, Type = MonitorType.OLED },
            //    new ComputerMonitor { Name = "Dell D2J47", Screen = Screen.CurvedScreen, Type = MonitorType.LCD }
            //};


            //var filter = new MonitorFilter();

            //var ldcMonitors = filter.Filter(monitors, new MonitorTypeSpecification(MonitorType.LCD));
            //Console.WriteLine("All LCD monitors");
            //foreach (var monitor in ldcMonitors)
            //{
            //    Console.WriteLine($"Name: {monitor.Name}, Type: {monitor.Type}, Screen: {monitor.Screen}");
            //}

            //var wideScreenMonitors = filter.Filter(monitors, new ScreenSpecification(Screen.WideScreen));
            //Console.WriteLine("All WideScreen Monitors");
            //foreach (var monitor in wideScreenMonitors)
            //{
            //    Console.WriteLine($"Name: {monitor.Name}, Type: {monitor.Type}, Screen: {monitor.Screen}");
            //}

            #endregion SOLID - OCP para filtro de monitores

            #region Patrón strategy

            var reports = new List<DeveloperReport>
            {
                new DeveloperReport { Id = 1, Name = "Dev1", Level = DeveloperLevel.Senior, HourlyRate = 30.5, WorkingHours = 160 },
                new DeveloperReport { Id = 2, Name = "Dev2", Level = DeveloperLevel.Junior, HourlyRate = 20, WorkingHours = 120 },
                new DeveloperReport { Id = 3, Name = "Dev3", Level = DeveloperLevel.Senior, HourlyRate = 32.5, WorkingHours = 130 },
                new DeveloperReport { Id = 4, Name = "Dev4", Level = DeveloperLevel.Junior, HourlyRate = 24.5, WorkingHours = 140 }
            };

            var calculatorContext = new SalaryCalculator(new JuniorDevSalaryCalculator());
            var juniorTotal = calculatorContext.Calculate(reports);
            Console.WriteLine($"Total amount for junior salaries is: {juniorTotal}");

            calculatorContext.SetCalculator(new SeniorDevSalaryCalculator());
            var seniorTotal = calculatorContext.Calculate(reports);
            Console.WriteLine($"Total amount for senior salaries is: {seniorTotal}");

            Console.WriteLine($"Total cost for all the salaries is: {juniorTotal + seniorTotal}");

            #endregion Patrón strategy
        }
    }
}
