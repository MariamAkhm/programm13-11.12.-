﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace programm13_11
{
        public enum AccountType { Current, Saving };
        class BankAccount
        {
        private string nameHolder;
            private long number;
            private double balance;
            private AccountType accountType;
            private static long id;
            private Queue tranQueue = new Queue();
        public string NameHolder
        {
            get
            {
                return nameHolder;
            }
            set
            {
                nameHolder = value;
            }
        }
            public static long ID()
            {
                return id++;
            }
            public double Balance => balance;
            public AccountType AccountType => accountType;

            public BankAccount(AccountType accountType, double balance,string nameHolder)
            {
                number = ID();
                this.nameHolder = nameHolder;
                this.balance = balance;
                this.accountType = accountType;
            }
            public double Deposit(double summa, BankAccount bankAccount)
            {
                balance += summa;
                BankTransaction bankTransaction = new BankTransaction(summa);
                tranQueue.Enqueue(bankTransaction);
                return balance;
            }
            public double WithDrow(double summa, BankAccount bankAccount)
            {
                if (balance >= summa)
                {
                    balance -= summa;
                    BankTransaction bankTransaction = new BankTransaction(-summa);
                    tranQueue.Enqueue(bankTransaction);
                    Console.WriteLine($"Произошла операция: {bankTransaction}; Ваш баланс:{balance}");
                }
                else
                {
                    Console.WriteLine("Недостаточно средств!");
                }
                return balance;
            }
        [Conditional("DEBUGGING")]
        public void DumpToScreen()
        {
            Console.WriteLine($"Индекс счёта: {id}, Баланс счета:{balance} ,Тип счета:{accountType}");
        }
    }
}
