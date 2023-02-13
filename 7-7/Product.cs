using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7
{
    internal class Product
    {
        private int _barCode;

        public int BarCode
        {
            get
            {
                return _barCode;
            }
            private set
            {
                _barCode = value;
            }
        }

        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (value.Length < 5)
                    Console.WriteLine("Имя продукта должно быть не менее 5 символов.");
                else
                    _name = value;
            }
        }

        private double _price;

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value == 0.0)
                    Console.WriteLine("Цена не может быть равна 0, у нас тут не благотворительность");
                else
                    _price = value;
            }
        }

        public Product ()
        {
            _barCode = new Random().Next(1000, 9000);
        }

        public void DisplayProdictInfo()
        {
            Console.WriteLine($"Product:{_name}\t Price: {_price} \t Barcode: {_barCode}");
        }
    }


}
