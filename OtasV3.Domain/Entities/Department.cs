using System.ComponentModel.DataAnnotations;

namespace OtasV3.Domain.Entities
{
    public class Department : BaseEntity
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}