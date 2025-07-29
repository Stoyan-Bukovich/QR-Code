#region Using
using System;
using System.Windows.Forms;
#endregion

namespace SNBSolutions
{
    public partial class WhatsAppForm : Form
    {
        public delegate void WhatsAppFormDataHandler(string number, string message);
        public event WhatsAppFormDataHandler OnWhatsAppFormDataReady;

        #region Form events
        public WhatsAppForm()
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
        private void WhatsAppForm_Load(object sender, EventArgs e)
        {
            tbPhone.Focus();
        }
        #endregion

        #region Event handlers
        private void btn_GetQR_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbPhone.Text))
            {
                MessageBox.Show("Phone number is required field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(tbMessage.Text))
            {
                MessageBox.Show("Message is required field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string message = tbMessage.Text;
                string phone = tbPhone.Text;

                OnWhatsAppFormDataReady?.Invoke(phone, message);

                this.Close();
            }
        }
        #endregion
    }
}