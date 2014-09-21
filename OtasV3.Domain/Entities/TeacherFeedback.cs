using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OtasV3.Domain.Entities
{
    /// <summary>
    /// This table stores the raw feedback data
    /// </summary>
    public class TeacherFeedback : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        //Anonymous feedback :P Uncomment for some fun ;)
        //public string StudentId { get; set; }
        //[ForeignKey("StudentId")]
        //public virtual Student Student { get; set; }

        public string TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public virtual Teacher Teacher { get; set; }

        public int ClassId { get; set; }
        [ForeignKey("ClassId")]
        public virtual Class Class { get; set; }
        
        //TODO : Remove below lines if above 'Class' is enough :)
        //public int Semester { get; set; }
        //public string Section { get; set; } //TODO : should probably use 'char' here
        //public string DepartmentId { get; set; }
        //public string SubjectId { get; set; }

        public int Attribute1 { get; set; }
        public int Attribute2 { get; set; }
        public int Attribute3 { get; set; }
        public int Attribute4 { get; set; }
        public int Attribute5 { get; set; }
        public int Attribute6 { get; set; }
        public int Attribute7 { get; set; }
        public int Attribute8 { get; set; }
        public int Attribute9 { get; set; }
        public int Attribute10 { get; set; }
    }
}