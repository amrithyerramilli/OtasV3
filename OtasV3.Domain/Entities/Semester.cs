using System.ComponentModel.DataAnnotations;

namespace OtasV3.Domain.Entities
{
    public class Semester : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int Description { get; set; }
    }
}