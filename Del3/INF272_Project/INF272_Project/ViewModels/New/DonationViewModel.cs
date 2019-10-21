using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INF272_Project.ViewModels
{
    public class DonationViewModel
    {
        public string Description { get; set; }
        public double Amount { get; set; }


        public List<DonationViewModel> Donations { get; set; }


        public DonationViewModel()
        {
            
            Description = "";
            Amount = 0; 
        }
        public DonationViewModel(string description, double amount)
        {
            Description = description;
            Amount = amount;



        }
    }
}