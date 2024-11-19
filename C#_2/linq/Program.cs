using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Product p = new Product("phone",12.5,"Electronics");
            products.Add(p);
            Product p1 = new Product("doll", 14, "toys");
            products.Add(p1);
            Product p2 = new Product("car", 36, "TransportVehicle");
            products.Add(p2);
            Product p3 = new Product("toster", 121.9, "Electronics");
            products.Add(p3);
            Product p4 = new Product("pen", 12.5, "Stationery");
            products.Add(p4);
            Console.WriteLine("Electronics products:");
            var electronics = products.Where( prodct => prodct.productCategory.Equals("Electronics")).ToList();
            foreach ( var electronic in electronics )
                electronic.toString();
            Console.WriteLine("sort by price:");
            var sortProducts = products.OrderBy(pro=>pro.productPrice).ToList();
            foreach ( var sortProduct in sortProducts )
                sortProduct.toString();
            Console.WriteLine("A price greater than 50");
            var older50 = products.Where(prdct => prdct.productPrice>50).ToList();
            foreach(var old50 in older50)
                old50.toString();
        }
    }
}
