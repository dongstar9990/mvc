using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication23.Models;

namespace WebApplication23.Controllers
{
    public class MuaBanController : Controller
    {
        // GET: MuaBan
        public ActionResult Index()
        {
            List<SanPham> ds = new List<SanPham>();
            ds.Add(new SanPham("Sp01", "lEGION v3", "Legion.jpg", 10000));
            ds.Add(new SanPham("Sp02", "Lenovo 2021", "Lenovo.jpg", 12000));
            ds.Add(new SanPham("Sp03", "Dell Xpreion ", "Dell.jpg", 7000));
            ds.Add(new SanPham("Sp04", "Asus 2022", "asus.jpg", 9000));
            ds.Add(new SanPham("Sp05", "Macbook pro 2019", "Macbook.jpg", 15000));
            Session["hanghoa"] = ds;

            return View(ds);
        }

        public ActionResult chonMua(SanPhamMua spm)
        {
            List<SanPhamMua> dsmua = (List<SanPhamMua>)Session["giohang"];
            if(dsmua== null)
            {
                dsmua = new List<SanPhamMua>();
            }
            if (dsmua.Contains(spm))
            {
                int index = dsmua.IndexOf(spm);
                dsmua[index].soLuong++;
            }
            else
            {
                spm.soLuong = 1;
                dsmua.Add(spm);
            }
            Session["giohang"] = dsmua;
            return View();
        }

        public ActionResult xemGioHang()
        {
            List<SanPhamMua> dsmua = (List<SanPhamMua>)Session["giohang"];
            return View(dsmua);
        }

        public ActionResult xoaSanPham(string masp)
        {
            List<SanPhamMua> dsmua = (List<SanPhamMua>)Session["giohang"];

            SanPhamMua spm = new SanPhamMua();

            spm.maSP = masp;
            int index = dsmua.IndexOf(spm);
            spm = dsmua[index];
            dsmua.Remove(spm);
            Session["giohang"] = dsmua;
            return View("chonMua");
            

        }
        public ActionResult datMua()
        {
            List<SanPhamMua> dsmua = (List<SanPhamMua>)Session["giohang"];
            Session.Remove("giohang");
            return View(dsmua);

        }

    }
}