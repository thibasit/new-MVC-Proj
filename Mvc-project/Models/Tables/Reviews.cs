using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mvc_project.Models.Tables
{
    public class Reviews : BaseModel
    {
        public int OrganizationId { get; set; } // foreign key
        public int UserId { get; set; } //foreign key

        [Required(ErrorMessage = "Rating is required.")]

        public double Rating { get; set; }
        public string ReviewText { get; set; }
        public DateTime ReviewDate { get; set; }

        [ForeignKey("OrganizationId")]
        public virtual Organization Organization { get; set; }
        [ForeignKey("UserId")]
        public virtual Users Users { get; set; }

    }
}
