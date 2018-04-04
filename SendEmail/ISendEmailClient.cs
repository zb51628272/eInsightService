using System.Threading.Tasks;

namespace SendEmail
{
    enum SentStatus
    {
        Success,
        No_Recipients,
        Unknown_Failure,
        Internal_Server_Error,
        API_Limit_Exceeded,
        Thread_Aborted
    }

    interface ISendEmailClient
    {
        int GetAPIQuota();

        bool CanSendTransactionalEmail();

        bool CanSendMarketingEmail();

        Task<SentStatus> SendTransactionalEmail(EmailParcel parcel);

        Task<SentStatus> SendMarketingEmail(EmailParcel parcel);


    }
}
