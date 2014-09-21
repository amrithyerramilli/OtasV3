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
        IDbSet<Class> Classes { get; set; }
        IDbSet<Department> Departments { get; set; }
        IDbSet<OtasFeedback> OtasFeedbacks { get; set; }
        IDbSet<Semester> Semesters { get; set; }
        IDbSet<Student> Students { get; set; }
        IDbSet<Subject> Subjects { get; set; }
        IDbSet<Teacher> Teachers { get; set; }
        IDbSet<TeacherFeedback> TeacherFeedbacks { get; set; }
        IDbSet<TeacherFeeedbackSummary> TeacherFeeedbackSummaries { get; set; }
    }
}
