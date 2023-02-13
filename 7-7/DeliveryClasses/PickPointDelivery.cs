using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7.DeliveryClasses
{
    internal class PickPointDelivery : Delivery
    {
        public string Provider { get; set; }


        public PickPointDelivery(string city, string country, string address) : base(city, country, address)
        {
            Console.WriteLine("PickPoint Delivery");
        }

        public override string GetDeliveryInfo()
        {
            return $"DeliveryType: PickPoint delivery" +
                    $"\nCity: {this.Country}" +
                    $"\nCity:{this.City}" +
                    $"\nAggress{this.Address}" +
                    $"\nProvider: {this.Provider}";
        }
    }
}
