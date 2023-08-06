using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteMusicServer
{
    public partial class SettingsForm : Form
    {
        private static string _appName = Application.ProductName;
        private static string _appFolderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\{Application.CompanyName}\{_appName}";
        private static string _appConfigPath = $@"{_appFolderPath}\config.ini";

        private CommandListener listener = new CommandListener();
        private Config config = new Config(_appConfigPath);
        private DebugForm debugForm = new DebugForm();

        public SettingsForm()
        {
            InitializeComponent();


            config.Load();
            listener.Start(config.GetPort());
        }
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            portMTB.Text = config.GetPort().ToString();
            bool startupHide = config.GetStartupHide();
            startupHideCB.Checked = startupHide;


            if (startupHide)
            {
                Hide();
                notifyIcon.Visible = true;
                return;
            }

            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
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


        private DateTime lastError;
        private async void ShowError(string message = "Something went wrong...", int delay = 3500)
        {
            if (errorLBL.Visible && errorLBL.Text == message) return;

            DateTime now = DateTime.Now;
            lastError = now;

            errorLBL.Text = message;
            errorLBL.Visible = true;

            await Task.Delay(delay);

            if (lastError.CompareTo(now) > 0) return;
            errorLBL.Visible = false;
        }

        #region Controls methods
        private void portMTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar != Keys.Enter) return;


            int port = Int32.Parse(portMTB.Text);
            if (config.GetPort() == port)
            {
                ShowError("You didn't change anything!");
                return;
            }
            config.SetPort(port);
            config.Save();

            listener.Stop();
            listener.Start(port);

            MessageBox.Show("Successfully changed port!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void startupHideCB_CheckedChanged(object sender, EventArgs e)
        {
            config.SetStartupHide(startupHideCB.Checked);
            config.Save();
        }

        private void debugBTN_Click(object sender, EventArgs e)
        {
            debugForm.Show();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            notifyIcon.Visible = false;
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            listener.Stop();
            Environment.Exit(0);
        }

        private void minimizeBTN_Click(object sender, EventArgs e)
        {
            debugForm.Hide();
            Hide();
            notifyIcon.Visible = true;
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
