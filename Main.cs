#region Using
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QRCoder;
#endregion

namespace SNBSolutions
{
    public partial class Main : Form
    {

        #region Form events
        public Main()
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
        private void QRcode_Load(object sender, EventArgs e)
        {
            drpDark.DropDownStyle = ComboBoxStyle.DropDownList;
            drpLight.DropDownStyle = ComboBoxStyle.DropDownList;

            var errors = new Dictionary<string, string>
            {
                {"ECCLevel.L - 7%", "L" },
                {"ECCLevel.M - 15%", "M" },
                {"ECCLevel.Q - 25%", "Q" },
                {"ECCLevel.H - 30%", "H" },
            };

            var colors = new Dictionary<string, string>
            {
                { "Black", "#000000" },
                { "White", "#FFFFFF" },
                { "Gray", "#808080" },
                { "Silver", "#C0C0C0" },
                { "Red", "#FF0000" },
                { "Maroon", "#800000" },
                { "Pink", "#FFC0CB" },
                { "Hot Pink", "#FF69B4" },
                { "Orange", "#FFA500" },
                { "Dark Orange", "#FF8C00" },
                { "Yellow", "#FFFF00" },
                { "Gold", "#FFD700" },
                { "Green", "#008000" },
                { "Lime", "#00FF00" },
                { "Olive", "#808000" },
                { "Teal", "#008080" },
                { "Cyan", "#00FFFF" },
                { "Light Blue", "#ADD8E6" },
                { "Blue", "#0000FF" },
                { "Navy", "#000080" },
                { "Purple", "#800080" },
                { "Violet", "#EE82EE" },
                { "Brown", "#A52A2A" },
                { "Tan", "#D2B48C" },
                { "Coral", "#FF7F50" },
                { "Salmon", "#FA8072" },
                { "Indigo", "#4B0082" },
                { "Turquoise", "#40E0D0" },
                { "Sky Blue", "#87CEEB" },
                { "Mint", "#98FF98" },
                { "Transparent", "#00FFFFFF"}
            };

            drpErrorCorrection.DataSource = new BindingSource(errors, null);
            drpErrorCorrection.DisplayMember = "Key";
            drpErrorCorrection.ValueMember = "Value";
            drpErrorCorrection.SelectedValue = "H";

            drpDark.DataSource = new BindingSource(colors, null);
            drpDark.DisplayMember = "Key";
            drpDark.ValueMember = "Value";
            drpDark.SelectedValue = "#000000";

            drpLight.DataSource = new BindingSource(colors, null);
            drpLight.DisplayMember = "Key";
            drpLight.ValueMember = "Value";
            drpLight.SelectedValue = "#FFFFFF";

            button1.PerformClick();
        }
        #endregion

        #region Event handlers
        private void button1_Click(object sender, EventArgs e)
        {
            string payload = textBox1.Text;

            if(String.IsNullOrEmpty(payload))
            {
                payload = "SNB Solutions";
            }

            CodeSettings(payload);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                string file = "QR_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
                pictureBox1.Image.Save(file, System.Drawing.Imaging.ImageFormat.Jpeg);
                MessageBox.Show("Image saved in root directory as: " + file, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                string file = "QR_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".png";
                pictureBox1.Image.Save(file, System.Drawing.Imaging.ImageFormat.Png);

                MessageBox.Show("Image saved in root directory as: " + file, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void wiFiQRCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WiFi wifiForm = new WiFi();
            wifiForm.OnWiFiDataReady += WifiForm_OnWiFiDataReady;
            wifiForm.Show();
        }
        private void WifiForm_OnWiFiDataReady(bool isWPA, bool isHidden, string password, string ssid)
        {
            var payload = new PayloadGenerator.WiFi(
                ssid,
                password,
                isWPA ? PayloadGenerator.WiFi.Authentication.WPA : PayloadGenerator.WiFi.Authentication.WEP,
                isHidden
            );

            CodeSettings(payload.ToString());
        }
        private void eventForm_OnEventFormDataReady(string subject, string description, string location, DateTime startDate, DateTime endDate, bool allDay)
        {
            var payload = new PayloadGenerator.CalendarEvent(
                subject: subject,
                description: description,
                location: location,
                start: startDate,
                end: endDate,
                allDayEvent: allDay
            );

            CodeSettings(payload.ToString());
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void eventQRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.OnEventFormDataReady += eventForm_OnEventFormDataReady;
            eventForm.Show();
        }
        private void locationQRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocationForm locationForm = new LocationForm();
            locationForm.OnLocationFormDataReady += eventForm_OnLocationFormDataReady;
            locationForm.Show();
        }
        private void eventForm_OnLocationFormDataReady(string latitude, string longitude)
        {
            var payload = new PayloadGenerator.Geolocation(
                  latitude,
                  longitude
            );

            CodeSettings(payload.ToString());
        }
        private void eventForm_OnContactFormDataReady(string firstname, string lastname, string mobile, string phone, string email, string address, string website, string notes, string company, string zip)
        {
            var payload = new PayloadGenerator.ContactData(
                PayloadGenerator.ContactData.ContactOutputType.VCard3,
                firstname: firstname,
                lastname: lastname,
                mobilePhone: mobile,
                workPhone: phone,
                email: email,
                street: address,
                note: notes,
                website: website,
                org: company,
                zipCode: zip
            );

            CodeSettings(payload.ToString());
        }
        private void contactQRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm();
            contactForm.OnContactFormDataReady += eventForm_OnContactFormDataReady;
            contactForm.Show();
        }
        private void eventForm_OnWhatsAppFormDataReady(string number, string message)
        {
            var payload = new PayloadGenerator.WhatsAppMessage(
               number: number,
               message: message
            );

            CodeSettings(payload.ToString());
        }
        private void whatsAppMessageQRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WhatsAppForm whatsappForm = new WhatsAppForm();
            whatsappForm.OnWhatsAppFormDataReady += eventForm_OnWhatsAppFormDataReady;
            whatsappForm.Show();
        }
        #endregion

        #region Methods
        private void CodeSettings(string text)
        {
            QRCodeGenerator QG = new QRCodeGenerator();
            QRCodeGenerator.ECCLevel eccLevel;

            string selectedECC = drpErrorCorrection.SelectedValue?.ToString().ToUpper();

            switch (selectedECC)
            {
                case "L":
                    eccLevel = QRCodeGenerator.ECCLevel.L;
                    break;
                case "M":
                    eccLevel = QRCodeGenerator.ECCLevel.M;
                    break;
                case "Q":
                    eccLevel = QRCodeGenerator.ECCLevel.Q;
                    break;
                case "H":
                default:
                    eccLevel = QRCodeGenerator.ECCLevel.H;
                    break;
            }

            var data = QG.CreateQrCode(text, eccLevel);
            var code = new QRCode(data);

            string selectedDark = ((KeyValuePair<string, string>)drpDark.SelectedItem).Value;
            string selectedLight = ((KeyValuePair<string, string>)drpLight.SelectedItem).Value;

            Color dark = ColorTranslator.FromHtml(selectedDark);
            Color light = ColorTranslator.FromHtml(selectedLight);

            if (checkBox1.Checked)
            {
                pictureBox1.Image = code.GetGraphic(
                        pixelsPerModule: 10,
                        darkColor: dark,
                        lightColor: light,
                        drawQuietZones: true
                    );
            }
            else
            {
                pictureBox1.Image = code.GetGraphic(
                        pixelsPerModule: 10,
                        darkColor: dark,
                        lightColor: light,
                        drawQuietZones: false
                    );
            }
        }
        #endregion
    }
}