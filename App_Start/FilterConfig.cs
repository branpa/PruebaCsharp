﻿using System.Web;
using System.Web.Mvc;

namespace Prueba_de_Aplicacion
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
