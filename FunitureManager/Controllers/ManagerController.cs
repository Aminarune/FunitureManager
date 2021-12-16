using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FunitureManager.Models;

namespace FunitureManager.Controllers
{
    public class ManagerController : ApiController
    {
        public IEnumerable<Manager> Get()
        {
            using (FunitureStoreDBContext dbContext = new FunitureStoreDBContext())
            {
                return dbContext.Managers.ToList();
            }
        }
        public Manager Get(Guid id)
        {
            using (FunitureStoreDBContext dbContext = new FunitureStoreDBContext())
            {
                return dbContext.Managers.FirstOrDefault(e => e.Id == id);
            }
        }
    }
}
