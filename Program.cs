using System;

namespace BankAccountt
{
    public class BankAccount
    {
        public const string DebitAmountExceedsBalanceMessage = "Debit amount exceeds balance";
        public const string DebitAmountLessThanZeroMessage = "Debit amount is less than zero";

        private readonly string? m_customerName;
        private double m_balance;


        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        public string CustomerName
        {
            get { return m_customerName; }

        }

        public double Balance
        {
            get { return m_balance; }
            set { m_balance = value; }
        }

        public void Debit(double amount)
        {
            if (amount > m_balance)
            {
                throw new System.ArgumentOutOfRangeException("amount", amount, DebitAmountExceedsBalanceMessage);
            }

            if (amount < 0)
            {
                throw new System.ArgumentOutOfRangeException("amount",amount, DebitAmountLessThanZeroMessage);
            }
            m_balance -= amount;

        }


        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount", amount, "ERROR for credit amount: value out of range for credit");
            }

            m_balance += amount;
        }

        public static void Main()
        {
            BankAccount ba = new BankAccount("Mokebe Mekelele", 11.99); /*  warto 
            poeksperymentować z tymi wartościami !!! */

            ba.Credit(-5.77);   //  warto poeksperymentować z tymi wartościami !!!
            ba.Debit(111.22); //  warto poeksperymentować z tymi wartościami !!!

            Console.WriteLine("Current balance is ${0}", ba.Balance);
        }
    }
}

