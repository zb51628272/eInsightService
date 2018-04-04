
namespace EmailService.Email_Classes
{
    public class EmailTemplate
    {
        public string HTMLContent { get; set; }
        public string PlainTextContent { get; set; }
        public string Subject { get; set; }

        public string FromEmail { get; set; }
        public string FromName { get; set; }
    }
}
