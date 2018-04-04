using System;
using System.Collections.Generic;
using System.Text;

namespace ESB_Classes.Commands.EmailService
{
    /// <summary>
    /// Send this command to send out a transactional email.
    /// 
    /// Transactional emails are 'one-time' emails with all the information
    /// required for that email embodied in the command (i.e. no need to fetch
    /// any information from the DB or a 3rd party).
    /// </summary>
    public class SendTransactionalEmail
    {
        public int ID { get; set; }

        /// <summary>
        /// The email address that the email should be sent to.
        /// </summary>
        public string ToEmail { get; set; }

        /// <summary>
        /// [Optional] The name of the person to whom the email is to be sent.
        /// </summary>
        public string ToName { get; set; }

        /// <summary>
        /// The subject of the email.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// The content of the email, encoded in HTML.
        /// </summary>
        public string BodyHTML { get; set; }

        /// <summary>
        /// The raw content of the email. This will not be rendered as HTML in the email client.
        /// </summary>
        public string BodyPlainText { get; set; }

        /// <summary>
        /// The source that is sending this email.
        /// </summary>
        public string FromEmail { get; set; }

        /// <summary>
        /// [Optional] The name of the source that is sending this email.
        /// </summary>
        public string FromName { get; set; }
    }
}
