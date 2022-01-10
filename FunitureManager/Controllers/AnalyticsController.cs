using FunitureManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FunitureManager.Controllers
{
    public class AnalyticsController : Controller
    {
        private FunitureStoreDBContext db = new FunitureStoreDBContext();
        // GET: Analytics

        public ActionResult Indexanalytics()
        {
            List<int> listint = new List<int>();
            List<String> liststring = new List<String>();
            var all = db.Order_Detail.GroupBy(x => x.Id_Product)
                        .Select(x => new
                        {
                            id = x.Key,
                            q = x.Sum(y => y.Quantity)
                        }).OrderByDescending(z => z.q).ToList();
            foreach (var row in all)
            {
                Product p = db.Products.Find(row.id);
                listint.Add(row.q);
                liststring.Add(p.Name);
                System.Diagnostics.Debug.WriteLine("{0}: {1}", p.Name,row.q);
            }
            ViewBag.INT = listint;
            ViewBag.STRING = liststring;
            return View();
        }
        public JsonResult GetPiechartJSON()
        {
            List<Ana> list = new List<Ana>();
            var all = db.Order_Detail.GroupBy(x => x.Id_Product)
                        .Select(x => new
                        {
                            id = x.Key,
                            q = x.Sum(y => y.Quantity)
                        }).OrderByDescending(z => z.q).ToList();
            foreach (var row in all)
            {

                Product p = db.Products.Find(row.id);
                var b = new Ana(p.Name, row.q);
                list.Add(b);
                System.Diagnostics.Debug.WriteLine("{0}: {1}", b.ProductName, b.Quantity);
            }
            //return Json(new { JSONList = list }, JsonRequestBehavior.AllowGet);
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}