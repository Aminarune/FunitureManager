using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FunitureManager.Models;

namespace FunitureManager.Controllers
{
    public class CategoryController : ApiController
    {
        public IEnumerable<Category> Get()
        {
            using (FunitureStoreDBContext dbContext = new FunitureStoreDBContext())
            {
                return dbContext.Categories.ToList();
            }
        }
        public Category Get(Guid id)
        {
            using (FunitureStoreDBContext dbContext = new FunitureStoreDBContext())
            {
                return dbContext.Categories.FirstOrDefault(e => e.Id == id);
            }
        }
    }
}
