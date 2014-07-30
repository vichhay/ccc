using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CambodiaProvider.Core
{
    public interface IWebHelper
    {

        /// <summary>
        /// Get Url referrer
        /// </summary>
        /// <returns></returns>
        string GetUrlReferrer();


        /// <summary>
        /// Get context Ip Address
        /// </summary>
        /// <returns></returns>
        string GetCurrentIpAddress();


        /// <summary>
        /// Get Store location
        /// </summary>
        /// <returns></returns>
        string GetStoreLocation();

    }
}
