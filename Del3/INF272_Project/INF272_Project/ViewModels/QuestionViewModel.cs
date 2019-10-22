using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INF272_Project.ViewModels
{
    public class QuestionViewModel
    {

        public int QuestionID { get; set; }
        public string Subject { get; set; }
        public string Question { get; set; }
        public int Answer { get; set; }
        public int GradeID { get; set; }
        public int Marks { get; set; }

        public List<QuestionViewModel> Questions { get; set; }
        public List<QuestionViewModel> QuestionsList { get; set; }

        public QuestionViewModel()
        {
            QuestionID = 0;
            Subject = "";
            Question = "";

            Answer = 0;
            GradeID = 0;
            Marks = 0;
        }


        public QuestionViewModel(int ID, string subject, string question, int ans, int grade, int mark)
        {
            QuestionID = ID;
            Subject = subject;
            Question = question;
            Answer = ans;
            GradeID = grade;
            Marks = mark;
        }
    }
}