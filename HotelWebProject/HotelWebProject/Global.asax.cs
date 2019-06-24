using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace HotelWebProject
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ViewEngines.Engines.RemoveAt(0);

            ViewEngineCollection vec = ViewEngines.Engines;

            RazorViewEngine razor = vec[0] as RazorViewEngine;

            razor.ViewLocationFormats = new string[] { "~/Views/{1}/{0}.cshtml", "~/Views/Shared/{0}.cshtml", "~/Areas/WebHotelManage/Views/{1}/{0}.cshtml" };
        }
    }
}
