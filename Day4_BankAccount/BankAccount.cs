using System;
using System.Collections.Generic;
using System.Text;

namespace Day4_BankAccount
{
    class BankAccount
    {

        public string Owner { get; private set; }
        public decimal Balance{ get; private set; }

        public BankAccount(string Owner)
        {
            this.Owner = Owner;
            this.Balance = 0M;
        }

        public void Deposit(decimal Summa)
        {
            if (Summa < 0) throw new ArgumentException("Summa < 0");
            Balance += Summa;
        }

        public bool Withdraw(decimal Summa)
        {
            if (Summa < 0) throw new ArgumentException("Summa < 0");
            if (Balance > Summa)
            {
                Balance -= Summa;
                return true;
            }
            else
                return false;

        }

        public override string ToString()
        {
            return $"{Owner} : {Balance}";
        }

        public static bool Transfer(BankAccount source, BankAccount dest,
            decimal Summa)
        {
            Console.WriteLine($"Переводим {Summa}");

            if (source.Withdraw(Summa))
            {
                dest.Deposit(Summa);
                return true;
            }
            else
                return false;
        }

    }
}
