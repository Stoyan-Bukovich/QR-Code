namespace SNBSolutions
{
    partial class WiFi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WiFi));
            this.tbSSID = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkWPA = new System.Windows.Forms.CheckBox();
            this.chkHidden = new System.Windows.Forms.CheckBox();
            this.btn_GetQR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbSSID
            // 
            this.tbSSID.Location = new System.Drawing.Point(12, 40);
            this.tbSSID.MaxLength = 100;
            this.tbSSID.Name = "tbSSID";
            this.tbSSID.Size = new System.Drawing.Size(169, 20);
            this.tbSSID.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(12, 88);
            this.tbPassword.MaxLength = 150;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(169, 20);
            this.tbPassword.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Network name (SSID)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // chkWPA
            // 
            this.chkWPA.AutoSize = true;
            this.chkWPA.Checked = true;
            this.chkWPA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWPA.Location = new System.Drawing.Point(199, 88);
            this.chkWPA.Name = "chkWPA";
            this.chkWPA.Size = new System.Drawing.Size(109, 17);
            this.chkWPA.TabIndex = 6;
            this.chkWPA.Text = "Is WPA enabled?";
            this.chkWPA.UseVisualStyleBackColor = true;
            // 
            // chkHidden
            // 
            this.chkHidden.AutoSize = true;
            this.chkHidden.Location = new System.Drawing.Point(199, 40);
            this.chkHidden.Name = "chkHidden";
            this.chkHidden.Size = new System.Drawing.Size(116, 17);
            this.chkHidden.TabIndex = 5;
            this.chkHidden.Text = "Is hidden network?";
            this.chkHidden.UseVisualStyleBackColor = true;
            // 
            // btn_GetQR
            // 
            this.btn_GetQR.Location = new System.Drawing.Point(12, 131);
            this.btn_GetQR.Name = "btn_GetQR";
            this.btn_GetQR.Size = new System.Drawing.Size(296, 23);
            this.btn_GetQR.TabIndex = 7;
            this.btn_GetQR.Text = "Get QR";
            this.btn_GetQR.UseVisualStyleBackColor = true;
            this.btn_GetQR.Click += new System.EventHandler(this.btn_GetQR_Click);
            // 
            // WiFi
            // 
            this.AcceptButton = this.btn_GetQR;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 166);
            this.Controls.Add(this.btn_GetQR);
            this.Controls.Add(this.chkHidden);
            this.Controls.Add(this.chkWPA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbSSID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WiFi";
            this.Text = "WiFi QR - SNB Solutions";
            this.Load += new System.EventHandler(this.WiFi_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSSID;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkWPA;
        private System.Windows.Forms.CheckBox chkHidden;
        private System.Windows.Forms.Button btn_GetQR;
    }
}