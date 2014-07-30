using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using CambodiaProvider.Core.Infrastructure;
using Autofac;
using Autofac.Integration.Mvc;
using System.Reflection;
using CambodiaProvider.Core;
using CambodiaProvider.Web.Models;
using CambodiaProvider.Core.Infrastructure.DependencyManagement;

namespace CambodiaProvider.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            EngineContext.Initialize(false);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
        }
    }

    public static class ContainerCook
    {
        public static IContainer Container { get; set; }
    }
}
