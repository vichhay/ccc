using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace CambodiaProvider.Core
{

    /// <summary>
    /// Common web helper
    /// </summary>
    public partial class WebHelper : IWebHelper
    {

        private readonly HttpContextBase _httpContext;


        public WebHelper()
        {

        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="httpContext"></param>
        public WebHelper(HttpContextBase httpContext)
        {
            this._httpContext = httpContext;
        }


        /// <summary>
        /// Get url referrer
        /// </summary>
        /// <returns></returns>
        public virtual string GetUrlReferrer()
        {
            string referrerUrl = String.Empty;

            if (this._httpContext != null &&
                this._httpContext.Request != null &&
                this._httpContext.Request.UrlReferrer != null)
                referrerUrl = this._httpContext.Request.UrlReferrer.ToString();

            return referrerUrl;
        }

        /// <summary>
        /// Get current Ip Address
        /// </summary>
        /// <returns>Ip address</returns>
        public virtual string GetCurrentIpAddress()
        {
            if (this._httpContext != null && this._httpContext.Request != null)
                return this._httpContext.Request.UserHostAddress.ToString();

            return String.Empty;
        }

        /// <summary>
        /// Get store location
        /// </summary>
        /// <returns>Store location</returns>
        public virtual string GetStoreLocation()
        {
            return String.Empty;
        }

    }
}
