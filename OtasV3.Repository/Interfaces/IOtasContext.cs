using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtasV3.Domain.Entities;

namespace OtasV3.Repository.Interfaces
{
    public interface IOtasContext
    {
        DbSet<Class> Classes { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<OtasFeedback> OtasFeedbacks { get; set; }
        DbSet<Semester> Semesters { get; set; }
        DbSet<Student> Students { get; set; }
        DbSet<Subject> Subjects { get; set; }
        DbSet<Teacher> Teachers { get; set; }
        DbSet<TeacherFeedback> TeacherFeedbacks { get; set; }
        DbSet<TeacherFeeedbackSummary> TeacherFeeedbackSummaries { get; set; }
    }
}
