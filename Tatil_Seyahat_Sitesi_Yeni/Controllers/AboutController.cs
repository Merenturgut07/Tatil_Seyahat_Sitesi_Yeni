using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Tatil_Seyahat_Sitesi_Yeni.Controllers;
using Tatil_Seyahat_Sitesi_Yeni.Models.Siniflar;

namespace Tatil_Seyahat_Sitesi_Yeni.Controllers
{
    public class AboutController : Controller
    {
        Context c=new Context();
        public ActionResult Index()
        {
            var degerler = c.hakkımızdas.ToList();
            return View(degerler);
        }
    }
}