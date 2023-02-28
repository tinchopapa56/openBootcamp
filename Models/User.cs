using System.ComponentModel.DataAnnotations;

namespace openBootcamp.Models
{
    public class User : BaseEntity
    {
        [Required, StringLength(25)]
        public string Name { get; set; }
        [Required, StringLength(30)]
        public string LastName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
