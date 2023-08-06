namespace RemoteMusicServer
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.titleLBL = new System.Windows.Forms.Label();
            this.errorLBL = new System.Windows.Forms.Label();
            this.minimizeBTN = new System.Windows.Forms.Button();
            this.closeBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.portMTB = new System.Windows.Forms.MaskedTextBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.debugBTN = new System.Windows.Forms.Button();
            this.startupHideCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // titleLBL
            // 
            this.titleLBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.titleLBL.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLBL.Font = new System.Drawing.Font("Lato", 10F);
            this.titleLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.titleLBL.Location = new System.Drawing.Point(0, 0);
            this.titleLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLBL.Name = "titleLBL";
            this.titleLBL.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.titleLBL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.titleLBL.Size = new System.Drawing.Size(370, 26);
            this.titleLBL.TabIndex = 0;
            this.titleLBL.Text = "RemoteMusic Settings";
            this.titleLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleLBL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleLBL_MouseDown);
            this.titleLBL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleLBL_MouseMove);
            this.titleLBL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleLBL_MouseUp);
            // 
            // errorLBL
            // 
            this.errorLBL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.errorLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(80)))), ((int)(((byte)(72)))));
            this.errorLBL.Location = new System.Drawing.Point(0, 139);
            this.errorLBL.Name = "errorLBL";
            this.errorLBL.Size = new System.Drawing.Size(370, 71);
            this.errorLBL.TabIndex = 3;
            this.errorLBL.Text = "Error message";
            this.errorLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.errorLBL.Visible = false;
            // 
            // minimizeBTN
            // 
            this.minimizeBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.minimizeBTN.BackgroundImage = global::RemoteMusicServer.Properties.Resources.minimize_icon;
            this.minimizeBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeBTN.FlatAppearance.BorderSize = 0;
            this.minimizeBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(94)))), ((int)(((byte)(102)))));
            this.minimizeBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.minimizeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBTN.Font = new System.Drawing.Font("Lato", 12F);
            this.minimizeBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.minimizeBTN.Location = new System.Drawing.Point(298, 0);
            this.minimizeBTN.Margin = new System.Windows.Forms.Padding(0);
            this.minimizeBTN.Name = "minimizeBTN";
            this.minimizeBTN.Size = new System.Drawing.Size(36, 26);
            this.minimizeBTN.TabIndex = 4;
            this.minimizeBTN.UseVisualStyleBackColor = false;
            this.minimizeBTN.Click += new System.EventHandler(this.minimizeBTN_Click);
            // 
            // closeBTN
            // 
            this.closeBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.closeBTN.BackgroundImage = global::RemoteMusicServer.Properties.Resources.close_icon;
            this.closeBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBTN.FlatAppearance.BorderSize = 0;
            this.closeBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(80)))), ((int)(((byte)(72)))));
            this.closeBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(73)))), ((int)(((byte)(67)))));
            this.closeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBTN.Font = new System.Drawing.Font("Lato", 12F);
            this.closeBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(80)))), ((int)(((byte)(72)))));
            this.closeBTN.Location = new System.Drawing.Point(334, 0);
            this.closeBTN.Margin = new System.Windows.Forms.Padding(0);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(36, 26);
            this.closeBTN.TabIndex = 5;
            this.closeBTN.UseVisualStyleBackColor = false;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Port to listen:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // portMTB
            // 
            this.portMTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.portMTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.portMTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.portMTB.HidePromptOnLeave = true;
            this.portMTB.Location = new System.Drawing.Point(208, 46);
            this.portMTB.Mask = "00000";
            this.portMTB.Name = "portMTB";
            this.portMTB.Size = new System.Drawing.Size(60, 27);
            this.portMTB.TabIndex = 9;
            this.portMTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.portMTB_KeyPress);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "RemoteMusic";
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // debugBTN
            // 
            this.debugBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.debugBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.debugBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.debugBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.debugBTN.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.debugBTN.Location = new System.Drawing.Point(9, 170);
            this.debugBTN.Margin = new System.Windows.Forms.Padding(0);
            this.debugBTN.Name = "debugBTN";
            this.debugBTN.Size = new System.Drawing.Size(67, 31);
            this.debugBTN.TabIndex = 10;
            this.debugBTN.Text = "Debug";
            this.debugBTN.UseVisualStyleBackColor = false;
            this.debugBTN.Click += new System.EventHandler(this.debugBTN_Click);
            // 
            // startupHideCB
            // 
            this.startupHideCB.AutoSize = true;
            this.startupHideCB.Location = new System.Drawing.Point(106, 79);
            this.startupHideCB.Name = "startupHideCB";
            this.startupHideCB.Size = new System.Drawing.Size(118, 23);
            this.startupHideCB.TabIndex = 11;
            this.startupHideCB.Text = "Hide on start";
            this.startupHideCB.UseVisualStyleBackColor = true;
            this.startupHideCB.CheckedChanged += new System.EventHandler(this.startupHideCB_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(370, 210);
            this.ControlBox = false;
            this.Controls.Add(this.startupHideCB);
            this.Controls.Add(this.debugBTN);
            this.Controls.Add(this.portMTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimizeBTN);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.errorLBL);
            this.Controls.Add(this.titleLBL);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Lato", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoteMusic Settings";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLBL;
        private System.Windows.Forms.Label errorLBL;
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.Button minimizeBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox portMTB;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button debugBTN;
        private System.Windows.Forms.CheckBox startupHideCB;
    }
}

