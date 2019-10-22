using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using INF272_Project.Models;

namespace INF272_Project.Controllers
{
    public class LearnerAccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            using (OurDBContextLearner db = new OurDBContextLearner())
            {
                return View(db.LearnerAccount.ToList());
            }

        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Register(LearnerAccount acc)
        {
            if (ModelState.IsValid)
            {

                using (OurDBContextLearner db = new OurDBContextLearner())
                {
                    db.LearnerAccount.Add(acc);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = acc.FirstName + " " + acc.LastName + " " + "successfully registered.";
            }
            return RedirectToAction("home", "Star");
        }
        //Login

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Login(LearnerAccount learner)
        {
            using (OurDBContextLearner db = new OurDBContextLearner())
            {

                var usr = db.LearnerAccount.Single(u => u.Username == learner.Username && u.Password == learner.Password);

                if (usr != null)
                {
                    Session["LearnerID"] = usr.LearnerID.ToString();
                    Session["UserName"] = usr.Username.ToString();
                    return RedirectToAction("home", "Star");
                }
                else
                {
                    ModelState.AddModelError("", "Username or Password is wrong.");
                }


                return View(ViewBag.Message);
            }
        }

        public ActionResult LoggedIn()
        {
            if (Session["LearnerID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }

}
