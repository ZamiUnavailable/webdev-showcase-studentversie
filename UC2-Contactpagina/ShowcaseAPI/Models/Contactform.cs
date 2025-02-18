using System.ComponentModel.DataAnnotations;

namespace ShowcaseAPI.Models
{
    public class Contactform
    {
        [Required]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "First name must be between 2 and 60 characters.")]
        public string FirstName {  get; set; }

        [Required]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Last name must be between 2 and 60 characters.")]
        public string LastName {  get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Ongeldig e-mailadres")]
        public string Email { get; set; }

        [Required]
        [Phone(ErrorMessage = "Ongeldig telefoonnummer")]
        public string Phone { get; set; }

        [StringLength(200, ErrorMessage = "Subject cannot exceed 200 characters.")]
        public string Subject { get; set; }

        [StringLength(600, ErrorMessage = "Message cannot exceed 600 characters.")]
        public string Message { get; set; }

    }
}
