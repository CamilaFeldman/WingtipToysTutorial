using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Data.Entity;
using WingtipToys.Models;
using Nemiro.OAuth;
using Nemiro.OAuth.Clients;

namespace WingtipToysTutorial
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta al iniciar la aplicación
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            // Initialize the product database.
            Database.SetInitializer(new ProductDatabaseInitializer());
        }
      
    }
}
/*
 * app.UseGoogleAuthentication(new GoogleOAuth2AuthenticationOptions()
            {
                ClientId = "207441749760-qrrfhq4tabsf003bs6lqbi8l72es8132.apps.googleusercontent.com",
                ClientSecret = "DYVnUWe4MXrfGniky4DwH4WQ"
            });
  OAuthManager.RegisterClient
            (
                "google",
                "207441749760-qrrfhq4tabsf003bs6lqbi8l72es8132.apps.googleusercontent.com",
                "DYVnUWe4MXrfGniky4DwH4WQ"
            )
 */