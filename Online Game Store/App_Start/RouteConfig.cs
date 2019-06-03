using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Online_Game_Store
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /* // Defining a custom route for "/games/released/year/month" same as default
             routes.MapRoute(
                 "GamesByReleaseDate",
                 "games/released/{year}/{month}",
                 new { controller = "games", action = "ByReleaseDate" },
                 // adding comstraing to route that year must be of 4 and month must be of 2 digits
                 new { year = @"\d{4}", month = @"\d{2}" }
                 ); */

            // Better way than using above commented method is using Attribute Rounting

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
