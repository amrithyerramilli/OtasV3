using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OtasV3.Domain.Entities
{
    public class Subject : BaseEntity
    {
        [Key]
        public string SubjectCode { get; set; }
        public string Name { get; set; }
        public string DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
    }
}