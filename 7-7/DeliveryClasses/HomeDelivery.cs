using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7.DeliveryClasses
{
    internal class HomeDelivery : Delivery
    {
        public int EntranceNum { get; set; }
        public int Floor { get; set; }
        public string Recipient { get; set; }

        private int _entranceNum;
        private int _floor;
        private string _Recipient;

        public HomeDelivery(string city, string country, string address) : base(city, country, address)
        {
            Console.WriteLine("Home Delivery");  
        }

        public override string GetDeliveryInfo()
        {
            return $"DeliveryType: Home delivery" +
                    $"\nCountry: {this.Country}" +
                    $"\nCity:{this.City}" +
                    $"\nAggress{this.Address}" +
                    $"\nEntranceNum: {this.EntranceNum}" +
                    $"\nFloor:{this.Floor}" +
                    $"\nRecipient:{this.Recipient}";
        }


    }
}
