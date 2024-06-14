using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tatil_Seyahat_Sitesi_Yeni.Models.Siniflar
{
    public class Hakkımızda
    {
        [Key] 
        public int ID { get; set; }
        public string ResimUrl { get; set; }
        public string Aciklama { get; set; }
    }
}