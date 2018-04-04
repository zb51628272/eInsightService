using System;
using System.Collections.Generic;
using System.Text;

namespace ESB_Classes.Events.ReservationService
{
    public class CancelReservation
    {
        public int ID { get; set; }

        /// <summary>
        /// The Stay ID.
        /// </summary>
        public int ReservationID { get; set; }

        /// <summary>
        /// The date/time of cancellation.
        /// </summary>
        public DateTime CancellationDate { get; set; }

        /// <summary>
        /// An explanation of why the user cancelled.
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Whether or not the cancellation was approved or rejected.
        /// </summary>
        public bool Approved { get; set; }

        /// <summary>
        /// Whether or not the user got a refund.
        /// </summary>
        public bool RefundIssued { get; set; }

        /// <summary>
        /// The device from which the cancellation happened e.g. Android, iPhone, Windows/Chrome, etc..
        /// 
        /// Used for statistics purposes (e.g. iPhone users tend to cancel their reservations for
        /// cheap hotels more often than the poorer Android users).
        /// </summary>
        public string Device { get; set; }
    }
}
