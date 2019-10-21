using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INF272_Project.ViewModels
{
    public class ReportViewModel : HomeworkVM
    {
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public ReportViewModel(string homeworkdescription, string subject, int level, string questions, int markachieved, string duedate, string description, DateTime date)
        {
            HomeworkDescription = homeworkdescription;
            Subject = subject;
            Level = level;
            Questions = questions;
            MarkAchieved = markachieved;
            DueDate = duedate;
            Description = description;
            Date = date;


        }

    }
}