using System;
using System.Drawing;
using System.Windows.Forms;

namespace RemoteMusicServer
{
    public partial class DebugForm : Form
    {

        public DebugForm()
        {
            InitializeComponent();
        }

        // Shadow for the window
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }


        #region Controls methods

        private void volumeUpBTN_Click(object sender, EventArgs e)
        {
            AppCommand.Send(AppCommands.VolumeUp);
        }

        private void volumeDownBTN_Click(object sender, EventArgs e)
        {
            AppCommand.Send(AppCommands.VolumeDown);
        }

        private void volumeMuteBTN_Click(object sender, EventArgs e)
        {
            AppCommand.Send(AppCommands.VolumeMute);
        }

        private void previousTrackBTN_Click(object sender, EventArgs e)
        {
            AppCommand.Send(AppCommands.MediaPrevious);
        }

        private void playPauseBTN_Click(object sender, EventArgs e)
        {
            AppCommand.Send(AppCommands.MediaPlayPause);
        }

        private void nextTrackBTN_Click(object sender, EventArgs e)
        {
            AppCommand.Send(AppCommands.MediaNext);
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void minimizeBTN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Window dragging
        private bool dragging;
        private Point lastLocation;

        private void titleLBL_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            lastLocation = e.Location;
        }
        private void titleLBL_MouseMove(object sender, MouseEventArgs e)
        {
            if (!dragging) return;

            Location = new Point((Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
            Update();
        }
        private void titleLBL_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion
    }
}
