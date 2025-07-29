namespace SNBSolutions
{
    partial class ContactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactForm));
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btn_GetQR = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.tbWebsite = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblWorkPhone = new System.Windows.Forms.Label();
            this.tbWorkPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCompany = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbZip = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(12, 40);
            this.tbFirstName.MaxLength = 250;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(169, 20);
            this.tbFirstName.TabIndex = 2;
            // 
            // tbMobile
            // 
            this.tbMobile.Location = new System.Drawing.Point(12, 88);
            this.tbMobile.MaxLength = 15;
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(169, 20);
            this.tbMobile.TabIndex = 6;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 21);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(55, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First name";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 72);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(71, 13);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Mobile phone";
            // 
            // btn_GetQR
            // 
            this.btn_GetQR.Location = new System.Drawing.Point(83, 438);
            this.btn_GetQR.Name = "btn_GetQR";
            this.btn_GetQR.Size = new System.Drawing.Size(199, 23);
            this.btn_GetQR.TabIndex = 21;
            this.btn_GetQR.Text = "Get QR";
            this.btn_GetQR.UseVisualStyleBackColor = true;
            this.btn_GetQR.Click += new System.EventHandler(this.btn_GetQR_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 120);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 13);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email address";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(12, 139);
            this.tbEmail.MaxLength = 250;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(270, 20);
            this.tbEmail.TabIndex = 10;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 172);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Address";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(12, 191);
            this.tbAddress.MaxLength = 250;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(349, 20);
            this.tbAddress.TabIndex = 12;
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Location = new System.Drawing.Point(12, 226);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(46, 13);
            this.lblWebsite.TabIndex = 13;
            this.lblWebsite.Text = "Website";
            // 
            // tbWebsite
            // 
            this.tbWebsite.Location = new System.Drawing.Point(12, 245);
            this.tbWebsite.MaxLength = 250;
            this.tbWebsite.Name = "tbWebsite";
            this.tbWebsite.Size = new System.Drawing.Size(169, 20);
            this.tbWebsite.TabIndex = 14;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(12, 331);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 13);
            this.lblNotes.TabIndex = 19;
            this.lblNotes.Text = "Notes";
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(12, 352);
            this.tbNotes.MaxLength = 250;
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(349, 70);
            this.tbNotes.TabIndex = 20;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(190, 21);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last name";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(193, 40);
            this.tbLastName.MaxLength = 250;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(169, 20);
            this.tbLastName.TabIndex = 4;
            // 
            // lblWorkPhone
            // 
            this.lblWorkPhone.AutoSize = true;
            this.lblWorkPhone.Location = new System.Drawing.Point(190, 72);
            this.lblWorkPhone.Name = "lblWorkPhone";
            this.lblWorkPhone.Size = new System.Drawing.Size(66, 13);
            this.lblWorkPhone.TabIndex = 7;
            this.lblWorkPhone.Text = "Work phone";
            // 
            // tbWorkPhone
            // 
            this.tbWorkPhone.Location = new System.Drawing.Point(190, 88);
            this.tbWorkPhone.MaxLength = 15;
            this.tbWorkPhone.Name = "tbWorkPhone";
            this.tbWorkPhone.Size = new System.Drawing.Size(169, 20);
            this.tbWorkPhone.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Company";
            // 
            // tbCompany
            // 
            this.tbCompany.Location = new System.Drawing.Point(12, 297);
            this.tbCompany.MaxLength = 250;
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.Size = new System.Drawing.Size(347, 20);
            this.tbCompany.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "ZIP code";
            // 
            // tbZip
            // 
            this.tbZip.Location = new System.Drawing.Point(190, 245);
            this.tbZip.MaxLength = 250;
            this.tbZip.Name = "tbZip";
            this.tbZip.Size = new System.Drawing.Size(169, 20);
            this.tbZip.TabIndex = 16;
            // 
            // ContactForm
            // 
            this.AcceptButton = this.btn_GetQR;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 468);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbZip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCompany);
            this.Controls.Add(this.lblWorkPhone);
            this.Controls.Add(this.tbWorkPhone);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.lblWebsite);
            this.Controls.Add(this.tbWebsite);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.btn_GetQR);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.tbMobile);
            this.Controls.Add(this.tbFirstName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContactForm";
            this.Text = "Contact QR - SNB Solutions";
            this.Load += new System.EventHandler(this.ContactForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbMobile;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btn_GetQR;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.TextBox tbWebsite;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblWorkPhone;
        private System.Windows.Forms.TextBox tbWorkPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbZip;
    }
}