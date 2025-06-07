using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineConsole.Enum;
using VendingMachineConsole.Interface;

namespace VendingMachineConsole.Service
{
    public class USCoinIdentifier : ICoinIdentifier
    {
        public CoinType Identify(double weight, double size)
        {
            if (weight == 5 && size == 21.21) return CoinType.Nickel;
            if (weight == 2.268 && size == 17.91) return CoinType.Dime;
            if (weight == 5.67 && size == 24.26) return CoinType.Quarter;
            return CoinType.Invalid;
        }

        public decimal GetCoinValue(CoinType coin) => coin switch
        {
            CoinType.Nickel => 0.05m,
            CoinType.Dime => 0.10m,
            CoinType.Quarter => 0.25m,
            _ => 0.00m
        };
    }
}
