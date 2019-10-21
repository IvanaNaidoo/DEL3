using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INF272_Project.ViewModels
{
    public class SubjectViewModel
    {
        public string mSubjectTitle { get; set; }
        public string mSubjectDescription { get; set; }
        public int mSubjectCredits { get; set; }

        public List<SubjectViewModel> SubjectsList { get; set; }
        public List<SubjectViewModel> Subjects { get; set; }

        public SubjectViewModel()
        {
            // mTestID = 0;
            mSubjectTitle = "";
            mSubjectDescription = "";
            mSubjectCredits = 0;

        }


        public SubjectViewModel(string SubjectTitle, string SubjectDescription, int SubjectCredits)
        {
            mSubjectTitle = SubjectTitle;
            mSubjectDescription = SubjectDescription;
            mSubjectCredits = SubjectCredits;


        }
    }


}