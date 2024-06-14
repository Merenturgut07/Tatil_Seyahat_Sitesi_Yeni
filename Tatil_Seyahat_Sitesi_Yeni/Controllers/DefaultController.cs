using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Tatil_Seyahat_Sitesi_Yeni.Models.Siniflar;

namespace Tatil_Seyahat_Sitesi_Yeni.Controllers
{
    public class DefaultController : Controller
    {
        Context c=new Context();
        public ActionResult Index()
        {
            var degerler=c.blogs.Take(10).ToList();
            return View(degerler);
        }

        public PartialViewResult Partial1()
        {
            var degerler = c.blogs.Take(10).ToList();
            return PartialView(degerler);
        }


        public PartialViewResult Partial2()
        {
            var degerler = c.blogs.Take(3).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial3()
        {
            var degerler = c.blogs.Take(3).OrderByDescending(x=>x.Id).ToList();
            return PartialView(degerler);
        }
    }
}