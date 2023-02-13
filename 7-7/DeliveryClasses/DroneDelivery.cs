using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7.DeliveryClasses
{
    internal class DroneDelivery : Delivery
    {
        private double latitude;
        private double longitude;

        public DroneDelivery(string city, string country, string address) : base(city, country, address)
        {
            CalculateCoordinates(city, country, address);
        }

        public override string GetDeliveryInfo()
        {
            return $"DeliveryType: Home delivery" +
                     $"\nCountry: {this.Country}" +
                     $"\nCity:{this.City}" +
                     $"\nAggress{this.Address}";
        }

        private void CalculateCoordinates(string city, string country, string address)
        {
            double magicNumber = 1.4;
            double ultraMagicNumber = 7.8;

            if (city.Length > 5)
                magicNumber = magicNumber * city.Length;
            if(country.Length != 6)
                magicNumber = magicNumber / country.Length * 8;

            if (address.Contains('5'))
                ultraMagicNumber = 5 * magicNumber * magicNumber - 7;

            latitude = magicNumber;
            longitude = ultraMagicNumber - 2;
        }

    }
}
