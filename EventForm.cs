#region Using
using System;
using System.Windows.Forms;
#endregion

namespace SNBSolutions
{
    public partial class EventForm : Form
    {
        public delegate void EventFormDataHandler(string subject, string description, string location, DateTime startDate, DateTime endDate, bool allDay);
        public event EventFormDataHandler OnEventFormDataReady;

        #region Form events
        public EventForm()
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
        private void EventForm_Load(object sender, EventArgs e)
        {
            tbSubject.Focus();
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.CustomFormat = "yyyy-MM-dd HH:mm";
            dtpStart.ShowUpDown = true;

            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.CustomFormat = "yyyy-MM-dd HH:mm";
            dtpEnd.ShowUpDown = true;
        }
        #endregion

        #region Event handlers
        private void btn_GetQR_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbSubject.Text))
            {
                MessageBox.Show("Subject is required field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(tbDescription.Text))
            {
                MessageBox.Show("Description is required field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(tbLocation.Text))
            {
                MessageBox.Show("Location is required field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string description = tbDescription.Text;
                string subject = tbSubject.Text;
                string location = tbLocation.Text;
                bool allDay = chkAllDay.Checked;
                DateTime startDate = dtpStart.Value;
                DateTime endDate = dtpEnd.Value;

                OnEventFormDataReady?.Invoke(subject, description, location, startDate, endDate, allDay);

                this.Close();
            }
        }
        #endregion
    }
}