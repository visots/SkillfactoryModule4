using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7
{
    abstract class Delivery
    {
        protected string City { get; }
        protected string Country { get; }
        protected string Address { get; }


        public Delivery(string city, string country, string address)
        {
            City = city;
            Country = country;
            Address = address;
        }

        public abstract string GetDeliveryInfo();
    }
}
