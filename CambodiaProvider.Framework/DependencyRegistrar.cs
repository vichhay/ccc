using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Autofac;
using Autofac.Core;
using Autofac.Builder;
using Autofac.Integration.Mvc;
using CambodiaProvider.Core.Infrastructure;
using CambodiaProvider.Core;
using CambodiaProvider.Core.Infrastructure.DependencyManagement;


namespace CambodiaProvider.Framework
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {

        }


        public int Order
        {
            get { return -100; }
        }
    }





}
