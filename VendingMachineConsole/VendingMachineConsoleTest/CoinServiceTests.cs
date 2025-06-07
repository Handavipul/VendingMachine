using VendingMachineConsole.Enum;
using VendingMachineConsole.Service;

namespace VendingMachineConsoleTest
{
    public class CoinServiceTests
    {
        [Test]
        public void Identify_Nickel_ReturnsNickel()
        {
            var identifier = new USCoinIdentifier();
            var type = identifier.Identify(5, 21.21);
            Assert.AreEqual(CoinType.Nickel, type);
        }

        [Test]
        public void GetCoinValue_Quarter_Returns025()
        {
            var identifier = new USCoinIdentifier();
            var value = identifier.GetCoinValue(CoinType.Quarter);
            Assert.AreEqual(0.25m, value);
        }
    }
}