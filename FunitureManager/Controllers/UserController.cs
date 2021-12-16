using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FunitureManager.Models;
using System.Data.Entity;

namespace FunitureManager.Controllers
{
    public class UserController : ApiController
    {
        public IEnumerable<User> Get()
        {
            using (FunitureStoreDBContext dbContext = new FunitureStoreDBContext())
            {
                return dbContext.Users.ToList();
            }
        }
        public User Get(Guid id)
        {
            using (FunitureStoreDBContext dbContext = new FunitureStoreDBContext())
            {
                return dbContext.Users.FirstOrDefault(e => e.Id == id);
            }
        }
    }
}
