using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using INF272_Project.ViewModels;
using INF272_Project.Models;

namespace INF272_Project.Controllers
{

    public class HomeworkController : Controller
    {      public List<QuestionViewModel> Questions = new List<QuestionViewModel>();
        StarKidzEntities1 db = new StarKidzEntities1();
        // GET: Homework
        public ActionResult UserHW()
        {
       

            int grade = 5;
           
            List<Question> question = db.Questions.Where(kk => kk.GradeID == grade).ToList();


            for (var k = 0; k < 5; k++)
            {
                Random random = new Random();
                k = random.Next(1, question.Count());

                Question q = question[k];

                var a = db.Subjects.Where(b => b.SubjectID == q.SubjectID).FirstOrDefault();
                QuestionViewModel obj = new QuestionViewModel(question[k].QuestionID,
                                                               a.Title,
                                                               question[k].Question1,
                                                               question[k].Answer.GetValueOrDefault(),
                                                               question[k].GradeID.GetValueOrDefault(),
                                                               question[k].Marks.GetValueOrDefault()
                                                               );
                Questions.Add(obj);
            }
            return View(Questions);

        
         

        }
        public ActionResult UserHWResults(int id)
        {
            Homework homework = new Homework();
            homework.Description = "homework" + ((db.Homeworks.Where(ff => ff.LearnerID == 1).ToList()).Count());
            homework.LearnerID = id;
            homework.HomeworkDate = DateTime.Today;
            db.SaveChanges();
            return View();
        }
    }
}