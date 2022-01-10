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
        public Test1(int Q,int W, decimal E,int R)
        {
            q = Q;
            w = W;
            e = E;
            r = R;
        }
        public int q { get; set; }
        public int w { get; set; }
        public decimal e { get; set; }
        public int r { get; set; }
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