using CambodiaProvider.Core;
using CambodiaProvider.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac.Core;
using Autofac.Integration.Mvc;

namespace CambodiaProvider.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHelper _webHelper;

        public HomeController()
        {

        }

        public HomeController(IWebHelper web)
        {
            this._webHelper = web;
        }

        public ActionResult Index()
        {
            var x = EngineContext.Current.Resolve<IWebHelper>();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}