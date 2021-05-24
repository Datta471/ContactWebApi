using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace ContactWebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapHttpRoute(
                name: "MyTSPRoute",
                routeTemplate: "api/VTRouting/TSPRoute",
                defaults: new { }); 
            routes.MapHttpRoute(
                name: "MyRoute",
                routeTemplate: "api/VTRouting/Route", 
                defaults: new { action = "Route" });
        }
    }
}
