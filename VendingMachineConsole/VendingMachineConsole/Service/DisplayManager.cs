using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineConsole.Service
{
    public class DisplayManager
    {
        private string _message = "INSERT COIN";

        public string GetMessage() => _message;

        public void ShowThankYou() => _message = "THANK YOU";
        public void ShowPrice(decimal price) => _message = $"PRICE: ${price:F2}";
        public void ShowInsertCoinOrAmount(decimal amount) => _message = amount == 0 ? "INSERT COIN" : $"${amount:F2}";
    }
}
