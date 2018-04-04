using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rebus.Activation;

namespace ESB_UI.UserControls.Reservation
{
    public partial class CancelReservation : UserControl
    {
        BuiltinHandlerActivator Adapter;
        public CancelReservation(BuiltinHandlerActivator adapter)
        {
            InitializeComponent();

            Adapter = adapter;

            cb_Refund.SelectedIndex = 0;
            cb_Approved.SelectedIndex = 0;
        }

        private async void btn_Submit_Click(object sender, EventArgs e)
        {
            int resrvID;
            if (!int.TryParse(tb_ReservationID.Text, out resrvID))
            {
                MessageBox.Show("Invalid reservation ID.");
                return;
            }

            await Adapter.Bus.Advanced.Routing.Send(
                "CancelReservationQueue",
            //await Adapter.Bus.Send(
                new ESB_Classes.Events.ReservationService.CancelReservationExtended
                {
                    ID = 865463,
                    ReservationID = resrvID,
                    CancellationDate = dtp_Date.Value,
                    Reason = tb_Reason.Text,
                    Approved = cb_Approved.SelectedIndex == 0,
                    RefundIssued = cb_Refund.SelectedIndex == 0,
                    Device = tb_Device.Text,
                    FailMessage = cb_Crash.Checked,
                    IsExtended = true
                }
            );
        }
    }
}
