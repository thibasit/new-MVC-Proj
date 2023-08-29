using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mvc_project.Models.Tables
{
    public class BaseModel
    {

        [Key , Required(ErrorMessage = "Id is required for further process.")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int CreatedBy { get; set; }

       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedBy { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime ModifiedDate { get; set; }
        public DateTime DeletedDate { get; set; }

    }
}
