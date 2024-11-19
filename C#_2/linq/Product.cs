using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Product
    {
        public string productName {  get; set; }
        public double productPrice { get; set; } 
        public string productCategory { get; set; }
        public Product(string name, double price,string category) {
           this.productName = name;
           this.productPrice = price;
           this.productCategory = category;
        }
        public void toString()
        {
            Console.WriteLine(this.productName);
            Console.WriteLine(this.productPrice);
            Console.WriteLine(this.productCategory);
            Console.WriteLine();
        }
    }
}
