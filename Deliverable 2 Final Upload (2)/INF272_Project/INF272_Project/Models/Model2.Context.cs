﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace INF272_Project.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StarKidzEntities2 : DbContext
    {
        public StarKidzEntities2()
            : base("name=StarKidzEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Donation> Donations { get; set; }
        public virtual DbSet<Donor> Donors { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Homework> Homeworks { get; set; }
        public virtual DbSet<Learner> Learners { get; set; }
        public virtual DbSet<MarkLevel> MarkLevels { get; set; }
        public virtual DbSet<Parent> Parents { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
