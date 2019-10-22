using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using INF272_Project.ViewModels;

namespace INF272_Project.Controllers
{
    public class StarController : Controller
    {
        // GET: Star
        public ActionResult login()
        {

            return View();
        }
        public ActionResult home()
        {
            ViewBag.Message = "You are successfully logged in!";

            return View();
        }

        public ActionResult signup()
        {

            return View();
        }

        public ActionResult adminLogin()
        {

            return View();
        }

        public ActionResult adminHome()
        {

            return View();
        }
        public ActionResult myProfile()
        {
            return View();
        }


        ///////TIARA
        public ActionResult MathTest()
        {
            return View();
        }

        public ActionResult AnswerCorrect()
        {
            return View();
        }

        public ActionResult AnswerWrong()
        {
            return View();
        }

        public ActionResult TestResult()
        {
            return View();
        }


        public ActionResult Tests()
        {
            return View();
        }


        public List<TestViewModel> TestList = new List<TestViewModel>();
        public ActionResult ReadTest()
        {
            return View(TestList);
        }

        public ActionResult UpdateTest()
        {
            return View();
        }

        public ActionResult DeleteTest()
        {
            return View();
        }
        public List<SubjectViewModel> SubjectList = new List<SubjectViewModel>();
        public ActionResult ViewSubjects()
        {
            return View(SubjectList);
        }
        public ActionResult Subjects()
        {
            return View();
        }

        public ActionResult UpdateSubject()
        {
            return View();
        }

        public ActionResult DeleteSubject()
        {
            return View();
        }

        ///////Ravele
        public ActionResult Report()
        {
            return View();
        }

        public ActionResult Email()
        {
            return View();
        }

        public ActionResult EmailConfirm()
        {
            return View();
        }

        public ActionResult PDFdocument()
        {
            return View();
        }

        /////Ivana
        public ActionResult AddHomework()
        {
            return View();
        }
        public List<HomeworkVM> homeworkList = new List<HomeworkVM>();
        public ActionResult HomeworkList()
        {
            return View(homeworkList);
        }
        public ActionResult DeleteHomework()
        {
            return View();
        }
    }
}