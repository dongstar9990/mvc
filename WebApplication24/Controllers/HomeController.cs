using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication24.Models;
using PagedList;

namespace WebApplication24.Controllers
{
    public class HomeController : Controller
    {
        private Model1 db = new Model1(); 
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult displaySuplier(int? page)
        {
            var suppliers = db.Nha_CC.Select(s => s);
            // sap xep truoc khi phan trang
            suppliers = suppliers.OrderBy(s => s.MaNCC);
            int pageSize = 3;
            int pageNumber=(page ??1);
            return View(suppliers.ToPagedList(pageNumber,pageSize));
        }
    }
}