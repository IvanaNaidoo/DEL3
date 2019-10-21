using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INF272_Project.Controllers
{
    public class HomeworkController : Controller
    {
        // GET: Homework
        public ActionResult UserHW()
        {
            return View();

        }
        public ActionResult UserHWResults()
        {
            return View();
        }
    }
}