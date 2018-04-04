using System;
namespace SimbaBankAccount.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public string AnimalType { get; set; }
        public bool IsKing { get; set; }
        public bool IsBad { get; set; }
        private static int counter = 0;

        public BankAccount(string name, double balance,string animalType, bool isking, bool isbad)
        {
            this.Name = name;
            this.Balance = balance;
            this.AnimalType = animalType;
            this.IsKing = isking;
            this.IsBad = isbad;
            Id = System.Threading.Interlocked.Increment(ref counter);
        }
        public string FormatOfBalance()
        {
            return Balance.ToString("N2");
        }

        public string GoodOrBad()
        {
            if (IsBad)
            {
                return "Bad Guy";
            }
            else
            {
                return "Good One";
            }
        }
        public string KingOrNotKing()
        {
            if (IsKing)
            {
                return "*KING OF KINGS*";
            }
            else
            {
                return "";
            }
        }
    }

}
