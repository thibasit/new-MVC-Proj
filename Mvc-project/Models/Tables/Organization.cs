using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mvc_project.Models.Tables
{
    public class Organization : BaseModel
    {
        [Required(ErrorMessage = "Organization name is required.")]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int CitiesId { get; set; }
        [ForeignKey("CitiesId")]
        public virtual Cities cities { get; set; } //FOREIGN KEY
        public string GoogleMapLocation { get; set; }


    }
}
