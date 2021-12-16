using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FunitureManager.Models;

namespace FunitureManager.Controllers
{
    public class ShippingAddressController : ApiController
    {
        public IEnumerable<Shipping_Address> Get()
        {
            using (FunitureStoreDBContext dbContext = new FunitureStoreDBContext())
            {
                return dbContext.Shipping_Address.ToList();
            }
        }
        public Shipping_Address Get(Guid id)
        {
            using (FunitureStoreDBContext dbContext = new FunitureStoreDBContext())
            {
                return dbContext.Shipping_Address.FirstOrDefault(e => e.Id == id);
            }
        }
    }
}
