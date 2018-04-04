using System;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace SendEmail
{
    class SendGridEmailClient : ISendEmailClient
    {
        private readonly string API_KEY = "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";

        public bool CanSendMarketingEmail()
        {
            return true;
        }

        public bool CanSendTransactionalEmail()
        {
            return true;
        }

        public int GetAPIQuota()
        {
            return -1;
        }

        public Task<SentStatus> SendMarketingEmail(EmailParcel parcel)
        {
            throw new NotImplementedException();
        }

        public async Task<SentStatus> SendTransactionalEmail(EmailParcel parcel)
        {
            if (parcel.Recipients == null || parcel.Recipients.Count <= 0)
                return SentStatus.No_Recipients;

            var client = new SendGridClient(API_KEY);

            var recipient = parcel.Recipients[0];

            var from = new EmailAddress(parcel.FromEmail, parcel.FromName);
            var to = new EmailAddress(recipient.ToEmail, recipient.ToName);

            var msg = MailHelper.CreateSingleEmail(from, to, parcel.Subject, parcel.PlainTextContent, parcel.HTMLContent);

            var result = await client.SendEmailAsync(msg);

            if (result.StatusCode == System.Net.HttpStatusCode.OK)
                return SentStatus.Success;
            else
                return SentStatus.Unknown_Failure;
        }
    }
}
