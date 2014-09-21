using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using OtasV3.Domain.Entities;
using OtasV3.Repository.Interfaces;

namespace OtasV3.Repository.Repository
{
    public class OtasContext : IdentityDbContext<ApplicationUser>, IOtasContext
    {
        public DbSet<Class> Classes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<OtasFeedback> OtasFeedbacks { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherFeedback> TeacherFeedbacks { get; set; }
        public DbSet<TeacherFeeedbackSummary> TeacherFeeedbackSummaries { get; set; }

        public OtasContext() : base("DefaultConnection")
        {
            
        }
        //For ASP Identity
        public static OtasContext Create()
        {
            return new OtasContext();
        }
    }
}