namespace HotelsPro2
{
    partial class GuestRegistrationFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestRegistrationFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.comboIssuingBody = new System.Windows.Forms.ComboBox();
            this.comboDocumentType = new System.Windows.Forms.ComboBox();
            this.comboOccupation = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.lblBirth = new System.Windows.Forms.Label();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.comboIssuingCountry = new System.Windows.Forms.ComboBox();
            this.lblIssuingCountry = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblIssuingBody = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblDocumentType = new System.Windows.Forms.Label();
            this.lblDocument = new System.Windows.Forms.Label();
            this.txtDocument = new System.Windows.Forms.TextBox();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.comboNationality = new System.Windows.Forms.ComboBox();
            this.lblNationality = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 40);
            this.label1.TabIndex = 18;
            this.label1.Text = "New Guest";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSubmit.Location = new System.Drawing.Point(159, 607);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(165, 39);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // comboIssuingBody
            // 
            this.comboIssuingBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.comboIssuingBody.FormattingEnabled = true;
            this.comboIssuingBody.Location = new System.Drawing.Point(187, 456);
            this.comboIssuingBody.Name = "comboIssuingBody";
            this.comboIssuingBody.Size = new System.Drawing.Size(242, 33);
            this.comboIssuingBody.TabIndex = 50;
            // 
            // comboDocumentType
            // 
            this.comboDocumentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.comboDocumentType.FormattingEnabled = true;
            this.comboDocumentType.Location = new System.Drawing.Point(187, 411);
            this.comboDocumentType.Name = "comboDocumentType";
            this.comboDocumentType.Size = new System.Drawing.Size(242, 33);
            this.comboDocumentType.TabIndex = 49;
            // 
            // comboOccupation
            // 
            this.comboOccupation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.comboOccupation.FormattingEnabled = true;
            this.comboOccupation.Location = new System.Drawing.Point(187, 332);
            this.comboOccupation.Name = "comboOccupation";
            this.comboOccupation.Size = new System.Drawing.Size(242, 33);
            this.comboOccupation.TabIndex = 48;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpBirth);
            this.panel2.Controls.Add(this.lblBirth);
            this.panel2.Controls.Add(this.radioMale);
            this.panel2.Controls.Add(this.radioFemale);
            this.panel2.Location = new System.Drawing.Point(71, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 39);
            this.panel2.TabIndex = 32;
            // 
            // dtpBirth
            // 
            this.dtpBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirth.Location = new System.Drawing.Point(220, 2);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(138, 29);
            this.dtpBirth.TabIndex = 2;
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Font = new System.Drawing.Font("Microsoft Tai Le", 14F);
            this.lblBirth.Location = new System.Drawing.Point(169, 8);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(50, 23);
            this.lblBirth.TabIndex = 3;
            this.lblBirth.Text = "Birth";
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Font = new System.Drawing.Font("Microsoft Tai Le", 14F);
            this.radioMale.Location = new System.Drawing.Point(3, 6);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(70, 27);
            this.radioMale.TabIndex = 0;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Font = new System.Drawing.Font("Microsoft Tai Le", 14F);
            this.radioFemale.Location = new System.Drawing.Point(75, 6);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(88, 27);
            this.radioFemale.TabIndex = 2;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // comboIssuingCountry
            // 
            this.comboIssuingCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.comboIssuingCountry.FormattingEnabled = true;
            this.comboIssuingCountry.Location = new System.Drawing.Point(187, 493);
            this.comboIssuingCountry.Name = "comboIssuingCountry";
            this.comboIssuingCountry.Size = new System.Drawing.Size(242, 33);
            this.comboIssuingCountry.TabIndex = 39;
            // 
            // lblIssuingCountry
            // 
            this.lblIssuingCountry.AutoSize = true;
            this.lblIssuingCountry.Font = new System.Drawing.Font("Microsoft Tai Le", 16F);
            this.lblIssuingCountry.Location = new System.Drawing.Point(14, 497);
            this.lblIssuingCountry.Name = "lblIssuingCountry";
            this.lblIssuingCountry.Size = new System.Drawing.Size(162, 29);
            this.lblIssuingCountry.TabIndex = 47;
            this.lblIssuingCountry.Text = "Issuing Country";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Tai Le", 16F);
            this.lblPhone.Location = new System.Drawing.Point(22, 539);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(156, 29);
            this.lblPhone.TabIndex = 46;
            this.lblPhone.Text = "Phone number";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtPhone.Location = new System.Drawing.Point(187, 535);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(242, 32);
            this.txtPhone.TabIndex = 40;
            // 
            // lblIssuingBody
            // 
            this.lblIssuingBody.AutoSize = true;
            this.lblIssuingBody.Font = new System.Drawing.Font("Microsoft Tai Le", 16F);
            this.lblIssuingBody.Location = new System.Drawing.Point(41, 460);
            this.lblIssuingBody.Name = "lblIssuingBody";
            this.lblIssuingBody.Size = new System.Drawing.Size(135, 29);
            this.lblIssuingBody.TabIndex = 45;
            this.lblIssuingBody.Text = "Issuing Body";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Tai Le", 16F);
            this.lblLastName.Location = new System.Drawing.Point(66, 164);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(110, 29);
            this.lblLastName.TabIndex = 44;
            this.lblLastName.Text = "Last name";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtLastName.Location = new System.Drawing.Point(187, 160);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(240, 32);
            this.txtLastName.TabIndex = 31;
            // 
            // lblDocumentType
            // 
            this.lblDocumentType.AutoSize = true;
            this.lblDocumentType.Font = new System.Drawing.Font("Microsoft Tai Le", 16F);
            this.lblDocumentType.Location = new System.Drawing.Point(17, 415);
            this.lblDocumentType.Name = "lblDocumentType";
            this.lblDocumentType.Size = new System.Drawing.Size(167, 29);
            this.lblDocumentType.TabIndex = 43;
            this.lblDocumentType.Text = "Document Type";
            // 
            // lblDocument
            // 
            this.lblDocument.AutoSize = true;
            this.lblDocument.Font = new System.Drawing.Font("Microsoft Tai Le", 16F);
            this.lblDocument.Location = new System.Drawing.Point(63, 376);
            this.lblDocument.Name = "lblDocument";
            this.lblDocument.Size = new System.Drawing.Size(113, 29);
            this.lblDocument.TabIndex = 42;
            this.lblDocument.Text = "Document";
            // 
            // txtDocument
            // 
            this.txtDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtDocument.Location = new System.Drawing.Point(187, 372);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(242, 32);
            this.txtDocument.TabIndex = 36;
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Font = new System.Drawing.Font("Microsoft Tai Le", 16F);
            this.lblOccupation.Location = new System.Drawing.Point(55, 334);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(123, 29);
            this.lblOccupation.TabIndex = 41;
            this.lblOccupation.Text = "Occupation";
            // 
            // comboNationality
            // 
            this.comboNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.comboNationality.FormattingEnabled = true;
            this.comboNationality.Location = new System.Drawing.Point(187, 292);
            this.comboNationality.Name = "comboNationality";
            this.comboNationality.Size = new System.Drawing.Size(240, 33);
            this.comboNationality.TabIndex = 35;
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Font = new System.Drawing.Font("Microsoft Tai Le", 16F);
            this.lblNationality.Location = new System.Drawing.Point(65, 294);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(116, 29);
            this.lblNationality.TabIndex = 38;
            this.lblNationality.Text = "Nationality";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 16F);
            this.lblEmail.Location = new System.Drawing.Point(112, 257);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(64, 29);
            this.lblEmail.TabIndex = 37;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtEmail.Location = new System.Drawing.Point(187, 253);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 32);
            this.txtEmail.TabIndex = 34;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Tai Le", 16F);
            this.lblFirstName.Location = new System.Drawing.Point(65, 121);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(113, 29);
            this.lblFirstName.TabIndex = 33;
            this.lblFirstName.Text = "First name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtFirstName.Location = new System.Drawing.Point(189, 117);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(240, 32);
            this.txtFirstName.TabIndex = 30;
            // 
            // GuestRegistrationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(502, 658);
            this.Controls.Add(this.comboIssuingBody);
            this.Controls.Add(this.comboDocumentType);
            this.Controls.Add(this.comboOccupation);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboIssuingCountry);
            this.Controls.Add(this.lblIssuingCountry);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblIssuingBody);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblDocumentType);
            this.Controls.Add(this.lblDocument);
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.lblOccupation);
            this.Controls.Add(this.comboNationality);
            this.Controls.Add(this.lblNationality);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GuestRegistrationFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Guest";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox comboIssuingBody;
        private System.Windows.Forms.ComboBox comboDocumentType;
        private System.Windows.Forms.ComboBox comboOccupation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.ComboBox comboIssuingCountry;
        private System.Windows.Forms.Label lblIssuingCountry;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblIssuingBody;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblDocumentType;
        private System.Windows.Forms.Label lblDocument;
        private System.Windows.Forms.TextBox txtDocument;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.ComboBox comboNationality;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
    }
}