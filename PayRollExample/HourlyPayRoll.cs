using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollExample
{
    public class HourlyPayRoll : IPayrollStrategy
    {
        private double _hourlyRate;
        private double _normalWorkingHoursPerDay;
        private double _extraHoursFactor;

        private double _numberOfHoursWorked;
        private int _paymentDueDateInDays;

        public HourlyPayRoll( double numberOfHoursWorked,double hourlyRate, double normalWorkingHoursPerDay, double extraHoursFactor, int paymentDueDateInDays)
        {
            _numberOfHoursWorked = numberOfHoursWorked;
            _hourlyRate = hourlyRate;
            _normalWorkingHoursPerDay = normalWorkingHoursPerDay;
            _extraHoursFactor = extraHoursFactor;
            _paymentDueDateInDays = paymentDueDateInDays;

        }

        public double GetPayroll()
        {
            if (_numberOfHoursWorked > (_normalWorkingHoursPerDay * _paymentDueDateInDays))
            {
                var extrHoursWorked = _numberOfHoursWorked - (_normalWorkingHoursPerDay * _paymentDueDateInDays);
                return ((extrHoursWorked * _extraHoursFactor * _hourlyRate) + (_normalWorkingHoursPerDay * _hourlyRate));
            }
            return (_numberOfHoursWorked * _hourlyRate);
        }
    }
}
