using System.ComponentModel.DataAnnotations;

namespace Mvc_project.ViewModel
{
    public class LoginVM
    {
        [Required]
        [DataType(DataType.EmailAddress) ]
        public string UserEmail { get; set; }
        [Required]
        [DataType (DataType.Password)]
        public string PasswordHash { get; set; }
    }
}
