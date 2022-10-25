using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnSOLIDPrinciples
{
    public class UserService
    {
        EmailService _emailService;
       
        public UserService(EmailService aEmailService)
        {
            _emailService = aEmailService;
           
        }
        public void Register(string email, string password)
        {
            if (!_emailService.ValidateEmail(email))
                throw new ValidationException("Email is not an email");
         
          
            _emailService.SendEmail(new MailMessage("myname@mydomain.com", email) { Subject = "Hi. How are you!" });

        }
    }
    public class EmailService
    {
        SmtpClient _smtpClient;
        public EmailService(SmtpClient aSmtpClient)
        {
            _smtpClient = aSmtpClient;
        }
        public bool  ValidateEmail(string email)
        {
            return email.Contains("@");
        }
        public void SendEmail(MailMessage message)
        {
           _smtpClient.Send(message);
        }

    }

    internal class SRP
    {
        //Implement sample code here to demonstrate SRP.
    }
}
