using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FunitureManager.Models;

namespace FunitureManager.Controllers
{
    public class OrderDetailController : ApiController
    {
        public IEnumerable<Order_Detail> Get()
        {
            using (FunitureStoreDBContext dbContext = new FunitureStoreDBContext())
            {
                return dbContext.Order_Detail.ToList();
            }
        }
        public Order_Detail Get(Guid id)
        {
            using (FunitureStoreDBContext dbContext = new FunitureStoreDBContext())
            {
                return dbContext.Order_Detail.FirstOrDefault(e => e.Id_Order == id);
            }
        }
    }
}
