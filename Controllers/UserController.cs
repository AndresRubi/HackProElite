using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HackProElite.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult AdminIndex()
        {
            return View();
        }
        public ActionResult AdminEvent()
        {
            return View();
        }
    }
}