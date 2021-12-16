using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FunitureManager.Models;


namespace FunitureManager.Controllers
{
    public class OrderController : ApiController
    {
        public IEnumerable<Order> Get()
        {
            using (FunitureStoreDBContext dbContext = new FunitureStoreDBContext())
            {
                return dbContext.Orders.ToList();
            }
        }
        public Order Get(Guid id)
        {
            using (FunitureStoreDBContext dbContext = new FunitureStoreDBContext())
            {
                return dbContext.Orders.FirstOrDefault(e => e.Id == id);
            }
        }
    }
}
