using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace INF272_Project.Models
{
    public class INF272_ProjectContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public INF272_ProjectContext() : base("name=INF272_ProjectContext")
        {
        }

        public System.Data.Entity.DbSet<INF272_Project.Models.Donation> Donations { get; set; }

        public System.Data.Entity.DbSet<INF272_Project.Models.Donor> Donors { get; set; }
    }
}
