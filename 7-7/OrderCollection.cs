using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7
{
    internal class OrderCollection<TDelivery> where TDelivery : Delivery
    {
        private Order<TDelivery>[] orders;

        public OrderCollection(Order<TDelivery>[] orders)
        {
            this.orders = orders;
        }

        private int count;

        public int Count
        {
            get { return orders.Length; }
            //set { count = value; }
        }


        public Order<TDelivery> this[int index]
        {
            get
            {
                if (index >= 0 && index < orders.Length)
                    return orders[index];
                else
                    return null;
            }

            private set
            {
                if (index >= 0 && index < orders.Length)
                    orders[index] = value;
            }
        }
    }
}
