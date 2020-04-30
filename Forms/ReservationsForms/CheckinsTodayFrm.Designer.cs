namespace HotelsPro2.Forms
{
    partial class CheckinsTodayFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckinsTodayFrm));
            this.dtpDateFilter = new System.Windows.Forms.DateTimePicker();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.lblCheckinsToday = new System.Windows.Forms.Label();
            this.btnFindByName = new System.Windows.Forms.Button();
            this.btnFindByDocument = new System.Windows.Forms.Button();
            this.txtFindByDocument = new System.Windows.Forms.TextBox();
            this.txtFindByName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelectReservation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDateFilter
            // 
            this.dtpDateFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.55F);
            this.dtpDateFilter.Location = new System.Drawing.Point(19, 111);
            this.dtpDateFilter.Name = "dtpDateFilter";
            this.dtpDateFilter.Size = new System.Drawing.Size(348, 26);
            this.dtpDateFilter.TabIndex = 0;
            this.dtpDateFilter.ValueChanged += new System.EventHandler(this.dtpDateFilter_ValueChanged);
            // 
            // dgvReservations
            // 
            this.dgvReservations.AllowUserToDeleteRows = false;
            this.dgvReservations.AllowUserToResizeColumns = false;
            this.dgvReservations.AllowUserToResizeRows = false;
            this.dgvReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservations.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReservations.Location = new System.Drawing.Point(12, 143);
            this.dgvReservations.MultiSelect = false;
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.ReadOnly = true;
            this.dgvReservations.RowTemplate.Height = 30;
            this.dgvReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservations.Size = new System.Drawing.Size(962, 169);
            this.dgvReservations.TabIndex = 1;
            // 
            // lblCheckinsToday
            // 
            this.lblCheckinsToday.AutoSize = true;
            this.lblCheckinsToday.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckinsToday.Location = new System.Drawing.Point(360, 9);
            this.lblCheckinsToday.Name = "lblCheckinsToday";
            this.lblCheckinsToday.Size = new System.Drawing.Size(251, 40);
            this.lblCheckinsToday.TabIndex = 35;
            this.lblCheckinsToday.Text = "Check-ins Today";
            // 
            // btnFindByName
            // 
            this.btnFindByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindByName.Location = new System.Drawing.Point(826, 107);
            this.btnFindByName.Name = "btnFindByName";
            this.btnFindByName.Size = new System.Drawing.Size(129, 30);
            this.btnFindByName.TabIndex = 46;
            this.btnFindByName.Text = "Filter by name";
            this.btnFindByName.UseVisualStyleBackColor = true;
            // 
            // btnFindByDocument
            // 
            this.btnFindByDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindByDocument.Location = new System.Drawing.Point(826, 71);
            this.btnFindByDocument.Name = "btnFindByDocument";
            this.btnFindByDocument.Size = new System.Drawing.Size(129, 30);
            this.btnFindByDocument.TabIndex = 63;
            this.btnFindByDocument.Text = "Filter by document";
            this.btnFindByDocument.UseVisualStyleBackColor = true;
            // 
            // txtFindByDocument
            // 
            this.txtFindByDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtFindByDocument.Location = new System.Drawing.Point(573, 72);
            this.txtFindByDocument.Name = "txtFindByDocument";
            this.txtFindByDocument.Size = new System.Drawing.Size(247, 29);
            this.txtFindByDocument.TabIndex = 64;
            // 
            // txtFindByName
            // 
            this.txtFindByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtFindByName.Location = new System.Drawing.Point(573, 108);
            this.txtFindByName.Name = "txtFindByName";
            this.txtFindByName.Size = new System.Drawing.Size(247, 29);
            this.txtFindByName.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 13.25F);
            this.label3.Location = new System.Drawing.Point(412, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 23);
            this.label3.TabIndex = 66;
            this.label3.Text = "Guest\'s document";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 13.25F);
            this.label4.Location = new System.Drawing.Point(449, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 67;
            this.label4.Text = "Guest\'s name";
            // 
            // btnSelectReservation
            // 
            this.btnSelectReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSelectReservation.Location = new System.Drawing.Point(386, 318);
            this.btnSelectReservation.Name = "btnSelectReservation";
            this.btnSelectReservation.Size = new System.Drawing.Size(169, 37);
            this.btnSelectReservation.TabIndex = 68;
            this.btnSelectReservation.Text = "Select Reservation";
            this.btnSelectReservation.UseVisualStyleBackColor = true;
            this.btnSelectReservation.Click += new System.EventHandler(this.btnSelectReservation_Click);
            // 
            // CheckinsTodayFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(986, 378);
            this.Controls.Add(this.btnSelectReservation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFindByName);
            this.Controls.Add(this.txtFindByDocument);
            this.Controls.Add(this.btnFindByDocument);
            this.Controls.Add(this.btnFindByName);
            this.Controls.Add(this.lblCheckinsToday);
            this.Controls.Add(this.dgvReservations);
            this.Controls.Add(this.dtpDateFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckinsTodayFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check-ins";
            this.Load += new System.EventHandler(this.CheckinFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateFilter;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.Label lblCheckinsToday;
        private System.Windows.Forms.Button btnFindByName;
        private System.Windows.Forms.Button btnFindByDocument;
        private System.Windows.Forms.TextBox txtFindByDocument;
        private System.Windows.Forms.TextBox txtFindByName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelectReservation;
    }
}