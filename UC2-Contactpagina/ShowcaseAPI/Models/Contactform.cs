using System.ComponentModel.DataAnnotations;

namespace ShowcaseAPI.Models
{
    public class Contactform
    {
        [Required(ErrorMessage = "Voornaam is verplicht")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Voornaam moet tussen de 2 en 60 karakters zijn.")]

        public string FirstName { get; set; }

        [Required(ErrorMessage = "Achternaam is verplicht")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Achternaam moet tussen de 2 en 60 karakters zijn.")]

        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "Ongeldig e-mailadres")]
        [StringLength(80, ErrorMessage = "Email mag niet lanfer zijn dan 60 karakters.")]

        public string Email { get; set; }

        [Required(ErrorMessage = "Telefoonnummer is verplicht")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Telefoonnummer moet tussen de 8 en 20 karakters zijn.")]
        [Phone(ErrorMessage = "Ongeldig telefoonnummer")]
        public string Phone { get; set; }

        [StringLength(200, ErrorMessage = "Onderwerp mag niet langer zijn dan 200 karakters.")]
        public string Subject { get; set; }

        [StringLength(600, ErrorMessage = "Bericht mag niet langer zijn dan 600 karakters.")]
        public string Message { get; set; }


    }
}
