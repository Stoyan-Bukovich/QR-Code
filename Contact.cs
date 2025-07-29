#region Using
using System;
using System.Windows.Forms;
#endregion

namespace SNBSolutions
{
    public partial class ContactForm : Form
    {
        public delegate void ContactFormDataHandler(string firstname, string lastname, string mobile, string phone, string email, string address, string website, string notes, string company, string zip);
        public event ContactFormDataHandler OnContactFormDataReady;

        #region Form events
        public ContactForm()
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
        private void ContactForm_Load(object sender, EventArgs e)
        {
            tbFirstName.Focus();
        }
        #endregion

        #region Event handlers
        private void btn_GetQR_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbFirstName.Text))
            {
                MessageBox.Show("First name is required field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(tbLastName.Text))
            {
                MessageBox.Show("Last name is required field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(tbMobile.Text))
            {
                MessageBox.Show("Mobile phone is required field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("Email address is required field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string firstname = tbFirstName.Text;
                string lastname = tbLastName.Text;
                string mobile = tbMobile.Text;
                string phone = tbWorkPhone.Text;
                string email = tbEmail.Text;
                string address = tbAddress.Text;
                string website = tbWebsite.Text;
                string notes = tbNotes.Text;
                string company = tbCompany.Text;
                string zip = tbZip.Text;

                OnContactFormDataReady?.Invoke(firstname, lastname, mobile, phone, email, address, website, notes, company, zip);

                this.Close();
            }
        }
        #endregion
    }
}