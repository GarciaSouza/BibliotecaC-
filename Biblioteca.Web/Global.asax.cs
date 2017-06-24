using Biblioteca.Domain.Repositories;
using Biblioteca.NH.Repositories;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Biblioteca.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static Container Container;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
            Container = new Container();
            Container.Register<ILivroRepository, LivroRepository>();
            Container.Register<IRevistaRepository, RevistaRepository>();
            Container.Verify();
        }
    }
}
