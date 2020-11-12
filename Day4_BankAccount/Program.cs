using System;

namespace Day4_BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount("Имя1");
            BankAccount b2 = new BankAccount("Имя2");
            b1.Deposit(100);
            BankAccount.Transfer(b1, b2, 10);

            Console.WriteLine($"Остаток у {b1}");
            Console.WriteLine($"Остаток у {b2}");
        }
    }
}
