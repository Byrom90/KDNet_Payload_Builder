
namespace KDNet_Payload_Builder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_create_binary = new System.Windows.Forms.Button();
            this.btn_grab_ips = new System.Windows.Forms.Button();
            this.chkbox_manual_ip = new System.Windows.Forms.CheckBox();
            this.combo_ipaddr = new System.Windows.Forms.ComboBox();
            this.tbox_ipaddr = new System.Windows.Forms.TextBox();
            this.lbl_IP = new System.Windows.Forms.Label();
            this.lbl_macaddr = new System.Windows.Forms.Label();
            this.btn_regenmac = new System.Windows.Forms.Button();
            this.lbl_head_IP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_port = new System.Windows.Forms.ComboBox();
            this.chkbox_custom_port = new System.Windows.Forms.CheckBox();
            this.lbl_port = new System.Windows.Forms.Label();
            this.btn_help_ip = new System.Windows.Forms.Button();
            this.btn_help_create_bin = new System.Windows.Forms.Button();
            this.btn_help_port = new System.Windows.Forms.Button();
            this.btn_help_mac = new System.Windows.Forms.Button();
            this.numud_port = new System.Windows.Forms.NumericUpDown();
            this.btn_help_create_bat = new System.Windows.Forms.Button();
            this.btn_create_bat = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numud_port)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_create_binary
            // 
            this.btn_create_binary.Location = new System.Drawing.Point(16, 178);
            this.btn_create_binary.Name = "btn_create_binary";
            this.btn_create_binary.Size = new System.Drawing.Size(293, 38);
            this.btn_create_binary.TabIndex = 0;
            this.btn_create_binary.Text = "Create Binary";
            this.btn_create_binary.UseVisualStyleBackColor = true;
            this.btn_create_binary.Click += new System.EventHandler(this.btn_create_binary_Click);
            // 
            // btn_grab_ips
            // 
            this.btn_grab_ips.Location = new System.Drawing.Point(67, 40);
            this.btn_grab_ips.Name = "btn_grab_ips";
            this.btn_grab_ips.Size = new System.Drawing.Size(134, 23);
            this.btn_grab_ips.TabIndex = 1;
            this.btn_grab_ips.Text = "Refresh local IPs";
            this.btn_grab_ips.UseVisualStyleBackColor = true;
            this.btn_grab_ips.Click += new System.EventHandler(this.btn_grab_ips_Click);
            // 
            // chkbox_manual_ip
            // 
            this.chkbox_manual_ip.AutoSize = true;
            this.chkbox_manual_ip.Location = new System.Drawing.Point(207, 40);
            this.chkbox_manual_ip.Name = "chkbox_manual_ip";
            this.chkbox_manual_ip.Size = new System.Drawing.Size(109, 19);
            this.chkbox_manual_ip.TabIndex = 2;
            this.chkbox_manual_ip.Text = "Manual IP entry";
            this.chkbox_manual_ip.UseVisualStyleBackColor = true;
            this.chkbox_manual_ip.CheckedChanged += new System.EventHandler(this.cbox_manual_ip_CheckedChanged);
            // 
            // combo_ipaddr
            // 
            this.combo_ipaddr.FormattingEnabled = true;
            this.combo_ipaddr.Location = new System.Drawing.Point(67, 11);
            this.combo_ipaddr.Name = "combo_ipaddr";
            this.combo_ipaddr.Size = new System.Drawing.Size(134, 23);
            this.combo_ipaddr.TabIndex = 3;
            this.combo_ipaddr.TextChanged += new System.EventHandler(this.IP_EditOptions_TextChanged);
            // 
            // tbox_ipaddr
            // 
            this.tbox_ipaddr.Enabled = false;
            this.tbox_ipaddr.Location = new System.Drawing.Point(207, 11);
            this.tbox_ipaddr.MaxLength = 15;
            this.tbox_ipaddr.Name = "tbox_ipaddr";
            this.tbox_ipaddr.Size = new System.Drawing.Size(134, 23);
            this.tbox_ipaddr.TabIndex = 4;
            this.tbox_ipaddr.TextChanged += new System.EventHandler(this.IP_EditOptions_TextChanged);
            // 
            // lbl_IP
            // 
            this.lbl_IP.AutoSize = true;
            this.lbl_IP.Location = new System.Drawing.Point(17, 129);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(112, 15);
            this.lbl_IP.TabIndex = 5;
            this.lbl_IP.Text = "Debug PC IP: 0.0.0.0";
            // 
            // lbl_macaddr
            // 
            this.lbl_macaddr.AutoSize = true;
            this.lbl_macaddr.Location = new System.Drawing.Point(17, 153);
            this.lbl_macaddr.Name = "lbl_macaddr";
            this.lbl_macaddr.Size = new System.Drawing.Size(208, 15);
            this.lbl_macaddr.TabIndex = 6;
            this.lbl_macaddr.Text = "Console Dbg MAC: 00-22-48-xx-xx-xx";
            // 
            // btn_regenmac
            // 
            this.btn_regenmac.Location = new System.Drawing.Point(231, 149);
            this.btn_regenmac.Name = "btn_regenmac";
            this.btn_regenmac.Size = new System.Drawing.Size(78, 23);
            this.btn_regenmac.TabIndex = 7;
            this.btn_regenmac.Text = "Regenerate";
            this.btn_regenmac.UseVisualStyleBackColor = true;
            this.btn_regenmac.Click += new System.EventHandler(this.btn_regenmac_Click);
            // 
            // lbl_head_IP
            // 
            this.lbl_head_IP.AutoSize = true;
            this.lbl_head_IP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_head_IP.Location = new System.Drawing.Point(13, 11);
            this.lbl_head_IP.Name = "lbl_head_IP";
            this.lbl_head_IP.Size = new System.Drawing.Size(48, 19);
            this.lbl_head_IP.TabIndex = 8;
            this.lbl_head_IP.Text = "PC IP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Port:";
            // 
            // combo_port
            // 
            this.combo_port.FormattingEnabled = true;
            this.combo_port.Location = new System.Drawing.Point(67, 75);
            this.combo_port.Name = "combo_port";
            this.combo_port.Size = new System.Drawing.Size(134, 23);
            this.combo_port.TabIndex = 12;
            this.combo_port.TextChanged += new System.EventHandler(this.Port_EditOptions_TextChanged);
            // 
            // chkbox_custom_port
            // 
            this.chkbox_custom_port.AutoSize = true;
            this.chkbox_custom_port.Location = new System.Drawing.Point(207, 104);
            this.chkbox_custom_port.Name = "chkbox_custom_port";
            this.chkbox_custom_port.Size = new System.Drawing.Size(93, 19);
            this.chkbox_custom_port.TabIndex = 11;
            this.chkbox_custom_port.Text = "Custom port";
            this.chkbox_custom_port.UseVisualStyleBackColor = true;
            this.chkbox_custom_port.CheckedChanged += new System.EventHandler(this.chkbox_custom_port_CheckedChanged);
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(169, 129);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(32, 15);
            this.lbl_port.TabIndex = 14;
            this.lbl_port.Text = "Port:";
            // 
            // btn_help_ip
            // 
            this.btn_help_ip.Location = new System.Drawing.Point(315, 37);
            this.btn_help_ip.Name = "btn_help_ip";
            this.btn_help_ip.Size = new System.Drawing.Size(26, 23);
            this.btn_help_ip.TabIndex = 15;
            this.btn_help_ip.Text = "?";
            this.btn_help_ip.UseVisualStyleBackColor = true;
            this.btn_help_ip.Click += new System.EventHandler(this.btn_help_ip_Click);
            // 
            // btn_help_create_bin
            // 
            this.btn_help_create_bin.Location = new System.Drawing.Point(315, 186);
            this.btn_help_create_bin.Name = "btn_help_create_bin";
            this.btn_help_create_bin.Size = new System.Drawing.Size(26, 23);
            this.btn_help_create_bin.TabIndex = 16;
            this.btn_help_create_bin.Text = "?";
            this.btn_help_create_bin.UseVisualStyleBackColor = true;
            this.btn_help_create_bin.Click += new System.EventHandler(this.btn_help_create_bin_Click);
            // 
            // btn_help_port
            // 
            this.btn_help_port.Location = new System.Drawing.Point(315, 101);
            this.btn_help_port.Name = "btn_help_port";
            this.btn_help_port.Size = new System.Drawing.Size(26, 23);
            this.btn_help_port.TabIndex = 17;
            this.btn_help_port.Text = "?";
            this.btn_help_port.UseVisualStyleBackColor = true;
            this.btn_help_port.Click += new System.EventHandler(this.btn_help_port_Click);
            // 
            // btn_help_mac
            // 
            this.btn_help_mac.Location = new System.Drawing.Point(315, 149);
            this.btn_help_mac.Name = "btn_help_mac";
            this.btn_help_mac.Size = new System.Drawing.Size(26, 23);
            this.btn_help_mac.TabIndex = 18;
            this.btn_help_mac.Text = "?";
            this.btn_help_mac.UseVisualStyleBackColor = true;
            this.btn_help_mac.Click += new System.EventHandler(this.btn_help_mac_Click);
            // 
            // numud_port
            // 
            this.numud_port.Enabled = false;
            this.numud_port.Location = new System.Drawing.Point(207, 75);
            this.numud_port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numud_port.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numud_port.Name = "numud_port";
            this.numud_port.Size = new System.Drawing.Size(134, 23);
            this.numud_port.TabIndex = 19;
            this.numud_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numud_port.Value = new decimal(new int[] {
            50002,
            0,
            0,
            0});
            this.numud_port.ValueChanged += new System.EventHandler(this.Port_EditOptions_TextChanged);
            // 
            // btn_help_create_bat
            // 
            this.btn_help_create_bat.Location = new System.Drawing.Point(315, 230);
            this.btn_help_create_bat.Name = "btn_help_create_bat";
            this.btn_help_create_bat.Size = new System.Drawing.Size(26, 23);
            this.btn_help_create_bat.TabIndex = 21;
            this.btn_help_create_bat.Text = "?";
            this.btn_help_create_bat.UseVisualStyleBackColor = true;
            this.btn_help_create_bat.Click += new System.EventHandler(this.btn_help_create_bat_Click);
            // 
            // btn_create_bat
            // 
            this.btn_create_bat.Location = new System.Drawing.Point(16, 222);
            this.btn_create_bat.Name = "btn_create_bat";
            this.btn_create_bat.Size = new System.Drawing.Size(293, 38);
            this.btn_create_bat.TabIndex = 20;
            this.btn_create_bat.Text = "Create Matching Bat File";
            this.btn_create_bat.UseVisualStyleBackColor = true;
            this.btn_create_bat.Click += new System.EventHandler(this.btn_create_bat_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(17, 263);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(42, 15);
            this.lbl_status.TabIndex = 22;
            this.lbl_status.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(253, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Created by Byrom";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 297);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_help_create_bat);
            this.Controls.Add(this.btn_create_bat);
            this.Controls.Add(this.numud_port);
            this.Controls.Add(this.btn_help_mac);
            this.Controls.Add(this.btn_help_port);
            this.Controls.Add(this.btn_help_create_bin);
            this.Controls.Add(this.btn_help_ip);
            this.Controls.Add(this.lbl_port);
            this.Controls.Add(this.combo_port);
            this.Controls.Add(this.chkbox_custom_port);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_head_IP);
            this.Controls.Add(this.btn_regenmac);
            this.Controls.Add(this.lbl_macaddr);
            this.Controls.Add(this.lbl_IP);
            this.Controls.Add(this.tbox_ipaddr);
            this.Controls.Add(this.combo_ipaddr);
            this.Controls.Add(this.chkbox_manual_ip);
            this.Controls.Add(this.btn_grab_ips);
            this.Controls.Add(this.btn_create_binary);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Generate KDNet Config Binary";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numud_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_create_binary;
        private System.Windows.Forms.Button btn_grab_ips;
        private System.Windows.Forms.CheckBox chkbox_manual_ip;
        private System.Windows.Forms.ComboBox combo_ipaddr;
        private System.Windows.Forms.TextBox tbox_ipaddr;
        private System.Windows.Forms.Label lbl_IP;
        private System.Windows.Forms.Label lbl_macaddr;
        private System.Windows.Forms.Button btn_regenmac;
        private System.Windows.Forms.Label lbl_head_IP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_port;
        private System.Windows.Forms.CheckBox chkbox_custom_port;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.Button btn_help_ip;
        private System.Windows.Forms.Button btn_help_create_bin;
        private System.Windows.Forms.Button btn_help_port;
        private System.Windows.Forms.Button btn_help_mac;
        private System.Windows.Forms.NumericUpDown numud_port;
        private System.Windows.Forms.Button btn_help_create_bat;
        private System.Windows.Forms.Button btn_create_bat;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label label2;
    }
}

