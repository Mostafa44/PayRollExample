using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollExample
{
    public class FlatSalaryPayroll : IPayrollStrategy
    {
        private double _flatMonthlySalary;
        public FlatSalaryPayroll(double flatMonthlySalary)
        {
            _flatMonthlySalary = flatMonthlySalary;
        }
        public double GetPayroll()
        {
            return _flatMonthlySalary;
        }
    }
}
