namespace ESB_UI.UserControls.Email
{
    partial class SendTransactionalEmail
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_ToEmail = new System.Windows.Forms.TextBox();
            this.tb_FromEmail = new System.Windows.Forms.TextBox();
            this.tb_ToName = new System.Windows.Forms.TextBox();
            this.tb_FromName = new System.Windows.Forms.TextBox();
            this.tb_Subject = new System.Windows.Forms.TextBox();
            this.tb_HTMLBody = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.cb_Crash = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "To Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "To Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Subject:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "HTML Body:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "From Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "From Name:";
            // 
            // tb_ToEmail
            // 
            this.tb_ToEmail.Location = new System.Drawing.Point(78, 7);
            this.tb_ToEmail.Name = "tb_ToEmail";
            this.tb_ToEmail.Size = new System.Drawing.Size(100, 23);
            this.tb_ToEmail.TabIndex = 0;
            // 
            // tb_FromEmail
            // 
            this.tb_FromEmail.Location = new System.Drawing.Point(258, 7);
            this.tb_FromEmail.Name = "tb_FromEmail";
            this.tb_FromEmail.Size = new System.Drawing.Size(100, 23);
            this.tb_FromEmail.TabIndex = 1;
            // 
            // tb_ToName
            // 
            this.tb_ToName.Location = new System.Drawing.Point(78, 34);
            this.tb_ToName.Name = "tb_ToName";
            this.tb_ToName.Size = new System.Drawing.Size(100, 23);
            this.tb_ToName.TabIndex = 2;
            // 
            // tb_FromName
            // 
            this.tb_FromName.Location = new System.Drawing.Point(258, 34);
            this.tb_FromName.Name = "tb_FromName";
            this.tb_FromName.Size = new System.Drawing.Size(100, 23);
            this.tb_FromName.TabIndex = 3;
            // 
            // tb_Subject
            // 
            this.tb_Subject.Location = new System.Drawing.Point(78, 62);
            this.tb_Subject.Name = "tb_Subject";
            this.tb_Subject.Size = new System.Drawing.Size(280, 23);
            this.tb_Subject.TabIndex = 4;
            // 
            // tb_HTMLBody
            // 
            this.tb_HTMLBody.Location = new System.Drawing.Point(78, 91);
            this.tb_HTMLBody.Multiline = true;
            this.tb_HTMLBody.Name = "tb_HTMLBody";
            this.tb_HTMLBody.Size = new System.Drawing.Size(280, 54);
            this.tb_HTMLBody.TabIndex = 5;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(283, 150);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 7;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // cb_Crash
            // 
            this.cb_Crash.AutoSize = true;
            this.cb_Crash.Location = new System.Drawing.Point(21, 153);
            this.cb_Crash.Name = "cb_Crash";
            this.cb_Crash.Size = new System.Drawing.Size(56, 19);
            this.cb_Crash.TabIndex = 6;
            this.cb_Crash.Text = "Crash";
            this.cb_Crash.UseVisualStyleBackColor = true;
            // 
            // SendTransactionalEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.cb_Crash);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.tb_FromEmail);
            this.Controls.Add(this.tb_FromName);
            this.Controls.Add(this.tb_HTMLBody);
            this.Controls.Add(this.tb_Subject);
            this.Controls.Add(this.tb_ToName);
            this.Controls.Add(this.tb_ToEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SendTransactionalEmail";
            this.Size = new System.Drawing.Size(373, 176);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_ToEmail;
        private System.Windows.Forms.TextBox tb_FromEmail;
        private System.Windows.Forms.TextBox tb_ToName;
        private System.Windows.Forms.TextBox tb_FromName;
        private System.Windows.Forms.TextBox tb_Subject;
        private System.Windows.Forms.TextBox tb_HTMLBody;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.CheckBox cb_Crash;
    }
}
