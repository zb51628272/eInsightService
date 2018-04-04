namespace ESB_UI
{
    partial class ESB_UI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_Reservation = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_ReservationRequest = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ResrvServiceStatus = new System.Windows.Forms.Label();
            this.btn_ResrvStartService = new System.Windows.Forms.Button();
            this.btn_ResrvCrashService = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnl_Email = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_EmailRequest = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_EmailServiceStatus = new System.Windows.Forms.Label();
            this.btn_EmailStartService = new System.Windows.Forms.Button();
            this.btn_EmailCrashService = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tb_ErrorDesc = new System.Windows.Forms.TextBox();
            this.lb_Error = new System.Windows.Forms.ListBox();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesTimer = new System.Windows.Forms.Timer(this.components);
            this.errorTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(536, 251);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(528, 223);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reservation Service";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pnl_Reservation);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(148, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 217);
            this.panel2.TabIndex = 4;
            // 
            // pnl_Reservation
            // 
            this.pnl_Reservation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Reservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Reservation.Location = new System.Drawing.Point(0, 32);
            this.pnl_Reservation.Name = "pnl_Reservation";
            this.pnl_Reservation.Size = new System.Drawing.Size(375, 183);
            this.pnl_Reservation.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cb_ReservationRequest);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(375, 32);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select Request:";
            // 
            // cb_ReservationRequest
            // 
            this.cb_ReservationRequest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ReservationRequest.FormattingEnabled = true;
            this.cb_ReservationRequest.Items.AddRange(new object[] {
            "Cancel Reservation"});
            this.cb_ReservationRequest.Location = new System.Drawing.Point(94, 6);
            this.cb_ReservationRequest.Name = "cb_ReservationRequest";
            this.cb_ReservationRequest.Size = new System.Drawing.Size(162, 23);
            this.cb_ReservationRequest.TabIndex = 4;
            this.cb_ReservationRequest.SelectedIndexChanged += new System.EventHandler(this.cb_ReservationRequest_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_ResrvServiceStatus);
            this.panel1.Controls.Add(this.btn_ResrvStartService);
            this.panel1.Controls.Add(this.btn_ResrvCrashService);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 217);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            // 
            // lbl_ResrvServiceStatus
            // 
            this.lbl_ResrvServiceStatus.AutoSize = true;
            this.lbl_ResrvServiceStatus.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_ResrvServiceStatus.Location = new System.Drawing.Point(46, 9);
            this.lbl_ResrvServiceStatus.Name = "lbl_ResrvServiceStatus";
            this.lbl_ResrvServiceStatus.Size = new System.Drawing.Size(42, 15);
            this.lbl_ResrvServiceStatus.TabIndex = 0;
            this.lbl_ResrvServiceStatus.Text = "Online";
            // 
            // btn_ResrvStartService
            // 
            this.btn_ResrvStartService.Location = new System.Drawing.Point(8, 29);
            this.btn_ResrvStartService.Name = "btn_ResrvStartService";
            this.btn_ResrvStartService.Size = new System.Drawing.Size(121, 23);
            this.btn_ResrvStartService.TabIndex = 1;
            this.btn_ResrvStartService.Text = "Stop Service";
            this.btn_ResrvStartService.UseVisualStyleBackColor = true;
            this.btn_ResrvStartService.Click += new System.EventHandler(this.btn_ResrvStartService_Click);
            // 
            // btn_ResrvCrashService
            // 
            this.btn_ResrvCrashService.Location = new System.Drawing.Point(8, 58);
            this.btn_ResrvCrashService.Name = "btn_ResrvCrashService";
            this.btn_ResrvCrashService.Size = new System.Drawing.Size(121, 23);
            this.btn_ResrvCrashService.TabIndex = 2;
            this.btn_ResrvCrashService.Text = "Crash Service";
            this.btn_ResrvCrashService.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(528, 223);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Email Service";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pnl_Email);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(148, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(377, 217);
            this.panel4.TabIndex = 7;
            // 
            // pnl_Email
            // 
            this.pnl_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Email.Location = new System.Drawing.Point(0, 32);
            this.pnl_Email.Name = "pnl_Email";
            this.pnl_Email.Size = new System.Drawing.Size(375, 183);
            this.pnl_Email.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.cb_EmailRequest);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(375, 32);
            this.panel7.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Select Request:";
            // 
            // cb_EmailRequest
            // 
            this.cb_EmailRequest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_EmailRequest.FormattingEnabled = true;
            this.cb_EmailRequest.Items.AddRange(new object[] {
            "Send Transactional Email"});
            this.cb_EmailRequest.Location = new System.Drawing.Point(94, 6);
            this.cb_EmailRequest.Name = "cb_EmailRequest";
            this.cb_EmailRequest.Size = new System.Drawing.Size(162, 23);
            this.cb_EmailRequest.TabIndex = 4;
            this.cb_EmailRequest.SelectedIndexChanged += new System.EventHandler(this.cb_EmailRequest_SelectedIndexChanged);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.lbl_EmailServiceStatus);
            this.panel6.Controls.Add(this.btn_EmailStartService);
            this.panel6.Controls.Add(this.btn_EmailCrashService);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(145, 217);
            this.panel6.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Status:";
            // 
            // lbl_EmailServiceStatus
            // 
            this.lbl_EmailServiceStatus.AutoSize = true;
            this.lbl_EmailServiceStatus.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_EmailServiceStatus.Location = new System.Drawing.Point(46, 9);
            this.lbl_EmailServiceStatus.Name = "lbl_EmailServiceStatus";
            this.lbl_EmailServiceStatus.Size = new System.Drawing.Size(42, 15);
            this.lbl_EmailServiceStatus.TabIndex = 0;
            this.lbl_EmailServiceStatus.Text = "Online";
            // 
            // btn_EmailStartService
            // 
            this.btn_EmailStartService.Location = new System.Drawing.Point(8, 29);
            this.btn_EmailStartService.Name = "btn_EmailStartService";
            this.btn_EmailStartService.Size = new System.Drawing.Size(121, 23);
            this.btn_EmailStartService.TabIndex = 1;
            this.btn_EmailStartService.Text = "Stop Service";
            this.btn_EmailStartService.UseVisualStyleBackColor = true;
            this.btn_EmailStartService.Click += new System.EventHandler(this.btn_EmailStartService_Click);
            // 
            // btn_EmailCrashService
            // 
            this.btn_EmailCrashService.Location = new System.Drawing.Point(8, 58);
            this.btn_EmailCrashService.Name = "btn_EmailCrashService";
            this.btn_EmailCrashService.Size = new System.Drawing.Size(121, 23);
            this.btn_EmailCrashService.TabIndex = 2;
            this.btn_EmailCrashService.Text = "Crash Service";
            this.btn_EmailCrashService.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tb_ErrorDesc);
            this.tabPage3.Controls.Add(this.lb_Error);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(528, 224);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Errors";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tb_ErrorDesc
            // 
            this.tb_ErrorDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_ErrorDesc.Location = new System.Drawing.Point(202, 3);
            this.tb_ErrorDesc.Multiline = true;
            this.tb_ErrorDesc.Name = "tb_ErrorDesc";
            this.tb_ErrorDesc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_ErrorDesc.Size = new System.Drawing.Size(323, 218);
            this.tb_ErrorDesc.TabIndex = 1;
            // 
            // lb_Error
            // 
            this.lb_Error.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_Error.FormattingEnabled = true;
            this.lb_Error.ItemHeight = 15;
            this.lb_Error.Location = new System.Drawing.Point(3, 3);
            this.lb_Error.Name = "lb_Error";
            this.lb_Error.Size = new System.Drawing.Size(199, 218);
            this.lb_Error.TabIndex = 0;
            this.lb_Error.SelectedIndexChanged += new System.EventHandler(this.lb_Error_SelectedIndexChanged);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(536, 25);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // servicesTimer
            // 
            this.servicesTimer.Enabled = true;
            this.servicesTimer.Interval = 1000;
            this.servicesTimer.Tick += new System.EventHandler(this.servicesTimer_Tick);
            // 
            // errorTimer
            // 
            this.errorTimer.Enabled = true;
            this.errorTimer.Interval = 1000;
            this.errorTimer.Tick += new System.EventHandler(this.errorTimer_Tick);
            // 
            // ESB_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 276);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "ESB_UI";
            this.Text = "ESB UI";
            this.Load += new System.EventHandler(this.ESB_UI_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ResrvCrashService;
        private System.Windows.Forms.Button btn_ResrvStartService;
        private System.Windows.Forms.Label lbl_ResrvServiceStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_ReservationRequest;
        private System.Windows.Forms.Panel pnl_Reservation;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_EmailServiceStatus;
        private System.Windows.Forms.Button btn_EmailStartService;
        private System.Windows.Forms.Button btn_EmailCrashService;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnl_Email;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_EmailRequest;
        private System.Windows.Forms.Timer servicesTimer;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tb_ErrorDesc;
        private System.Windows.Forms.ListBox lb_Error;
        private System.Windows.Forms.Timer errorTimer;
    }
}

