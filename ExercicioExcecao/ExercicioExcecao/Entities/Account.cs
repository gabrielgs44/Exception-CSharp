using ExercicioExcecao.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioExcecao.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double withdrawLimit, double balance = 0)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (WithdrawLimit < amount)
            {
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new DomainException("Withdraw error: Not enough balance");
            }
            Balance -= amount;
        }

        public override string ToString()
        {
            return $"New balance: {Balance.ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
