using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INF272_Project.ViewModels
{
    public class SignUpViewModel : LearnerViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public SignUpViewModel(string Name, string Surname, string Email, string Number, string ParentName, string ParentSurname, string ParentEmail, string username, string password) : base(Name, Surname, Email, Number, ParentName, ParentSurname, ParentEmail)
        {
            Username = username;
            Password = password;

        }
    }
}