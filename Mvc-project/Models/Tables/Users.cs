using System.ComponentModel.DataAnnotations;

namespace Mvc_project.Models.Tables
{
    public class Users : BaseModel
    {
        [Required(ErrorMessage = "User name is required.")]
        public string UserName { get; set; }
        [Required]
        public string UserEmail { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        public string UserRole { get; set; } = string.Empty;
    }
}
