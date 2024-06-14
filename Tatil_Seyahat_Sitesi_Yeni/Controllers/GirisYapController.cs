using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;
using System.Web.Security;
using Tatil_Seyahat_Sitesi_Yeni.Models.Siniflar;

namespace Tatil_Seyahat_Sitesi_Yeni.Controllers
{
	public class GirisYapController : Controller
	{
		// GET: GirisYap
		Context c = new Context();
		public ActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Login(Admin ad)
		{
			var bilgiler = c.admins.FirstOrDefault(x => x.Kullanici == ad.Kullanici && x.Sifre == ad.Sifre);


			if (bilgiler != null)
			{
				FormsAuthentication.SetAuthCookie(bilgiler.Kullanici, false);
				Session["Kullanici"] = bilgiler.Kullanici.ToString();
				return RedirectToAction("Index", "Admin");
			}

			else
			{
				return View();
			}


		}

		public ActionResult LogOut()
		{
			FormsAuthentication.SignOut();
			return RedirectToAction("Login","GirisYap");
		}

	}
}