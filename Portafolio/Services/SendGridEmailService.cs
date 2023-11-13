using Portafolio.Models;
using System.Diagnostics.Contracts;
using System.Net.Mail;

namespace Portafolio.Services
{
    public interface IEmailService
    {

    }
    public class SendGridEmailService: IEmailService
    {
        private readonly IConfiguration configuration;

        public SendGridEmailService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task Send(ContactDTO contact)
        {
            var email = configuration.GetValue<string>("SENDGRID_FROM");
            var name = configuration.GetValue<string>("SENDGRID_NAME");
            var Password = configuration.GetValue<string>("SENDGRID_PASSWORD");
            SmtpClient client = new SmtpClient("smtp.office365.com", 587);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;

            client.Credentials = new System.Net.NetworkCredential(email, Password);

            var from = email;
            var subject = $"El cliente {contact.Email} quiere contactarte ";
            var to = email;
            var mensajeTextoPlano = contact.Message;
            var contenidoHtml = @$"De: {contact.Name} - Email: {contact.Email} Mensaje: {contact.Message}";
            MailMessage message = new MailMessage(from, to, subject, contenidoHtml);
            client.Send(message);
        }
    }
}
