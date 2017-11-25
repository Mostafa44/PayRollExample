using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollExample
{
    public class CommisionPayroll : IPayrollStrategy
    {
        private double _commissionRate;
        private IEnumerable<SaleReceipt> _saleReceipts;
        public CommisionPayroll(double commissionRate,IEnumerable<SaleReceipt> saleReceipts)
        {
            _saleReceipts = saleReceipts;
            _commissionRate = commissionRate;
        }
        public double GetPayroll()
        {
            double totalValue = 0.0;
            _saleReceipts.ToList().ForEach(sr => totalValue += ((sr.Amount) * _commissionRate));
            return totalValue;
        }
    }
}
