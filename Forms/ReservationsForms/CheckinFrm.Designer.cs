namespace HotelsPro2.Forms.ReservationsForms
{
    partial class CheckinFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSelectGuest = new System.Windows.Forms.Button();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.dgvGuests = new System.Windows.Forms.DataGridView();
            this.lblAddGuests = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtApartmentNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelectApartment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectGuest
            // 
            this.btnSelectGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSelectGuest.Location = new System.Drawing.Point(16, 117);
            this.btnSelectGuest.Name = "btnSelectGuest";
            this.btnSelectGuest.Size = new System.Drawing.Size(121, 37);
            this.btnSelectGuest.TabIndex = 94;
            this.btnSelectGuest.Text = "Select Guest";
            this.btnSelectGuest.UseVisualStyleBackColor = true;
            this.btnSelectGuest.Click += new System.EventHandler(this.btnSelectGuest_Click);
            // 
            // txtGuestName
            // 
            this.txtGuestName.Enabled = false;
            this.txtGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F);
            this.txtGuestName.Location = new System.Drawing.Point(23, 340);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(196, 31);
            this.txtGuestName.TabIndex = 93;
            // 
            // dgvGuests
            // 
            this.dgvGuests.AllowUserToDeleteRows = false;
            this.dgvGuests.AllowUserToResizeColumns = false;
            this.dgvGuests.AllowUserToResizeRows = false;
            this.dgvGuests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGuests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGuests.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGuests.Location = new System.Drawing.Point(12, 178);
            this.dgvGuests.MultiSelect = false;
            this.dgvGuests.Name = "dgvGuests";
            this.dgvGuests.ReadOnly = true;
            this.dgvGuests.RowTemplate.Height = 30;
            this.dgvGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuests.Size = new System.Drawing.Size(977, 127);
            this.dgvGuests.TabIndex = 91;
            // 
            // lblAddGuests
            // 
            this.lblAddGuests.AutoSize = true;
            this.lblAddGuests.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddGuests.Location = new System.Drawing.Point(306, 14);
            this.lblAddGuests.Name = "lblAddGuests";
            this.lblAddGuests.Size = new System.Drawing.Size(387, 40);
            this.lblAddGuests.TabIndex = 97;
            this.lblAddGuests.Text = "Add Guests To Apartment";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSave.Location = new System.Drawing.Point(352, 336);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 37);
            this.btnSave.TabIndex = 98;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 13.25F);
            this.label3.Location = new System.Drawing.Point(23, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 96;
            this.label3.Text = "Guest\'s name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.25F);
            this.label1.Location = new System.Drawing.Point(226, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 99;
            this.label1.Text = "Apartment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.25F);
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 23);
            this.label2.TabIndex = 100;
            this.label2.Text = "Guest already registered?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 13.25F);
            this.label4.Location = new System.Drawing.Point(282, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 23);
            this.label4.TabIndex = 102;
            this.label4.Text = "Guest not registered yet?";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button2.Location = new System.Drawing.Point(286, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 37);
            this.button2.TabIndex = 101;
            this.button2.Text = "New Guest";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSaveChanges.Location = new System.Drawing.Point(407, 414);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(208, 37);
            this.btnSaveChanges.TabIndex = 103;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // txtApartmentNumber
            // 
            this.txtApartmentNumber.Enabled = false;
            this.txtApartmentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F);
            this.txtApartmentNumber.Location = new System.Drawing.Point(225, 340);
            this.txtApartmentNumber.Name = "txtApartmentNumber";
            this.txtApartmentNumber.Size = new System.Drawing.Size(121, 31);
            this.txtApartmentNumber.TabIndex = 104;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 13.25F);
            this.label5.Location = new System.Drawing.Point(566, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 23);
            this.label5.TabIndex = 106;
            this.label5.Text = "Choose an apartment for this guest";
            // 
            // btnSelectApartment
            // 
            this.btnSelectApartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSelectApartment.Location = new System.Drawing.Point(570, 117);
            this.btnSelectApartment.Name = "btnSelectApartment";
            this.btnSelectApartment.Size = new System.Drawing.Size(156, 37);
            this.btnSelectApartment.TabIndex = 105;
            this.btnSelectApartment.Text = "Select Apartment";
            this.btnSelectApartment.UseVisualStyleBackColor = true;
            this.btnSelectApartment.Click += new System.EventHandler(this.btnSelectApartment_Click);
            // 
            // CheckinFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1001, 463);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSelectApartment);
            this.Controls.Add(this.txtApartmentNumber);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAddGuests);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelectGuest);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.dgvGuests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CheckinFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckinFrm";
            this.Load += new System.EventHandler(this.CheckinFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelectGuest;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.DataGridView dgvGuests;
        private System.Windows.Forms.Label lblAddGuests;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtApartmentNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelectApartment;
    }
}