using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SystemWeb.Data.Infastructure;

namespace SystemWeb.Wed.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
          
            return View();
        }
    }
}
