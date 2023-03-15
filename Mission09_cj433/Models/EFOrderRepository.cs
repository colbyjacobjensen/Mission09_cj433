using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_cj433.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private BookstoreContext context;

        public EFOrderRepository(BookstoreContext temp)
        {
            context = temp;
        }

        public IQueryable<Order> Orders => context.Orders.Include(b => b.Lines).ThenInclude(b => b.Book);

        public void SaveOrder(Order order)
        {
            context.AttachRange(order.Lines.Select(b => b.Book));

            if (order.OrderID == 0)
            {
                context.Orders.Add(order);
            }

            context.SaveChanges();
        }
    }
}