using System;
namespace Shopping
{
    public class Item
    {
        public double Price { get; }
        public bool Imported { get; }
        public string Name { get; }
        public bool Exempt { get; }
        public double SaleTax { get; private set; }
        public double Total { get; }
        public Item(string name, double price, bool imported, bool exempt)
        {
            this.Name = name;
            this.Price = price;
            this.Imported = imported;
            this.Exempt = exempt;
            this.SaleTax = 0;
            if (!exempt) 
            {
                SaleTax += Price * 0.1;
                roundTax();
            }
            if (imported) {
                SaleTax += Price * 0.05;
                roundTax();
            }
            Total = Price + SaleTax;
        }
        private void roundTax() 
        {
            int newTax = (int) (SaleTax * 100);
            int rem = newTax % 10;
            if (rem > 0 && rem < 5) 
            {
                newTax = newTax - rem + 5;
            }
            else if (rem > 5) 
            {
                newTax = newTax - rem + 10;
            }
            SaleTax = newTax * 1.0 / 100;
        }
        public override string ToString() 
        {
            string item = "";
            if (Imported) 
            {
                item += "imported ";
            }
            return item + Name + " at " + Total.ToString("n2");
        }
		public override bool Equals(object obj)
		{
            var item = obj as Item;
            return this.Name.Equals(item.Name) 
                       && this.Price == item.Price
                       && this.Imported == item.Imported 
                       && this.Exempt == item.Exempt;
		}
        public override int GetHashCode()
        {
            return this.Name.GetHashCode() + this.Imported.GetHashCode() 
                       + this.Price.GetHashCode() + this.Exempt.GetHashCode();
        }
    }
}
