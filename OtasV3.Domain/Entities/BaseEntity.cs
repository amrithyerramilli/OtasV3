using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OtasV3.Domain.Entities
{
    public class BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)] //Equivalent to 'default' in SQL
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}