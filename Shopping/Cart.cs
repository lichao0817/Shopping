using System.Collections.Generic;

namespace Shopping
{
    public class Cart
    {
        private Dictionary<Item, int> Items;
        public double SalesTax { get; private set; }
        public double Total { get; private set; }
        public Cart()
        {
            Items = new Dictionary<Item, int>();
            Total = 0;
        }
        public void AddItem(Item item) 
        {
            if (!Items.ContainsKey(item)) 
            {
                Items[item] = 0;
            }
            Items[item] = Items[item] + 1;
            SalesTax += item.SaleTax;
            Total += item.Total;
        }
		public override string ToString()
		{
            string output = "";
            foreach (var pair in Items)
            {
                output += pair.Value + " " + pair.Key + "\n";
            }
            output += "Sales Taxes: " + SalesTax.ToString("n2") + "\n";
            output += "Total: " + Total.ToString("n2");
            return output;
		}
	}
}
