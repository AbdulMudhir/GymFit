using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Models
{
    public interface IOrderRepository
    {

        public IEnumerable<Order> AllOrders { get;  }

        public void AddOrder(Order order);

    }
}
