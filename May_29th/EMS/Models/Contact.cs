using System.ComponentModel.DataAnnotations;


namespace EmployeeManagementSystem.Models
{
    public class Contact
    {

        public int Id { get; set; }
        [Display(Name ="Full Name")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Email Address is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone Number is Required")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Subject is Required")]
        [Display(Name = "Subject")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Message is Required")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}
