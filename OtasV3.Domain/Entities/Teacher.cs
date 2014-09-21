using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using OtasV3.Domain.Enumerations;

namespace OtasV3.Domain.Entities
{
    public class Teacher : Person
    {
        [Key]
        public string TeacherId { get; set; }
        public Honorific Title { get; set; }
        
        [ForeignKey("TeacherId")]
        public virtual ICollection<TeacherFeedback> Feedback { get; set; }

        //[ForeignKey("TeacherId")]
        //public virtual TeacherUser UserInfo { get; set; }
    }
}