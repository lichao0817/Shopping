using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            test1();
            test2();
            test3();
        }
        public static void test1() 
        {
            Console.WriteLine("Shopping Basket 1: ");
            Cart cart = new Cart();
            cart.AddItem(new Item(name:"16lb bag of Skittles", price:16, imported:false, exempt:true));
            cart.AddItem(new Item(name:"Walkman", price:99.99, imported:false, exempt:false));
            cart.AddItem(new Item(name:"bag of microwave Popcorn", price:0.99, imported:false, exempt:true));
            if (Math.Abs(cart.SalesTax - 10.00) > 0.001) {
                string message = "The calculated sales tax is not correct.";
                Console.WriteLine(message);
                throw new Exception(message);
            }if (Math.Abs(cart.Total - 126.98) > 0.001)
            {
                string message = "The calculated total price is not correct.";
                Console.WriteLine(message);
                throw new Exception(message);
            }
            Console.WriteLine(cart);
            Console.WriteLine();
        }
        public static void test2()
        {
            Console.WriteLine("Shopping Basket 2: ");
            Cart cart = new Cart();
            cart.AddItem(new Item(name:"bag of Vanilla-Hazelnut Coffee", price:11, imported:true, exempt:true));
            cart.AddItem(new Item(name:"Vespa", price:15001.25, imported:true, exempt:false));
            if (Math.Abs(cart.SalesTax - 2250.8) > 0.001)
            {
                string message = "The calculated sales tax is not correct.";
                Console.WriteLine(message);
                throw new Exception(message);
            }
            if (Math.Abs(cart.Total - 17263.05) > 0.001)
            {
                string message = "The calculated total price is not correct.";
                Console.WriteLine(message);
                throw new Exception(message);
            }
            Console.WriteLine(cart);
            Console.WriteLine();
        }
        public static void test3() 
        {
            Console.WriteLine("Shopping Basket 3: ");
            Cart cart = new Cart();
            cart.AddItem(new Item(name: "crate of Almond Snickers", price: 75.99, imported: true, exempt: true));
            cart.AddItem(new Item(name: "Discman", price: 55.00, imported: false, exempt: false));
            cart.AddItem(new Item(name: "Bottle of Wine", price: 10.00, imported: true, exempt: false));
            cart.AddItem(new Item(name: "300# bag of Fair-Trade Coffee", price: 997.99, imported: false, exempt: true));
            if (Math.Abs(cart.SalesTax - 10.8) > 0.001)
            {
                string message = "The calculated sales tax is not correct.";
                Console.WriteLine(message);
                throw new Exception(message);
            }
            if (Math.Abs(cart.Total - 1149.78) > 0.001)
            {
                string message = "The calculated total price is not correct.";
                Console.WriteLine(message);
                throw new Exception(message);
            }
            Console.WriteLine(cart);
            Console.WriteLine();
        }
    }
}
