#region Using
using System;
using System.Windows.Forms;
#endregion

namespace SNBSolutions
{
    public partial class LocationForm : Form
    {
        public delegate void LocationFormDataHandler(string latitude, string longitude);
        public event LocationFormDataHandler OnLocationFormDataReady;

        #region Form events
        public LocationForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void LocationForm_Load(object sender, EventArgs e)
        {
            tbSSID.Focus();
        }
        #endregion

        #region Event handlers
        private void btn_GetQR_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbSSID.Text))
            {
                MessageBox.Show("Latitude is required field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Longitude is required field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string longitude = tbPassword.Text;
                string latitude = tbSSID.Text;

                OnLocationFormDataReady?.Invoke(latitude, longitude);

                this.Close();
            }
        }
        #endregion
    }
}