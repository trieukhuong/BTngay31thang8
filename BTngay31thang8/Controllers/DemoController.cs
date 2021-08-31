using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap2.Controllers
{
    public class DemoBTngay31thang8Controller : Controller
    {
        // GET: DemoBTngay31thang8
        public ActionResult Giaiphuongtrinh()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Giaiphuongtrinh(string soX, string soY)
        {
            double soa = Convert.ToDouble(soX);
            double sob = Convert.ToDouble(soY);
            double ketqua = -sob / soa;
            ViewBag.Giaipt = ketqua;
            return View();
        }
    }
}