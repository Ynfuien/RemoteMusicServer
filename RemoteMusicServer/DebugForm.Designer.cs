namespace RemoteMusicServer
{
    partial class DebugForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebugForm));
            this.titleLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.playPauseBTN = new System.Windows.Forms.Button();
            this.minimizeBTN = new System.Windows.Forms.Button();
            this.closeBTN = new System.Windows.Forms.Button();
            this.volumeDownBTN = new System.Windows.Forms.Button();
            this.volumeUpBTN = new System.Windows.Forms.Button();
            this.volumeMuteBTN = new System.Windows.Forms.Button();
            this.nextTrackBTN = new System.Windows.Forms.Button();
            this.previousTrackBTN = new System.Windows.Forms.Button();
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
            this.titleLBL.Size = new System.Drawing.Size(400, 26);
            this.titleLBL.TabIndex = 0;
            this.titleLBL.Text = "Debugging";
            this.titleLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleLBL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleLBL_MouseDown);
            this.titleLBL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleLBL_MouseMove);
            this.titleLBL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleLBL_MouseUp);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Media buttons:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(12, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Button";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // playPauseBTN
            // 
            this.playPauseBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playPauseBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.playPauseBTN.BackgroundImage = global::RemoteMusicServer.Properties.Resources.pause_play;
            this.playPauseBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playPauseBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playPauseBTN.FlatAppearance.BorderSize = 0;
            this.playPauseBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(77)))));
            this.playPauseBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.playPauseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playPauseBTN.Font = new System.Drawing.Font("Lato", 12F);
            this.playPauseBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.playPauseBTN.Location = new System.Drawing.Point(256, 84);
            this.playPauseBTN.Margin = new System.Windows.Forms.Padding(2);
            this.playPauseBTN.Name = "playPauseBTN";
            this.playPauseBTN.Size = new System.Drawing.Size(46, 46);
            this.playPauseBTN.TabIndex = 10;
            this.playPauseBTN.UseVisualStyleBackColor = false;
            this.playPauseBTN.Click += new System.EventHandler(this.playPauseBTN_Click);
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
            this.minimizeBTN.Location = new System.Drawing.Point(328, 0);
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
            this.closeBTN.Location = new System.Drawing.Point(364, 0);
            this.closeBTN.Margin = new System.Windows.Forms.Padding(0);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(36, 26);
            this.closeBTN.TabIndex = 5;
            this.closeBTN.UseVisualStyleBackColor = false;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // volumeDownBTN
            // 
            this.volumeDownBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeDownBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.volumeDownBTN.BackgroundImage = global::RemoteMusicServer.Properties.Resources.volume_down;
            this.volumeDownBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.volumeDownBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumeDownBTN.FlatAppearance.BorderSize = 0;
            this.volumeDownBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(77)))));
            this.volumeDownBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.volumeDownBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volumeDownBTN.Font = new System.Drawing.Font("Lato", 12F);
            this.volumeDownBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.volumeDownBTN.Location = new System.Drawing.Point(98, 90);
            this.volumeDownBTN.Margin = new System.Windows.Forms.Padding(2);
            this.volumeDownBTN.Name = "volumeDownBTN";
            this.volumeDownBTN.Size = new System.Drawing.Size(34, 34);
            this.volumeDownBTN.TabIndex = 11;
            this.volumeDownBTN.UseVisualStyleBackColor = false;
            this.volumeDownBTN.Click += new System.EventHandler(this.volumeDownBTN_Click);
            // 
            // volumeUpBTN
            // 
            this.volumeUpBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeUpBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.volumeUpBTN.BackgroundImage = global::RemoteMusicServer.Properties.Resources.volume_up;
            this.volumeUpBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.volumeUpBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumeUpBTN.FlatAppearance.BorderSize = 0;
            this.volumeUpBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(77)))));
            this.volumeUpBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.volumeUpBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volumeUpBTN.Font = new System.Drawing.Font("Lato", 12F);
            this.volumeUpBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.volumeUpBTN.Location = new System.Drawing.Point(60, 90);
            this.volumeUpBTN.Margin = new System.Windows.Forms.Padding(2);
            this.volumeUpBTN.Name = "volumeUpBTN";
            this.volumeUpBTN.Size = new System.Drawing.Size(34, 34);
            this.volumeUpBTN.TabIndex = 12;
            this.volumeUpBTN.UseVisualStyleBackColor = false;
            this.volumeUpBTN.Click += new System.EventHandler(this.volumeUpBTN_Click);
            // 
            // volumeMuteBTN
            // 
            this.volumeMuteBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeMuteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.volumeMuteBTN.BackgroundImage = global::RemoteMusicServer.Properties.Resources.volume_mute;
            this.volumeMuteBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.volumeMuteBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumeMuteBTN.FlatAppearance.BorderSize = 0;
            this.volumeMuteBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(77)))));
            this.volumeMuteBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.volumeMuteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volumeMuteBTN.Font = new System.Drawing.Font("Lato", 12F);
            this.volumeMuteBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.volumeMuteBTN.Location = new System.Drawing.Point(136, 90);
            this.volumeMuteBTN.Margin = new System.Windows.Forms.Padding(2);
            this.volumeMuteBTN.Name = "volumeMuteBTN";
            this.volumeMuteBTN.Size = new System.Drawing.Size(34, 34);
            this.volumeMuteBTN.TabIndex = 13;
            this.volumeMuteBTN.UseVisualStyleBackColor = false;
            this.volumeMuteBTN.Click += new System.EventHandler(this.volumeMuteBTN_Click);
            // 
            // nextTrackBTN
            // 
            this.nextTrackBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextTrackBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.nextTrackBTN.BackgroundImage = global::RemoteMusicServer.Properties.Resources.next_track;
            this.nextTrackBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextTrackBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextTrackBTN.FlatAppearance.BorderSize = 0;
            this.nextTrackBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(77)))));
            this.nextTrackBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.nextTrackBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextTrackBTN.Font = new System.Drawing.Font("Lato", 12F);
            this.nextTrackBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.nextTrackBTN.Location = new System.Drawing.Point(306, 90);
            this.nextTrackBTN.Margin = new System.Windows.Forms.Padding(2);
            this.nextTrackBTN.Name = "nextTrackBTN";
            this.nextTrackBTN.Size = new System.Drawing.Size(34, 34);
            this.nextTrackBTN.TabIndex = 14;
            this.nextTrackBTN.UseVisualStyleBackColor = false;
            this.nextTrackBTN.Click += new System.EventHandler(this.nextTrackBTN_Click);
            // 
            // previousTrackBTN
            // 
            this.previousTrackBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.previousTrackBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.previousTrackBTN.BackgroundImage = global::RemoteMusicServer.Properties.Resources.previous_track;
            this.previousTrackBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previousTrackBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previousTrackBTN.FlatAppearance.BorderSize = 0;
            this.previousTrackBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(77)))));
            this.previousTrackBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.previousTrackBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousTrackBTN.Font = new System.Drawing.Font("Lato", 12F);
            this.previousTrackBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.previousTrackBTN.Location = new System.Drawing.Point(218, 90);
            this.previousTrackBTN.Margin = new System.Windows.Forms.Padding(2);
            this.previousTrackBTN.Name = "previousTrackBTN";
            this.previousTrackBTN.Size = new System.Drawing.Size(34, 34);
            this.previousTrackBTN.TabIndex = 15;
            this.previousTrackBTN.UseVisualStyleBackColor = false;
            this.previousTrackBTN.Click += new System.EventHandler(this.previousTrackBTN_Click);
            // 
            // DebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(400, 240);
            this.ControlBox = false;
            this.Controls.Add(this.previousTrackBTN);
            this.Controls.Add(this.nextTrackBTN);
            this.Controls.Add(this.volumeMuteBTN);
            this.Controls.Add(this.volumeUpBTN);
            this.Controls.Add(this.volumeDownBTN);
            this.Controls.Add(this.playPauseBTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimizeBTN);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.titleLBL);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Lato", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DebugForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Debugging";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLBL;
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.Button minimizeBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button playPauseBTN;
        private System.Windows.Forms.Button volumeDownBTN;
        private System.Windows.Forms.Button volumeUpBTN;
        private System.Windows.Forms.Button volumeMuteBTN;
        private System.Windows.Forms.Button nextTrackBTN;
        private System.Windows.Forms.Button previousTrackBTN;
    }
}

