using FactoryMethodPattern;
using System;
using Xunit;

namespace FactoryMethodPatternTests
{
    public class FactoryMethodPatternUnitTests
    {
        [Fact]
        public void GetSavingsAccount_CitiSavingsAcctFromFactory_Success()
        {
            ICreditUnionFactory factory = new SavingsAcctFactory() as ICreditUnionFactory;
            ISavingsAccount citiAcct = factory.GetSavingsAccount("CITI-321");
            Assert.True(citiAcct is CitiSavingsAcct);
        }

        [Fact]
        public void GetSavingsAccount_NationalSavingsAcctFromFactory_Success()
        {
            ICreditUnionFactory factory = new SavingsAcctFactory() as ICreditUnionFactory;
            ISavingsAccount nationalAcct = factory.GetSavingsAccount("NATIONAL-987");
            Assert.True(nationalAcct is NationalSavingsAcct);
        }

        [Fact]
        public void GetSavingsAccount_ChaseSavingsAcctFromFactory_ThrowsArgumentException()
        {
            ICreditUnionFactory factory = new SavingsAcctFactory() as ICreditUnionFactory;
            ArgumentException exception = Assert.Throws<ArgumentException>(
                () => factory.GetSavingsAccount("CHASE-845"));
            Assert.Equal("Invalid Account Number", exception.Message);
        }
    }
}