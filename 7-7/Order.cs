using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7
{
    internal class Order<TDelivery> where TDelivery : Delivery
    {
        public TDelivery Delivery;

        public int Number;

        public string Desription;

        private List<Product> _products = new List<Product>();

        public List<Product> Products
        {
            set
            {
                if (value is null)
                    Console.WriteLine("Заказ должен содержать товары");
                else
                    _products = value;
            }
            get { return _products; }
        }


        public void DisplayOrderInfo()
        {
            string deliveryInfo = Delivery.GetDeliveryInfo();
            Console.WriteLine($"_________\n" +
                $"ORDER {Number}:\n" +
                $"{Desription}\n" +
                $"{deliveryInfo}\n" +
                $"PRODUCTS:");
            foreach (var prodict in Products)
            {
                prodict.DisplayProdictInfo();
            }
            
        }
    }
}
