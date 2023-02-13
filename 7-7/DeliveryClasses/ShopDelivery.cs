using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7.DeliveryClasses
{
    internal class ShopDelivery : Delivery
    {
        public string Name { get; set; }

        public ShopDelivery(string city, string country, string address) : base(city, country, address)
        {
            Console.WriteLine("Shop Delivery");
        }

        public override string GetDeliveryInfo()
        {
            return $"DeliveryType: Shop delivery" +
                    $"\nCity: {this.Country}" +
                    $"\nCity:{this.City}" +
                    $"\nAggress{this.Address}" +
                    $"\nName: {this.Name}";
        }
    }
}
