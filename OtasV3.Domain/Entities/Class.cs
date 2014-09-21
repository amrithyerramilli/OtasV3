using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OtasV3.Domain.Entities
{
    public class Class : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int SemesterId { get; set; }
        
        [ForeignKey("SemesterId")]
        public virtual Semester Semester { get; set; }
        public string Section { get; set; }
    }

    //Unsure if 'Section' is required. Not at the moment
    //public class Section : BaseEntity
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    public int Description { get; set; }
    //}
}