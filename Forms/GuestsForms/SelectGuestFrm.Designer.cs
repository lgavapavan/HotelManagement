namespace HotelsPro2.Forms
{
    partial class SelectGuestFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectGuestFrm));
            this.txtSearchGuest = new System.Windows.Forms.TextBox();
            this.btnSearchGuest = new System.Windows.Forms.Button();
            this.lblGuestList = new System.Windows.Forms.Label();
            this.btnSelectGuest = new System.Windows.Forms.Button();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.dgvGuests = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchGuest
            // 
            this.txtSearchGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtSearchGuest.Location = new System.Drawing.Point(146, 65);
            this.txtSearchGuest.Name = "txtSearchGuest";
            this.txtSearchGuest.Size = new System.Drawing.Size(477, 32);
            this.txtSearchGuest.TabIndex = 48;
            // 
            // btnSearchGuest
            // 
            this.btnSearchGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSearchGuest.Location = new System.Drawing.Point(629, 65);
            this.btnSearchGuest.Name = "btnSearchGuest";
            this.btnSearchGuest.Size = new System.Drawing.Size(161, 32);
            this.btnSearchGuest.TabIndex = 47;
            this.btnSearchGuest.Text = "Search Guest";
            this.btnSearchGuest.UseVisualStyleBackColor = true;
            this.btnSearchGuest.Click += new System.EventHandler(this.btnSearchGuest_Click);
            // 
            // lblGuestList
            // 
            this.lblGuestList.AutoSize = true;
            this.lblGuestList.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestList.Location = new System.Drawing.Point(434, 9);
            this.lblGuestList.Name = "lblGuestList";
            this.lblGuestList.Size = new System.Drawing.Size(156, 40);
            this.lblGuestList.TabIndex = 45;
            this.lblGuestList.Text = "Guest List";
            // 
            // btnSelectGuest
            // 
            this.btnSelectGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSelectGuest.Location = new System.Drawing.Point(429, 311);
            this.btnSelectGuest.Name = "btnSelectGuest";
            this.btnSelectGuest.Size = new System.Drawing.Size(161, 32);
            this.btnSelectGuest.TabIndex = 0;
            this.btnSelectGuest.Text = "Select Guest";
            this.btnSelectGuest.UseVisualStyleBackColor = true;
            this.btnSelectGuest.Click += new System.EventHandler(this.btnSelectGuest_Click);
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Font = new System.Drawing.Font("Microsoft Tai Le", 16F);
            this.lblGuestName.Location = new System.Drawing.Point(12, 65);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(128, 29);
            this.lblGuestName.TabIndex = 50;
            this.lblGuestName.Text = "Guest name";
            // 
            // dgvGuests
            // 
            this.dgvGuests.AllowUserToAddRows = false;
            this.dgvGuests.AllowUserToDeleteRows = false;
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
            this.dgvGuests.Location = new System.Drawing.Point(12, 109);
            this.dgvGuests.Name = "dgvGuests";
            this.dgvGuests.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGuests.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGuests.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvGuests.RowTemplate.Height = 30;
            this.dgvGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuests.Size = new System.Drawing.Size(994, 193);
            this.dgvGuests.TabIndex = 51;
            // 
            // SelectGuestFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 367);
            this.Controls.Add(this.dgvGuests);
            this.Controls.Add(this.lblGuestName);
            this.Controls.Add(this.btnSelectGuest);
            this.Controls.Add(this.txtSearchGuest);
            this.Controls.Add(this.btnSearchGuest);
            this.Controls.Add(this.lblGuestList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectGuestFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guest List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectGuestFrm_FormClosed);
            this.Load += new System.EventHandler(this.SelectGuestFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchGuest;
        private System.Windows.Forms.Button btnSearchGuest;
        private System.Windows.Forms.Label lblGuestList;
        private System.Windows.Forms.Button btnSelectGuest;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.DataGridView dgvGuests;
    }
}