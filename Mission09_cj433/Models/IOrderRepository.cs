using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_cj433.Models
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }

        void SaveOrder(Order order);
    }
}