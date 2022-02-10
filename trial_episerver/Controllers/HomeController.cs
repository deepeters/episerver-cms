using EPiServer.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using trial_episerver.Models.Pages;

namespace trial_episerver.Controllers
{
    public class HomeController : PageController<Home>
    {
        // GET: Home
        public ActionResult Index(Home currentPage)
        {
            return View(currentPage);
        }
    }
}