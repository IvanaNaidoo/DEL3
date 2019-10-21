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
        public ActionResult LearnerIndex()
        {
            using (OurDBContext1 db = new OurDBContext1())
            {
                return View(db.LearnerAccount.ToList());
            }

        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Register(LearnerAccount account)
        {
            if (ModelState.IsValid)
            {

                using (OurDBContext1 db = new OurDBContext1())
                {
                    db.LearnerAccount.Add(account);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.FirstName + " " + account.LastName + " " + "successfully registered.";
            }
            return View();
        }
        //Login

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Login(LearnerAccount learner)
        {
            using (OurDBContext1 db = new OurDBContext1())
            {
                var usr = db.LearnerAccount.Single(u => u.Username == learner.Username && u.Password == learner.Password);

                if (usr != null)
                {
                    Session["UserID"] = usr.LearnerID.ToString();
                    Session["UserName"] = usr.Username.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "Username or Password is wrong.");
                }
                return View();
            }
        }

         public ActionResult LoggedIn()
        {
          if (Session["UserID"] != null)
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