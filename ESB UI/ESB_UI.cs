using ESB_Classes.Events;
using ESB_UI.UserControls.Email;
using ESB_UI.UserControls.Reservation;
using Rebus.Activation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESB_UI
{
    public partial class ESB_UI : Form
    {
        private CancelReservation cancelReservation;
        private SendTransactionalEmail sendTransactionalEmail;
        private BuiltinHandlerActivator Adapter = null;

        private ServiceController reservationService = new ServiceController("ReservationService");
        private ServiceController emailService = new ServiceController("EmailService");

        public List<ErrorThrown> Errors = new List<ErrorThrown>();

        public ESB_UI(BuiltinHandlerActivator adapter)
        {
            InitializeComponent();

            Adapter = adapter;

            cancelReservation = new CancelReservation(Adapter);
            pnl_Reservation.Controls.Add(cancelReservation);

            foreach (Control c in pnl_Reservation.Controls)
            {
                c.Visible = false;
                c.Dock = DockStyle.Fill;
            }

            sendTransactionalEmail = new SendTransactionalEmail(Adapter);
            pnl_Email.Controls.Add(sendTransactionalEmail);

            foreach (Control c in pnl_Email.Controls)
            {
                c.Visible = false;
                c.Dock = DockStyle.Fill;
            }
        }

        private void cb_ReservationRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cb_ReservationRequest.SelectedItem as string;

            if (selectedItem == "Cancel Reservation")
            {
                cancelReservation.Visible = true;
            }
        }

        private void ESB_UI_Load(object sender, EventArgs e)
        {
            UpdateServices();
        }

        private void UpdateServices()
        {
            // Reservation Service
            reservationService.Refresh();

            if (reservationService.Status == ServiceControllerStatus.Running)
            {
                lbl_ResrvServiceStatus.Text = "Online";
                lbl_ResrvServiceStatus.ForeColor = Color.DarkGreen;

                btn_ResrvStartService.Text = "Stop Service";
                btn_ResrvStartService.Enabled = true;

                EnableReservationControls(true);
            }
            else if (reservationService.Status == ServiceControllerStatus.Stopped)
            {
                lbl_ResrvServiceStatus.Text = "Offline";
                lbl_ResrvServiceStatus.ForeColor = Color.DarkRed;

                btn_ResrvStartService.Text = "Start Service";
                btn_ResrvStartService.Enabled = true;

                EnableReservationControls(false);
            }
            else
            {
                lbl_ResrvServiceStatus.Text = "Loading...";
                lbl_ResrvServiceStatus.ForeColor = Color.DarkOrange;

                btn_ResrvStartService.Enabled = false;
            }


            // Email Service
            emailService.Refresh();

            if (emailService.Status == ServiceControllerStatus.Running)
            {
                lbl_EmailServiceStatus.Text = "Online";
                lbl_EmailServiceStatus.ForeColor = Color.DarkGreen;

                btn_EmailStartService.Text = "Stop Service";
                btn_EmailStartService.Enabled = true;

                EnableEmailControls(true);
            }
            else if (emailService.Status == ServiceControllerStatus.Stopped)
            {
                lbl_EmailServiceStatus.Text = "Offline";
                lbl_EmailServiceStatus.ForeColor = Color.DarkRed;

                btn_EmailStartService.Text = "Start Service";
                btn_EmailStartService.Enabled = true;

                EnableEmailControls(false);
            }
            else
            {
                lbl_EmailServiceStatus.Text = "Loading...";
                lbl_EmailServiceStatus.ForeColor = Color.DarkOrange;

                btn_EmailStartService.Enabled = false;
            }
        }

        private void EnableEmailControls(bool enabled)
        {
            btn_EmailCrashService.Enabled = enabled;
            //cb_EmailRequest.Enabled = enabled;

            //pnl_Email.Enabled = enabled;
        }

        private void EnableReservationControls(bool enabled)
        {
            btn_ResrvCrashService.Enabled = enabled;
            //cb_ReservationRequest.Enabled = enabled;

            //pnl_Reservation.Enabled = enabled;
        }

        private void servicesTimer_Tick(object sender, EventArgs e)
        {
            UpdateServices();
        }

        private void btn_ResrvStartService_Click(object sender, EventArgs e)
        {
            try
            {
                reservationService.Refresh();
                btn_ResrvStartService.Enabled = false;

                if (reservationService.Status == ServiceControllerStatus.Stopped)
                {
                    reservationService.Start();
                }
                else if (reservationService.Status == ServiceControllerStatus.Running)
                {
                    EnableReservationControls(false);

                    reservationService.Stop();
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("You need admin priviledges or the service isn't installed. To install the service, from a command line execute the service with arguments '--register-service'.");
            }
        }

        private void btn_EmailStartService_Click(object sender, EventArgs e)
        {
            try
            {
                emailService.Refresh();
                btn_EmailStartService.Enabled = false;

                if (emailService.Status == ServiceControllerStatus.Stopped)
                {
                    emailService.Start();
                }
                else if (emailService.Status == ServiceControllerStatus.Running)
                {
                    EnableEmailControls(false);

                    emailService.Stop();
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("You need admin priviledges or the service isn't installed. To install the service, from a command line execute the service with arguments '--register-service'.");
            }
        }

        private void errorTimer_Tick(object sender, EventArgs e)
        {
            if (lb_Error.Items.Count != Errors.Count)
            {
                lb_Error.Items.Clear();
                
                foreach (var err in Errors)
                {
                    lb_Error.Items.Add(err.MessageName + " - " + err.Timestamp.ToString());
                }
            }
        }

        private void lb_Error_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_Error.SelectedIndex == -1)
            {
                tb_ErrorDesc.Text = "";
                return;
            }

            tb_ErrorDesc.Text = Errors[lb_Error.SelectedIndex].ErrorDesc;
        }

        private void cb_EmailRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cb_EmailRequest.SelectedItem as string;

            if (selectedItem == "Send Transactional Email")
            {
                sendTransactionalEmail.Visible = true;
            }
        }
    }
}
