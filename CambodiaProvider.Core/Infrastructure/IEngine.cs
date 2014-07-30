using CambodiaProvider.Core.Infrastructure.DependencyManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CambodiaProvider.Core.Infrastructure
{
    public interface IEngine
    {
        ContainerManager ContainerManager { get; }

        /// <summary>
        /// Initialize components and plugins in the SmartStore environment.
        /// </summary>
        /// <param name="config">Config</param>
        //void Initialize(SmartStoreConfig config);
        void Initialize(SmartStoreConfig config);

        T Resolve<T>(string name = null) where T : class;

        object Resolve(Type type, string name = null);

        T[] ResolveAll<T>();
    }
}
