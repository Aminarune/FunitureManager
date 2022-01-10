using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FunitureManager.Models
{
    public class ViewModel
    {
        FunitureStoreDBContext db = new FunitureStoreDBContext();
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<Order_Detail> Order_Details { get; set; }
        public IEnumerable<Test1> Tests1 { get; set; }
        public IEnumerable<Test2> Tests2 { get; set; }
    }
    public partial class Test1
    {
        public Test1(Guid id, int q)
        {
            id = this.id;
            q = this.q;
        }
        public System.Guid id { get; set; }
        public int q { get; set; }
    }
    public partial class Test2
    {
        public Test2(String N,byte[] P, decimal T)
        {
            n = N;
            p = P;
            t = T;
        }
        public String n { get; set; }
        public byte[] p { get; set; }
        public decimal t { get; set; }
    }
}