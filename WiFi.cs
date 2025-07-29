#region Using
using System;
using System.Windows.Forms;
#endregion

namespace SNBSolutions
{
    public partial class WiFi : Form
    {
        public delegate void WiFiDataHandler(bool isWPA, bool isHidden, string password, string ssid);
        public event WiFiDataHandler OnWiFiDataReady;

        #region Form events
        public WiFi()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void WiFi_Load(object sender, EventArgs e)
        {
            tbSSID.Focus();
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion

        #region Event handlers
        private void btn_GetQR_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbSSID.Text))
            {
                MessageBox.Show("Network name is required field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Password is required field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool isWPA = chkWPA.Checked;
                bool isHidden = chkHidden.Checked;
                string password = tbPassword.Text;
                string ssid = tbSSID.Text;

                OnWiFiDataReady?.Invoke(isWPA, isHidden, password, ssid);

                this.Close();
            }
        }
        #endregion
    }
}