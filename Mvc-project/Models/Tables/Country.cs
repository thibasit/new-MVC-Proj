using System.ComponentModel.DataAnnotations;

namespace Mvc_project.Models.Tables
{
    public class Country : BaseModel
    {
        [Required(ErrorMessage = "Country name is required.")]
        public string CountryName { get; set; }
      
    }
}
