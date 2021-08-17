namespace H3_TDD_Bank
{
    public interface IDataAccess
    {
        void Login(BankAccount bank, string pinCode);
    }
}