using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INF272_Project.ViewModels
{
    public class HomeworkVM
    {

        public string HomeworkDescription { get; set; }
        public string Subject { get; set; }
        public int Level { get; set; }
        public string Questions { get; set; }
        public int MarkAchieved { get; set; }
        public string DueDate { get; set; }

        public List<HomeworkVM> HomeworksList { get; set; }
        public List<HomeworkVM> homeworks { get; set; }

        public HomeworkVM()
        {
            // mTestID = 0;
            HomeworkDescription = "";
            Subject = "";
            Level = 0;
            Questions = "";
            MarkAchieved = 0;
            DueDate = "";
        }
        public HomeworkVM(string homeworkdescription, string subject, int level, string questions, int markachieved, string duedate)
        {
            HomeworkDescription = homeworkdescription;
            Subject = subject;
            Level = level;
            Questions = questions;
            MarkAchieved = markachieved;
            DueDate = duedate;




        }
    }
}