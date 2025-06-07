using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineConsole.Service
{
    public class PaymentTracker
    {
        private decimal _currentAmount = 0;

        public decimal CurrentAmount => _currentAmount;

        public void InsertCoin(decimal value) => _currentAmount += value;

        public void Reset() => _currentAmount = 0;
    }
}
