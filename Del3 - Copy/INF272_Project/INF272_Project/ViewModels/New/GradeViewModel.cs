using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INF272_Project.ViewModels
{
    public class GradeViewModel
    {
        public string Description { get; set; }
        public int Grade1 { get; set; }


        public List<GradeViewModel> Grades { get; set; }


        public GradeViewModel()
        {

            Description = "";
            Grade1 = 0;
        }
        public GradeViewModel(string description, int grade)
        {
            Description = description;
            Grade1 = grade;
        }
}