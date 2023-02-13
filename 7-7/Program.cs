using _7_7.DeliveryClasses;

namespace _7_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //string city = "City 1";
            //string county = "Country 1";
            //string address = "Address 1";

            //Order<HomeDelivery> order1 = new Order<HomeDelivery>();
            //order1.Number = 1;
            //order1.Desription = "Order 1";

            //order1.Delivery = new ("City 1", "Country 1", "Address 1");
            //order1.Delivery.EntranceNum = 1;
            //order1.Delivery.Floor = 1;
            //order1.Delivery.Recipient = "Vasya";

            //order1.Products.Add(new Product { Name = "Product 1", Price = 5.99 });
            //order1.Products.Add(new Product { Name = "Product 2", Price = 5.99 });

            //Order<PickPointDelivery> order2 = new Order<PickPointDelivery>();
            //order2.Number = 1;
            //order2.Desription = "Order 2";

            //order2.Delivery = new("City 2", "Country 2", "Address 3");
            //order2.Delivery.Provider = "Pochta Rossii";

            //order2.Products.Add(new Product { Name = "Product 1", Price = 5.99 });
            //order2.Products.Add(new Product { Name = "Product 2", Price = 5.99 });

            //Order<ShopDelivery> order3 = new Order<ShopDelivery>();
            //order3.Number = 1;
            //order3.Desription = "Order 3";

            //order3.Delivery = new("City 3", "Country 3", "Address 3");

            //order3.Products.Add(new Product { Name = "Product 1", Price = 5.99 });
            //order3.Products.Add(new Product { Name = "Product 2", Price = 5.99 });


            //order1.DisplayOrderInfo();
            //order2.DisplayOrderInfo();
            //order3.DisplayOrderInfo();

            Person person = new Person();
            
            var order1  =person.CreateHomeOrder();
            order1.Products = person.CreateProducts();

            var order2 = person.CreateHomeOrder();
            order2.Products = person.CreateProducts();

            person.homeOrderCollection = new OrderCollection<HomeDelivery>(new Order<HomeDelivery>[] { order1, order2 });
            person.GetHomeOrders();
            
        }
    }
}