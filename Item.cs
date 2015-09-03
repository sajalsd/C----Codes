using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Item> itemList = new List<Item>();
            string itemname ;
            int quantity ;
            double price, sum= 0;
            int n;
            Console.WriteLine("How Many Item have you Purchased?");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nEnter item name : ");
                itemname = Console.ReadLine();
                Console.WriteLine("Enter quantity");
                quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the price of per item : ");
                price = Convert.ToDouble(Console.ReadLine());

                Item item = new Item(itemname, quantity, price);
                itemList.Add(item);
       
            }
       
            Console.WriteLine("Item Name\t Quantity \t Price");
            foreach (Item temp in itemList)
            {
                Console.WriteLine(temp.itemname + "\t\t\t" + temp.quantity + "\t\t" + temp.price + "\n");
                sum = sum + temp.price* temp.quantity;
            }

            Console.WriteLine("Total Price = "+sum );
            Console.ReadLine();

        }
    }



    public class Item
    {
        public string itemname { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }

        public Item(string itemname, int quantity, double price)
        {
            this.itemname = itemname;
            this.quantity = quantity;
            this.price = price;
        }
    }
}
