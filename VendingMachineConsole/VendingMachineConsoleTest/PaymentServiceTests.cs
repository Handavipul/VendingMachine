using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineConsole.Service;

namespace VendingMachineConsoleTest
{
    public class PaymentServiceTests
    {
        [Test]
        public void InsertCoin_AddsAmount()
        {
            var tracker = new PaymentTracker();
            tracker.InsertCoin(0.25m);
            Assert.AreEqual(0.25m, tracker.CurrentAmount);
        }

        [Test]
        public void Reset_SetsAmountToZero()
        {
            var tracker = new PaymentTracker();
            tracker.InsertCoin(0.25m);
            tracker.Reset();
            Assert.AreEqual(0.00m, tracker.CurrentAmount);
        }
    }
}
