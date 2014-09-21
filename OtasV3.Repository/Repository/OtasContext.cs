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
        public IDbSet<Class> Classes { get; set; }
        public IDbSet<Department> Departments { get; set; }
        public IDbSet<OtasFeedback> OtasFeedbacks { get; set; }
        public IDbSet<Semester> Semesters { get; set; }
        public IDbSet<Student> Students { get; set; }
        public IDbSet<Subject> Subjects { get; set; }
        public IDbSet<Teacher> Teachers { get; set; }
        public IDbSet<TeacherFeedback> TeacherFeedbacks { get; set; }
        public IDbSet<TeacherFeeedbackSummary> TeacherFeeedbackSummaries { get; set; }

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