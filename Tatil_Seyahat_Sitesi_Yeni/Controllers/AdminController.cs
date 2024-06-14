using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tatil_Seyahat_Sitesi_Yeni.Models.Siniflar;

namespace Tatil_Seyahat_Sitesi_Yeni.Controllers
{
	public class AdminController : Controller
	{
		// GET: Admin
		Context c = new Context();
		[Authorize]
		public ActionResult Index()
		{
			var degerler = c.blogs.ToList();
			return View(degerler);
		}

		[HttpGet]
		public ActionResult YeniBlog()
		{
			return View();
		}


		[HttpPost]
		public ActionResult YeniBlog(Blog p)
		{
			c.blogs.Add(p);
			c.SaveChanges();
			return RedirectToAction("Index");
		}


		public ActionResult BlogSil(int id)
		{
			var b = c.blogs.Find(id);
			c.blogs.Remove(b);
			c.SaveChanges();
			return RedirectToAction("Index");
		}


		public ActionResult BlogGetir(int id)
		{
			var bl=c.blogs.Find(id);
			return View("BlogGetir",bl);
		}

		public ActionResult BlogGuncelle(Blog b)
		{
			var blg = c.blogs.Find(b.Id);
			blg.Aciklama=b.Aciklama;
			blg.Baslik = b.Baslik;
			blg.BlogImage = b.BlogImage;
			blg.Tarih = b.Tarih;
			c.SaveChanges();
			return RedirectToAction("Index");
		}

		// Yorum Controller Olarak da alınabilirdi
		public ActionResult YorumListesi()
		{
			var yorumlar=c.yorumlars.ToList();
			return View(yorumlar);
		}


		public ActionResult YorumSil(int id)
		{
			var y = c.yorumlars.Find(id);
			c.yorumlars.Remove(y);
			c.SaveChanges();
			return RedirectToAction("YorumListesi");
		}

		public ActionResult YorumGetir(int id)
		{
			var yr = c.yorumlars.Find(id);
			return View("YorumGetir", yr);
		}


		public ActionResult YorumGuncelle(Yorumlar y)
		{
			var yrm=c.yorumlars.Find(y.Id);
			yrm.KullaniciAdi=y.KullaniciAdi;
			yrm.Mail = y.Mail;
			yrm.Yorum=y.Yorum;
			c.SaveChanges();
			return RedirectToAction("YorumListesi");	
		}



		// Hakkımda Kısımı

		public ActionResult About()
		{
			var hk = c.hakkımızdas.ToList();
			return View(hk);
		}


		[HttpGet]
		public ActionResult YeniAbout()
		{
			return View();
		}


		[HttpPost]
		public ActionResult YeniAbout(Hakkımızda p)
		{
			c.hakkımızdas.Add(p);
			c.SaveChanges();
			return RedirectToAction("About");
		}

		public ActionResult AboutSil(int id)
		{
			var b = c.hakkımızdas.Find(id);
			c.hakkımızdas.Remove(b);
			c.SaveChanges();
			return RedirectToAction("About");
		}


		public ActionResult AboutGetir(int id)
		{
			var ab = c.hakkımızdas.Find(id);
			return View("AboutGetir", ab);
		}


		public ActionResult AboutGuncelle(Hakkımızda h)
		{
			var hkm = c.hakkımızdas.Find(h.ID);
			hkm.Aciklama = h.Aciklama;
			hkm.ResimUrl = h.ResimUrl;
			c.SaveChanges();
			return RedirectToAction("About");
		}
	}
}