namespace ESB_UI.UserControls.Reservation
{
    partial class CancelReservation
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ReservationID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Reason = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Device = new System.Windows.Forms.TextBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.cb_Approved = new System.Windows.Forms.ComboBox();
            this.cb_Refund = new System.Windows.Forms.ComboBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.cb_Crash = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation ID:";
            // 
            // tb_ReservationID
            // 
            this.tb_ReservationID.Location = new System.Drawing.Point(112, 8);
            this.tb_ReservationID.Name = "tb_ReservationID";
            this.tb_ReservationID.Size = new System.Drawing.Size(140, 23);
            this.tb_ReservationID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Reason:";
            // 
            // tb_Reason
            // 
            this.tb_Reason.Location = new System.Drawing.Point(112, 62);
            this.tb_Reason.Name = "tb_Reason";
            this.tb_Reason.Size = new System.Drawing.Size(140, 23);
            this.tb_Reason.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Approved:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Refund Issued:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Device:";
            // 
            // tb_Device
            // 
            this.tb_Device.Location = new System.Drawing.Point(112, 143);
            this.tb_Device.Name = "tb_Device";
            this.tb_Device.Size = new System.Drawing.Size(140, 23);
            this.tb_Device.TabIndex = 5;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Location = new System.Drawing.Point(112, 35);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(140, 23);
            this.dtp_Date.TabIndex = 1;
            // 
            // cb_Approved
            // 
            this.cb_Approved.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Approved.FormattingEnabled = true;
            this.cb_Approved.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cb_Approved.Location = new System.Drawing.Point(112, 89);
            this.cb_Approved.Name = "cb_Approved";
            this.cb_Approved.Size = new System.Drawing.Size(140, 23);
            this.cb_Approved.TabIndex = 3;
            // 
            // cb_Refund
            // 
            this.cb_Refund.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Refund.FormattingEnabled = true;
            this.cb_Refund.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cb_Refund.Location = new System.Drawing.Point(112, 116);
            this.cb_Refund.Name = "cb_Refund";
            this.cb_Refund.Size = new System.Drawing.Size(140, 23);
            this.cb_Refund.TabIndex = 4;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(258, 142);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(79, 23);
            this.btn_Submit.TabIndex = 7;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // cb_Crash
            // 
            this.cb_Crash.AutoSize = true;
            this.cb_Crash.Location = new System.Drawing.Point(258, 120);
            this.cb_Crash.Name = "cb_Crash";
            this.cb_Crash.Size = new System.Drawing.Size(56, 19);
            this.cb_Crash.TabIndex = 6;
            this.cb_Crash.Text = "Crash";
            this.cb_Crash.UseVisualStyleBackColor = true;
            // 
            // CancelReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.cb_Crash);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.cb_Refund);
            this.Controls.Add(this.cb_Approved);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.tb_Device);
            this.Controls.Add(this.tb_Reason);
            this.Controls.Add(this.tb_ReservationID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CancelReservation";
            this.Size = new System.Drawing.Size(354, 174);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ReservationID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Reason;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Device;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.ComboBox cb_Approved;
        private System.Windows.Forms.ComboBox cb_Refund;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.CheckBox cb_Crash;
    }
}
