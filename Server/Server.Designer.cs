namespace Server
{
    partial class Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.NgătKêtNôiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.KiêmTraKêtNôiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labTongKetNoi = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ListView = new System.Windows.Forms.ListView();
            this.lv_IPAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTrangThai = new System.Windows.Forms.RichTextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnCreaterServer = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ContextMenuStrip2.SuspendLayout();
            this.ContextMenuStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 3000;
            // 
            // NgătKêtNôiToolStripMenuItem
            // 
            this.NgătKêtNôiToolStripMenuItem.Name = "NgătKêtNôiToolStripMenuItem";
            this.NgătKêtNôiToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.NgătKêtNôiToolStripMenuItem.Text = "Ngắt kết nối";
            // 
            // ContextMenuStrip2
            // 
            this.ContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KiêmTraKêtNôiToolStripMenuItem,
            this.NgătKêtNôiToolStripMenuItem});
            this.ContextMenuStrip2.Name = "ContextMenuStrip2";
            this.ContextMenuStrip2.Size = new System.Drawing.Size(158, 48);
            // 
            // KiêmTraKêtNôiToolStripMenuItem
            // 
            this.KiêmTraKêtNôiToolStripMenuItem.Name = "KiêmTraKêtNôiToolStripMenuItem";
            this.KiêmTraKêtNôiToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.KiêmTraKêtNôiToolStripMenuItem.Text = "Kiểm tra kết nối";
            // 
            // NotifyIcon1
            // 
            this.NotifyIcon1.ContextMenuStrip = this.ContextMenuStrip1;
            this.NotifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon1.Icon")));
            this.NotifyIcon1.Text = "NotifyIcon1";
            this.NotifyIcon1.Visible = true;
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowFormToolStripMenuItem,
            this.ThoatToolStripMenuItem});
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(188, 48);
            // 
            // ShowFormToolStripMenuItem
            // 
            this.ShowFormToolStripMenuItem.Name = "ShowFormToolStripMenuItem";
            this.ShowFormToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ShowFormToolStripMenuItem.Text = "Hiện bảng điều khiển";
            // 
            // ThoatToolStripMenuItem
            // 
            this.ThoatToolStripMenuItem.Name = "ThoatToolStripMenuItem";
            this.ThoatToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ThoatToolStripMenuItem.Text = "Thoát ";
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "start-icon.png");
            this.ImageList1.Images.SetKeyName(1, "Pause.png");
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labTongKetNoi,
            this.ToolStripStatusLabel2});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 375);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(725, 22);
            this.StatusStrip1.TabIndex = 4;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // labTongKetNoi
            // 
            this.labTongKetNoi.Name = "labTongKetNoi";
            this.labTongKetNoi.Size = new System.Drawing.Size(97, 17);
            this.labTongKetNoi.Text = "Tổng số kết nối : ";
            // 
            // ToolStripStatusLabel2
            // 
            this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            this.ToolStripStatusLabel2.Size = new System.Drawing.Size(16, 17);
            this.ToolStripStatusLabel2.Text = "...";
            // 
            // ListView
            // 
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lv_IPAddress,
            this.lv_User});
            this.ListView.ContextMenuStrip = this.ContextMenuStrip2;
            this.ListView.FullRowSelect = true;
            this.ListView.GridLines = true;
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(8, 19);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(224, 287);
            this.ListView.TabIndex = 11;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            // 
            // lv_IPAddress
            // 
            this.lv_IPAddress.Text = "IPAddress";
            this.lv_IPAddress.Width = 120;
            // 
            // lv_User
            // 
            this.lv_User.Width = 100;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.button1);
            this.GroupBox2.Controls.Add(this.txtTrangThai);
            this.GroupBox2.Location = new System.Drawing.Point(12, 12);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(461, 263);
            this.GroupBox2.TabIndex = 10;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Nhật ký";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTrangThai.Location = new System.Drawing.Point(12, 19);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.ReadOnly = true;
            this.txtTrangThai.Size = new System.Drawing.Size(443, 238);
            this.txtTrangThai.TabIndex = 0;
            this.txtTrangThai.Text = "";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(12, 20);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(58, 13);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "Public IP : ";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.TextBox3);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.txtIP);
            this.GroupBox1.Controls.Add(this.btnCreaterServer);
            this.GroupBox1.Controls.Add(this.txtPort);
            this.GroupBox1.Location = new System.Drawing.Point(11, 281);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(462, 93);
            this.GroupBox1.TabIndex = 9;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Cài đặt";
            // 
            // TextBox3
            // 
            this.TextBox3.Enabled = false;
            this.TextBox3.Location = new System.Drawing.Point(76, 17);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.ReadOnly = true;
            this.TextBox3.Size = new System.Drawing.Size(151, 20);
            this.TextBox3.TabIndex = 6;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(15, 45);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(55, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Local IP : ";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(35, 71);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(35, 13);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Port : ";
            // 
            // txtIP
            // 
            this.txtIP.Enabled = false;
            this.txtIP.Location = new System.Drawing.Point(76, 42);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(151, 20);
            this.txtIP.TabIndex = 2;
            // 
            // btnCreaterServer
            // 
            this.btnCreaterServer.Location = new System.Drawing.Point(233, 14);
            this.btnCreaterServer.Name = "btnCreaterServer";
            this.btnCreaterServer.Size = new System.Drawing.Size(223, 73);
            this.btnCreaterServer.TabIndex = 0;
            this.btnCreaterServer.Text = "Bắt đầu";
            this.btnCreaterServer.UseVisualStyleBackColor = true;
            this.btnCreaterServer.Click += new System.EventHandler(this.btnCreaterServer_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(76, 68);
            this.txtPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.txtPort.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(63, 20);
            this.txtPort.TabIndex = 3;
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPort.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ListView);
            this.groupBox3.Location = new System.Drawing.Point(479, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 362);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách client";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 397);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.StatusStrip1);
            this.Name = "Server";
            this.Text = "Server";
            this.ContextMenuStrip2.ResumeLayout(false);
            this.ContextMenuStrip1.ResumeLayout(false);
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.ToolStripMenuItem NgătKêtNôiToolStripMenuItem;
        internal System.Windows.Forms.ContextMenuStrip ContextMenuStrip2;
        internal System.Windows.Forms.ToolStripMenuItem KiêmTraKêtNôiToolStripMenuItem;
        internal System.Windows.Forms.NotifyIcon NotifyIcon1;
        internal System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem ShowFormToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ThoatToolStripMenuItem;
        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel labTongKetNoi;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel2;
        internal System.Windows.Forms.ListView ListView;
        internal System.Windows.Forms.ColumnHeader lv_IPAddress;
        internal System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.RichTextBox txtTrangThai;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox TextBox3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtIP;
        internal System.Windows.Forms.Button btnCreaterServer;
        internal System.Windows.Forms.NumericUpDown txtPort;
        private System.Windows.Forms.ColumnHeader lv_User;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
    }
}

