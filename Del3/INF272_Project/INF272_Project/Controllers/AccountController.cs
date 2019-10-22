using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using INF272_Project.Models;

namespace INF272_Project.Controllers
{
    public class AccountController : Controller
    {
      
            // GET: Account
            public ActionResult Index()
            {
                using (OurDBContext db = new OurDBContext())
                {
                    return View(db.UserAccount.ToList());
                }

            }

            public ActionResult Register()
            {
                return View();
            }

            [HttpPost]

            public ActionResult Register(UserAccount account)
            {
                if (ModelState.IsValid)
                {

                    using (OurDBContext db = new OurDBContext())
                    {
                        db.UserAccount.Add(account);
                        db.SaveChanges();
                    }
                    ModelState.Clear();
                    ViewBag.Message = account.FirstName + " " + account.LastName + " " + "successfully registered.";
                }
            return RedirectToAction("adminHome", "Star");
        }
            //Login

            public ActionResult Login()
            {
                return View();
            }

            [HttpPost]

            public ActionResult Login(UserAccount user)
            {
                using (OurDBContext db = new OurDBContext())
                {
              
                    var usr = db.UserAccount.Single(u => u.Username == user.Username && u.Password == user.Password);

                    if (usr != null)
                    {
                        Session["UserID"] = usr.UserID.ToString();
                        Session["UserName"] = usr.Username.ToString();
                        return RedirectToAction("adminHome", "Star");
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
