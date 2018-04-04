using System;
using System.Collections.Generic;
using System.Text;

namespace ESB_Classes.Events.ReservationService
{
    class NoShowReservation
    {
        public int ID { get; set; }

        /// <summary>
        /// The Stay ID.
        /// </summary>
        public int ReservationID { get; set; }

        /// <summary>
        /// The date/time of cancellation.
        /// </summary>
        public DateTime NoShowDate { get; set; }

        /// <summary>
        /// Whether or not the user got a refund.
        /// </summary>
        public bool RefundIssued { get; set; }

        /// <summary>
        /// The device from which the no show happened e.g. Android, iPhone, Windows/Chrome, etc..
        /// 
        /// Used for statistics purposes (e.g. iPhone users tend not to show up to their reservations for
        /// cheap hotels more often than the more desparate Android users).
        /// </summary>
        public string Device { get; set; }
    }
}
