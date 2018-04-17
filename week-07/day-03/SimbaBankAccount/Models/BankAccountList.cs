using System;
using System.Collections.Generic;

namespace SimbaBankAccount.Models
{
    public class BankAccountList
    {

        public static List<BankAccount> Accounts = new List<BankAccount>
            {
            new BankAccount("Simba", 2000.00, "Lion", true,false),
            new BankAccount("Zordon", 1200.00, "Lion", false, true),
            new BankAccount("Rafiki", 900.00, "Mandrill", false, false),
            new BankAccount("Banzai", 200.00, "Hyena", false, true ),
            new BankAccount("Zazu", 1400.00, "Bird", false, false)
            };


    }
}
