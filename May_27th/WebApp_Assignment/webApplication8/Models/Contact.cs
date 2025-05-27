using System.ComponentModel.DataAnnotations;

namespace WebApplication8.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; } 
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage ="Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Message is required")]
        public string Message { get; set; }

    }
}
