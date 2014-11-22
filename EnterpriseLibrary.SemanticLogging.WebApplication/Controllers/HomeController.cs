using EnterpriseLibrary.SemanticLogging.WebApplication.EventSources;
using Microsoft.Practices.EnterpriseLibrary.SemanticLogging;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnterpriseLibrary.SemanticLogging.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ObservableEventListener listener = new ObservableEventListener();
            listener.EnableEvents(InformationEventSource.Log, EventLevel.LogAlways, Keywords.All);

            listener.LogToWindowsAzureTable("WebApp", "UseDevelopmentStorage=true;DevelopmentStorageProxyUri=http://127.0.0.1;");

            InformationEventSource.Log.Startup("Request started");

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