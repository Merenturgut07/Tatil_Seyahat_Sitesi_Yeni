﻿using System.Web;
using System.Web.Mvc;

namespace Tatil_Seyahat_Sitesi_Yeni
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
