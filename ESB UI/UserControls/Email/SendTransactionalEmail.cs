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

namespace ESB_UI.UserControls.Email
{
    public partial class SendTransactionalEmail : UserControl
    {
        BuiltinHandlerActivator Adapter;
        public SendTransactionalEmail(BuiltinHandlerActivator adapter)
        {
            InitializeComponent();

            this.Adapter = adapter;
        }

        private async void btn_Submit_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(tb_FromEmail.Text) ||
            //    string.IsNullOrWhiteSpace(tb_ToEmail.Text) ||
            //    string.IsNullOrWhiteSpace(tb_Subject.Text) ||
            //    string.IsNullOrWhiteSpace(tb_HTMLBody.Text) ||
            //    string.IsNullOrWhiteSpace(tb_FromName.Text) ||
            //    string.IsNullOrWhiteSpace(tb_ToName.Text))
            //{
            //    MessageBox.Show("All fields are required.");
            //    return;
            //}

            await Adapter.Bus.Advanced.Routing.Send(
                "TransactionalEmailQueue",
            //await Adapter.Bus.Send(
                new ESB_Classes.Commands.EmailService.SendTransactionalEmail
                {
                    FromEmail = "wenqq2_flydog16@163.com",
                    Subject = "mike测试邮件",
                    ToEmail = "wenqq2_flydog16@163.com",
                    BodyHTML = "mike测试邮件",

                    FromName = string.IsNullOrWhiteSpace(tb_FromName.Text) ? null : tb_FromName.Text,
                    ToName = string.IsNullOrWhiteSpace(tb_ToName.Text) ? null : tb_ToName.Text,
                    BodyPlainText = null,
                    ID = 3185312,

                    FailMessage = cb_Crash.Checked
                }
            );
        }
    }
}
