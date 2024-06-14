using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Tatil_Seyahat_Sitesi_Yeni.Models.Siniflar;

namespace Tatil_Seyahat_Sitesi_Yeni.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c=new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            //var bloglar=c.blogs.ToList();
            by.deger1=c.blogs.ToList();
            by.deger3=c.blogs.OrderByDescending(x=>x.Id).Take(3).ToList();
            return View(by);
        }


        public ActionResult BlogDetay(int id)
        { 
            // var blogbul=c.blogs.Where(x=>x.Id==id).ToList();
            by.deger1=c.blogs.Where(x=>x.Id==id).ToList();
            by.deger2=c.yorumlars.Where(x=>x.Id==id).ToList();
            return View(by);
        }

        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }



        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
			c.yorumlars.Add(y);
			c.SaveChanges();
			return PartialView();
		}




    }
}