namespace HotelsPro2.Forms
{
    partial class CalendarFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarFrm));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCalendar = new System.Windows.Forms.Label();
            this.lblGuestStay = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.lblCheckIns = new System.Windows.Forms.Label();
            this.lblCheckOuts = new System.Windows.Forms.Label();
            this.btnGuestInfo = new System.Windows.Forms.Button();
            this.btnReservationInfo = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.monthCalendar1.Location = new System.Drawing.Point(69, 71);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblCalendar
            // 
            this.lblCalendar.AutoSize = true;
            this.lblCalendar.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendar.Location = new System.Drawing.Point(346, 22);
            this.lblCalendar.Name = "lblCalendar";
            this.lblCalendar.Size = new System.Drawing.Size(142, 40);
            this.lblCalendar.TabIndex = 19;
            this.lblCalendar.Text = "Calendar";
            // 
            // lblGuestStay
            // 
            this.lblGuestStay.AutoSize = true;
            this.lblGuestStay.Font = new System.Drawing.Font("Microsoft Tai Le", 13F);
            this.lblGuestStay.Location = new System.Drawing.Point(79, 248);
            this.lblGuestStay.Name = "lblGuestStay";
            this.lblGuestStay.Size = new System.Drawing.Size(125, 23);
            this.lblGuestStay.TabIndex = 20;
            this.lblGuestStay.Text = "Guests staying";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(302, 274);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 21;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(578, 274);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 22;
            // 
            // lblCheckIns
            // 
            this.lblCheckIns.AutoSize = true;
            this.lblCheckIns.Font = new System.Drawing.Font("Microsoft Tai Le", 13F);
            this.lblCheckIns.Location = new System.Drawing.Point(376, 248);
            this.lblCheckIns.Name = "lblCheckIns";
            this.lblCheckIns.Size = new System.Drawing.Size(86, 23);
            this.lblCheckIns.TabIndex = 23;
            this.lblCheckIns.Text = "Check-ins";
            // 
            // lblCheckOuts
            // 
            this.lblCheckOuts.AutoSize = true;
            this.lblCheckOuts.Font = new System.Drawing.Font("Microsoft Tai Le", 13F);
            this.lblCheckOuts.Location = new System.Drawing.Point(650, 248);
            this.lblCheckOuts.Name = "lblCheckOuts";
            this.lblCheckOuts.Size = new System.Drawing.Size(99, 23);
            this.lblCheckOuts.TabIndex = 24;
            this.lblCheckOuts.Text = "Check-outs";
            // 
            // btnGuestInfo
            // 
            this.btnGuestInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnGuestInfo.Location = new System.Drawing.Point(69, 451);
            this.btnGuestInfo.Name = "btnGuestInfo";
            this.btnGuestInfo.Size = new System.Drawing.Size(152, 45);
            this.btnGuestInfo.TabIndex = 25;
            this.btnGuestInfo.Text = "Guest Info";
            this.btnGuestInfo.UseVisualStyleBackColor = true;
            // 
            // btnReservationInfo
            // 
            this.btnReservationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnReservationInfo.Location = new System.Drawing.Point(618, 451);
            this.btnReservationInfo.Name = "btnReservationInfo";
            this.btnReservationInfo.Size = new System.Drawing.Size(152, 45);
            this.btnReservationInfo.TabIndex = 26;
            this.btnReservationInfo.Text = "Reservation Info";
            this.btnReservationInfo.UseVisualStyleBackColor = true;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnCheckout.Location = new System.Drawing.Point(438, 451);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(152, 45);
            this.btnCheckout.TabIndex = 28;
            this.btnCheckout.Text = "Check-Out";
            this.btnCheckout.UseVisualStyleBackColor = true;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnCheckIn.Location = new System.Drawing.Point(252, 451);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(152, 45);
            this.btnCheckIn.TabIndex = 27;
            this.btnCheckIn.Text = "Check-In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // CalendarFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(863, 524);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnReservationInfo);
            this.Controls.Add(this.btnGuestInfo);
            this.Controls.Add(this.lblCheckOuts);
            this.Controls.Add(this.lblCheckIns);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lblGuestStay);
            this.Controls.Add(this.lblCalendar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalendarFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCalendar;
        private System.Windows.Forms.Label lblGuestStay;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label lblCheckIns;
        private System.Windows.Forms.Label lblCheckOuts;
        private System.Windows.Forms.Button btnGuestInfo;
        private System.Windows.Forms.Button btnReservationInfo;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnCheckIn;
    }
}