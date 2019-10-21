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
        public string Description { get; set; }
        public double MarkAllocation { get; set; }


        public List<QuestionViewModel> QuestionsList { get; set; }
        public List<QuestionViewModel> Questions { get; set; }

        public QuestionViewModel()
        {
            QuestionID = 0;
            Description = "";
            MarkAllocation = 0;
            Subject = "";

        }


        public QuestionViewModel(int ID, string description, int markAllocation, string subject)
        {
            QuestionID = ID;
            Description = description;
            MarkAllocation = markAllocation;
            Subject = subject;


        }
    }
}