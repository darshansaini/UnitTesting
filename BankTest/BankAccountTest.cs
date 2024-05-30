using BankAccountNS;
namespace BankTest
{
    [TestClass]
    public class BankAccountTest
    {
        [TestMethod]
        public void Debit_WithValidAMount_UpdatesBalance()
        {
            double beginingBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;

            BankAccount account = new BankAccount("Mr. Bryan Walton", beginingBalance);

            account.Debit(debitAmount);

            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");


        }
    }
}