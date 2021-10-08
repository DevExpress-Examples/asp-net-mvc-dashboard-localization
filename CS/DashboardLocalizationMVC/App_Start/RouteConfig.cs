using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.DashboardWeb;
using DevExpress.DashboardCommon;
using DevExpress.DataAccess.Web;
using DevExpress.DataAccess.Sql;

namespace MVCDashboard {
    public class RouteConfig {
        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{resource}.ashx/{*pathInfo}");
            routes.MapDashboardRoute("dashboardControl", "DefaultDashboard");

            routes.MapRoute(
                name: "Default", // Route name
                url: "{controller}/{action}/{id}", // URL with parameters
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );
        }
    }
}