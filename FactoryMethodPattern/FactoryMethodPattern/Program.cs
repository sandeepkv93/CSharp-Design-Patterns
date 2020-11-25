using System;

namespace FactoryMethodPattern
{
    // Product
    public abstract class ISavingsAccount
    {
        public decimal Balance { get; set; }
    }

    // Concrete Product
    public class CitiSavingsAcct : ISavingsAccount
    {
        public CitiSavingsAcct()
        {
            Balance = 5000;
        }
    }

    // Concrete Product
    public class NationalSavingsAcct : ISavingsAccount
    {
        public NationalSavingsAcct()
        {
            Balance = 2000;
        }
    }

    // Creator
    public interface ICreditUnionFactory
    {
        ISavingsAccount GetSavingsAccount(string acctNo);
    }

    // Concrete Creators
    public class SavingsAcctFactory : ICreditUnionFactory
    {
        public ISavingsAccount GetSavingsAccount(string acctNo)
        {
            if (acctNo.Contains("CITI"))
            {
                return new CitiSavingsAcct();
            }
            else if (acctNo.Contains("NATIONAL"))
            {
                return new NationalSavingsAcct();
            }
            else
            {
                throw new ArgumentException("Invalid Account Number");
            }
        }
    }
}
