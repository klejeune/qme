using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using QuantifyMe.Core;
using Teclyn.Core;
using Teclyn.Mongodb.Configuration;
using Teclyn.Web;

namespace QuantifyMe.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private TeclynWebServer teclyn =  new TeclynWebServer(new ServerInitializer(new MongodbStorageConfiguration(), Enumerable.Empty<Assembly>()));

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            teclyn.Start<Application>();
        }
        
        protected void Application_AuthenticateRequest(Object source, EventArgs e) {
            this.teclyn.AuthenticateRequest();
        }

        protected void Application_Error(object sender, EventArgs e) {
            this.teclyn.Error();
        }
    }
}
