using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OtasV3.Domain.Entities
{
    public class Department : BaseEntity
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}