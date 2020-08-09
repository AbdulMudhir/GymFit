using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DatabaseContext _databaseContext;

        public OrderRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IEnumerable<Order> AllOrders => _databaseContext.Orders.Include(o => o.orderDetails);

        public void AddOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
