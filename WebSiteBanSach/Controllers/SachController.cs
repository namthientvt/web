using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteBanSach.Models;


namespace WebSiteBanSach.Controllers
{
    public class SachController : Controller
    {
        // GET: SachMoiPartial/
        QuanLyBanSachEntities db = new QuanLyBanSachEntities();
        public PartialViewResult SachMoiPartial()
        {
            var lstSachMoi = db.Saches.Take(5).ToList();
            return PartialView(lstSachMoi);
        }
    }
}