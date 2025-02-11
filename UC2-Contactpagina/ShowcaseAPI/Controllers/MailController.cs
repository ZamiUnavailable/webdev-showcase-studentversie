using Microsoft.AspNetCore.Mvc;
using ShowcaseAPI.Models;
using System.Net.Mail;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShowcaseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        // POST api/<MailController>
        [HttpPost]
        public ActionResult Post([Bind("FirstName, LastName, Email, Phone")] Contactform form)
        {
            //Op brightspace staan instructies over hoe je de mailfunctionaliteit werkend kunt maken:
            //Project Web Development > De showcase > Week 2: contactpagina (UC2) > Hoe verstuur je een mail vanuit je webapplicatie met Mailtrap?
           

            var client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("15055d950fda99", "841476198a9432"),
                EnableSsl = true
            };

            string test = $"Mail from: {form.FirstName} {form.LastName}, phone number: {form.Phone}";
            client.Send(form.Email, "zara.klaren@gmail.com", "Hello world", test);
            System.Console.WriteLine("Sent");


            return Ok();
        }
    }
}
