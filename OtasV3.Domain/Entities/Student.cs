using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using OtasV3.Domain.Enumerations;

namespace OtasV3.Domain.Entities
{
    public class Student : Person
    {
        [Key]
        public string Usn { get; set; }
        public int ClassId { get; set; }

        [ForeignKey("ClassId")]
        public virtual Class Class { get; set; }
        public bool IsRegistered { get; set; } //Determines if student details are entered

        //[ForeignKey("Usn")]
        //public virtual StudentUser UserInfo { get; set; }
    }
}