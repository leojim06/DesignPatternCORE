using System.Collections.Generic;

namespace _09_StrategyDesignPattern
{
    public interface ISalaryCalculator
    {
        double CalculateTotalSalary(IEnumerable<DeveloperReport> reports);
    }
}
