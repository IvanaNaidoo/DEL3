using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INF272_Project.ViewModels
{
    public class LearnerViewModel
    {
        public string mName { get; set; }
        public string mSurname { get; set; }
        public string mEmail { get; set; }
        public string mNumber { get; set; }
        public string mParentName { get; set; }
        public string mParentSurname { get; set; }
        public string mParentEmail{ get; set; }



        public List<LearnerViewModel>LearnerList { get; set; }
        public List<LearnerViewModel> Learners { get; set; }

        public LearnerViewModel()
        {

            mName = "";
            mSurname = "";
            mEmail = "";
            mNumber = "";
            mParentName = "";
            mParentSurname = "";
            mParentEmail = "";

        }


        public LearnerViewModel(string Name, string Surname, string Email, string Number, string ParentName, string ParentSurname, string ParentEmail)
        {
            mName = Name;
            mSurname = Surname;
            mEmail = Email;
            mNumber = Number;
            mParentName = ParentName;
            mParentSurname = ParentSurname;
            mParentEmail = ParentEmail;


        }
    }
}