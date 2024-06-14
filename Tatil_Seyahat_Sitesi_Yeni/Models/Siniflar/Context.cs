using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Tatil_Seyahat_Sitesi_Yeni.Models.Siniflar
{
    public class Context:DbContext
    {
        public DbSet<Admin> admins {  get; set; }
        public DbSet<AdresBlog> adresBlogs {  get; set; }
        public DbSet<Blog> blogs {  get; set; }
        public DbSet<Hakkımızda> hakkımızdas {  get; set; }
        public DbSet<iletisim> iletisims  {  get; set; }
        public DbSet<Yorumlar> yorumlars  {  get; set; }


    }
}