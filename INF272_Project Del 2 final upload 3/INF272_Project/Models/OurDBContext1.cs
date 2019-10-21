using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace INF272_Project.Models
{
    public class OurDBContext1: DbContext
    {
        public DbSet<LearnerAccount> LearnerAccount { get; set; }
    }
}