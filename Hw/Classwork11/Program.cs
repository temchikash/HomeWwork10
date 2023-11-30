using Classwork11.Bank2;
using Classwork11.BuildingCreator;

namespace ClassWork11
{
    class Program
    {
        public static void Task11()
        {
            Bank bank = new Bank();
            BankAccount bankacc1 = bank.CreateAccount();
            BankAccount bankacc2 = bank.CreateAccount();
            bank.DeleteAccount(bankacc1.Number());
            Console.WriteLine(bankacc1.Number());
        }
        public static void HomeTask11()
        {
            Building build1 = Creator.Create();
            Building build2 = Creator.Create();
            Creator.Delete(build1.Number);
            Console.WriteLine(build1.Number);
        }
        static void Main(string[] args)
        {
            HomeTask11();
        }
    }
}