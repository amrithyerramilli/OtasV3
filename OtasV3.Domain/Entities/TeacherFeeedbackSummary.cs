using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OtasV3.Domain.Entities
{
    /// <summary>
    /// This table stores the summarized data (after calculating the Cgpa, Percentile, OverallRating
    /// </summary>
    public class TeacherFeeedbackSummary
    {
        [Key]
        public int Id { get; set; }

        public string TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public virtual Teacher Teacher { get; set; }

        public int ClassId { get; set; }
        [ForeignKey("ClassId")]
        public virtual Class Class { get; set; }

        public decimal? Cgpa { get; set; }
        public decimal? Percentile { get; set; }
        public decimal? OverallRating { get; set; }
    }
}