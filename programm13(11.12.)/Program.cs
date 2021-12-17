#define DEBUG_ACCOUNT
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm13_11._12._
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("14.1");
            string name = Console.ReadLine();
            BankAccount bankAccount = new BankAccount(AccountType.Current, 4567,name);
            bankAccount.DumpToScreen();

            Console.WriteLine("14.2");
            RationalNumber rational = new RationalNumber(3,5);
            Type typeInfo = typeof(RationalNumber);
            object[] attrs = typeInfo.GetCustomAttributes(false);
            Console.WriteLine((attrs[0] as DeveloperInfoAttribute).DateOfRealise);

            Console.WriteLine("14.3");
            Console.WriteLine("Домашнее задание 14.1");
            Building building = new Building(3,7,4,9);
            Type attr = typeof(Building);
            object[] attributes = attr.GetCustomAttributes(false);
            Console.WriteLine((attributes[0] as DeveloperInfoEmloyer).Company);

        }
    }
}
