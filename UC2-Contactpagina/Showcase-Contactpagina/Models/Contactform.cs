using System.ComponentModel.DataAnnotations;

namespace Showcase_Contactpagina.Models
{
    public class Contactform
    {
        [Required(ErrorMessage = "Voornaam is verplicht")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Achternaam is verplicht")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "E-mail is verplicht")]
        [EmailAddress(ErrorMessage = "Ongeldig e-mailadres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefoonnummer is verplicht")]
        [Phone(ErrorMessage = "Ongeldig telefoonnummer")]
        public string Phone { get; set; }

        [StringLength(200, ErrorMessage = "Onderwerp mag niet langer zijn dan 200 karakters.")]
        public string Subject { get; set; }

        [StringLength(600, ErrorMessage = "Bericht mag niet langer zijn dan 600 karakters.")]
        public string Message { get; set; }

        public string? RecaptchaToken { get; set; }
    }
}
