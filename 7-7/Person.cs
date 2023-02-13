using _7_7.DeliveryClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7
{
    internal class Person
    {
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public int Age { get; set;}

        public OrderCollection<HomeDelivery> homeOrderCollection { get; set; }
        public OrderCollection<PickPointDelivery> ppOrderCollection { get; set; }
        public OrderCollection<ShopDelivery> shopOrderCollection { get; set; }


        public Order<HomeDelivery> CreateHomeOrder()
        {
            Order<HomeDelivery> order = new Order<HomeDelivery>();
            order.Number = 1;
            order.Desription = "Order 1";

            order.Delivery = new("City 1", "Country 1", "Address 1");
            order.Delivery.EntranceNum = 1;
            order.Delivery.Floor = 1;
            order.Delivery.Recipient = "Vasya";

            return order;
        }

        public Order<ShopDelivery> CreateShopDelivery()
        {
            Order<ShopDelivery> order = new Order<ShopDelivery>();
            order.Number = 1;
            order.Desription = "Order 3";

            order.Delivery = new("City 3", "Country 3", "Address 3");

            return order;
        }

        public List<Product> CreateProducts()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { Name = "Product 1", Price = 5.99 });
            products.Add(new Product { Name = "Product 2", Price = 5.99 });         
            return products;
        }

        public void GetHomeOrders()
        {
           for(int i = 0; i < homeOrderCollection.Count; i++)
            {
                homeOrderCollection[i].DisplayOrderInfo();
            }
        }


    }
}
