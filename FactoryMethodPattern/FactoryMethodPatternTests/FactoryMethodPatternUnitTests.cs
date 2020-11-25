using FactoryMethodPattern;
using Xunit;

namespace FactoryMethodPatternTests
{
    public class FactoryMethodPatternUnitTests
    {
        [Fact]
        public void GetSavingsAccount_CitiSavingsAcctFromFactory_Success()
        {
            ICreditUnionFactory factory = new SavingsAcctFactory();
            ISavingsAccount citiAcct = factory.GetSavingsAccount("CITI-321");
            Assert.True(citiAcct is CitiSavingsAcct);
        }
    }
}
