using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INF272_Project.ViewModels
{
    public class ParentViewModel
    {
        public string mParentName { get; set; }
        public string mParentSurname { get; set; }
        public string mParentEmail { get; set; }
        public List<ParentViewModel> Parents { get; set; }


        public ParentViewModel()
        {

           
            mParentName = "";
            mParentSurname = "";
            mParentEmail = "";

        }

        public ParentViewModel( string ParentName, string ParentSurname, string ParentEmail)
        {
          
            mParentName = ParentName;
            mParentSurname = ParentSurname;
            mParentEmail = ParentEmail;


        }
    }
}