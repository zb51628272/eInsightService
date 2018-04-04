using System.Collections.Generic;

namespace SendEmail
{
    public class EmailParcel : EmailTemplate
    {
        public List<EmailRecipient> Recipients { get; set; }
        
        public EmailParcel() {}

        public EmailParcel(string toEmail, string subject, string htmlContent, string fromEmail)
        {
            Subject = subject;
            HTMLContent = htmlContent;
            FromEmail = fromEmail;

            Recipients = new List<EmailRecipient>
            {
                new EmailRecipient { ToEmail = toEmail, ToName = null }
            };
        }
    }
}
