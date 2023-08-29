using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mvc_project.Models.Tables
{
    public class Cities : BaseModel
    {
        [Required(ErrorMessage = "City name is required.")]
        public string CityName { get; set; }
        public int CountryId { get; set; }  //  FOREIGN KEY IS USED
        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
    }
}
