using System.ComponentModel.DataAnnotations;

namespace Showcase_Contactpagina.Models
{
    public class Contactform
    {
        [Required(ErrorMessage = "Voornaam is verplicht")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Achternaam is verplicht")]
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "Ongeldig e-mailadres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefoonnummer is verplicht")]
        [Phone(ErrorMessage = "Ongeldig telefoonnummer")]
        public string Phone { get; set; }
    }
}
