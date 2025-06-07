using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineConsole.Enum;

namespace VendingMachineConsole.Interface
{
    public interface ICoinIdentifier
    {
        CoinType Identify(double weight, double size);
        decimal GetCoinValue(CoinType coin);
    }
}
