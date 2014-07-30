using Autofac;
using Autofac.Integration.Mvc;
using CambodiaProvider.Core;
using CambodiaProvider.Core.Infrastructure;
using CambodiaProvider.Core.Infrastructure.DependencyManagement;
using CambodiaProvider.Web.Controllers;
using CambodiaProvider.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CambodiaProvider.Web.Infrastruture
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            builder.RegisterType<WebHelper>().As<IWebHelper>().InstancePerHttpRequest();
            //we cache presentation models between requests
            builder.RegisterType<HomeController>();
        }

        public int Order
        {
            get { return 2; }
        }
    }
}