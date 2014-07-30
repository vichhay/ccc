using CambodiaProvider.Core;
using Microsoft.Owin.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CambodiaProvider.Web.Models
{
    public class TaskController : Controller
    {
        private IWebHelper _repository;
        private ILogger _logger;

        // Autofac will automatically find the registered
        // values and pass them in for you.
        public TaskController(
          IWebHelper repository,
          ILogger logger)
        {
            this._repository = repository;
            this._logger = logger;
        }
    }
}