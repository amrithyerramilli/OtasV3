using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OtasV3.Domain.Entities
{
    /// <summary>
    /// This table stores the feedback for the OTAS software
    /// </summary>
    public class OtasFeedback
    {
        [Key]
        public int Id { get; set; }
        public string Usn { get; set; }
        
        [ForeignKey("Usn")]
        public virtual Student Student { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public string Suggestion { get; set; }

    }
}