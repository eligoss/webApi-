using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using MarketStore.Web.App_Start;

namespace MarketStore
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            StructuremapWebApi.Start();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            
            var a = new Cache.CacheProvider();
            a.LoadEntities();
        }
    }
}
