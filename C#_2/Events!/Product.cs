using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Events_
{
    //public event NotifyIcon 
    internal class Product
    {
        public static int Quantity { get; set; }
        public string Name { get; set; }

        public event Action<string> OnOutOfStock;
        public event Action<string, int> OnStockUpdate;
        
        public Product(string name, int initialQuantity) {
            Name = name;
            Quantity = initialQuantity;
        }

        public void AddStock(int quantity)
        {
            Quantity += quantity;
            OnStockUpdate?.Invoke(Name, Quantity);
         }
        public void Sell(int quantity)
        {

            if (Quantity >= quantity)
            {
                Quantity -= quantity;
                OnStockUpdate?.Invoke(Name, Quantity);

                if (Quantity == 0)
                    OnOutOfStock?.Invoke(Name);
            }
            else
            {
                MessageBox.Show($"Not enough stock for {Name}!");
            }
        }
    }

}
