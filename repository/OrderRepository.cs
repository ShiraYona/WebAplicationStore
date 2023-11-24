﻿
using Entytess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly StoreDataBase1Context _DbContext;

        public OrderRepository(StoreDataBase1Context dbContext)
        {
            _DbContext = dbContext;
        }
        public async Task<Order> CreateNewOrder(Order order)
        {
            
            await _DbContext.Orders.AddAsync(order);
            await _DbContext.SaveChangesAsync();
            return order;

        }
    }
}
