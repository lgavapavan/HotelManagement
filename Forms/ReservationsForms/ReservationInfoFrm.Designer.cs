namespace HotelsPro2.Forms
{
    partial class ReservationInfoFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationInfoFrm));
            this.dgvGuests = new System.Windows.Forms.DataGridView();
            this.lblReservationInfo = new System.Windows.Forms.Label();
            this.dtpCheckin = new System.Windows.Forms.DateTimePicker();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCheckin = new System.Windows.Forms.Label();
            this.lblCheckout = new System.Windows.Forms.Label();
            this.dtpCheckout = new System.Windows.Forms.DateTimePicker();
            this.btnViewGuest = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.dgvApartments = new System.Windows.Forms.DataGridView();
            this.dgvProductsAndServices = new System.Windows.Forms.DataGridView();
            this.lblGuests = new System.Windows.Forms.Label();
            this.lblApartments = new System.Windows.Forms.Label();
            this.lblProductsAndServices = new System.Windows.Forms.Label();
            this.btnPaymentStatus = new System.Windows.Forms.Button();
            this.lblAdults = new System.Windows.Forms.Label();
            this.lblKids = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblMomentOfReservation = new System.Windows.Forms.Label();
            this.dtpMomentOfReservation = new System.Windows.Forms.DateTimePicker();
            this.btnHousekeeper = new System.Windows.Forms.Button();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.btnRemoveGuest = new System.Windows.Forms.Button();
            this.lblReservedApartments = new System.Windows.Forms.Label();
            this.btnDeleteReservation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsAndServices)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGuests
            // 
            this.dgvGuests.AllowUserToAddRows = false;
            this.dgvGuests.AllowUserToDeleteRows = false;
            this.dgvGuests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
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
            this.dgvGuests.Location = new System.Drawing.Point(353, 96);
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
            this.dgvGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuests.Size = new System.Drawing.Size(628, 125);
            this.dgvGuests.TabIndex = 59;
            // 
            // lblReservationInfo
            // 
            this.lblReservationInfo.AutoSize = true;
            this.lblReservationInfo.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationInfo.Location = new System.Drawing.Point(445, 9);
            this.lblReservationInfo.Name = "lblReservationInfo";
            this.lblReservationInfo.Size = new System.Drawing.Size(287, 40);
            this.lblReservationInfo.TabIndex = 56;
            this.lblReservationInfo.Text = "Reservation Details";
            // 
            // dtpCheckin
            // 
            this.dtpCheckin.Enabled = false;
            this.dtpCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckin.Location = new System.Drawing.Point(142, 138);
            this.dtpCheckin.Name = "dtpCheckin";
            this.dtpCheckin.Size = new System.Drawing.Size(138, 29);
            this.dtpCheckin.TabIndex = 60;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 16F);
            this.lblTotal.Location = new System.Drawing.Point(353, 612);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(66, 29);
            this.lblTotal.TabIndex = 61;
            this.lblTotal.Text = "Total:";
            // 
            // lblCheckin
            // 
            this.lblCheckin.AutoSize = true;
            this.lblCheckin.Font = new System.Drawing.Font("Microsoft Tai Le", 16F);
            this.lblCheckin.Location = new System.Drawing.Point(38, 138);
            this.lblCheckin.Name = "lblCheckin";
            this.lblCheckin.Size = new System.Drawing.Size(99, 29);
            this.lblCheckin.TabIndex = 62;
            this.lblCheckin.Text = "Check-In";
            // 
            // lblCheckout
            // 
            this.lblCheckout.AutoSize = true;
            this.lblCheckout.Font = new System.Drawing.Font("Microsoft Tai Le", 16F);
            this.lblCheckout.Location = new System.Drawing.Point(23, 182);
            this.lblCheckout.Name = "lblCheckout";
            this.lblCheckout.Size = new System.Drawing.Size(117, 29);
            this.lblCheckout.TabIndex = 64;
            this.lblCheckout.Text = "Check-Out";
            // 
            // dtpCheckout
            // 
            this.dtpCheckout.Enabled = false;
            this.dtpCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckout.Location = new System.Drawing.Point(142, 182);
            this.dtpCheckout.Name = "dtpCheckout";
            this.dtpCheckout.Size = new System.Drawing.Size(138, 29);
            this.dtpCheckout.TabIndex = 63;
            // 
            // btnViewGuest
            // 
            this.btnViewGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnViewGuest.Location = new System.Drawing.Point(353, 227);
            this.btnViewGuest.Name = "btnViewGuest";
            this.btnViewGuest.Size = new System.Drawing.Size(195, 34);
            this.btnViewGuest.TabIndex = 65;
            this.btnViewGuest.Text = "View Guest";
            this.btnViewGuest.UseVisualStyleBackColor = true;
            this.btnViewGuest.Click += new System.EventHandler(this.btnViewGuest_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnInvoice.Location = new System.Drawing.Point(1057, 147);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(195, 34);
            this.btnInvoice.TabIndex = 66;
            this.btnInvoice.Text = "View Invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            // 
            // dgvApartments
            // 
            this.dgvApartments.AllowUserToAddRows = false;
            this.dgvApartments.AllowUserToDeleteRows = false;
            this.dgvApartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApartments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvApartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvApartments.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvApartments.Location = new System.Drawing.Point(353, 304);
            this.dgvApartments.Name = "dgvApartments";
            this.dgvApartments.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApartments.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvApartments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvApartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApartments.Size = new System.Drawing.Size(628, 125);
            this.dgvApartments.TabIndex = 67;
            // 
            // dgvProductsAndServices
            // 
            this.dgvProductsAndServices.AllowUserToAddRows = false;
            this.dgvProductsAndServices.AllowUserToDeleteRows = false;
            this.dgvProductsAndServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductsAndServices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductsAndServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProductsAndServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductsAndServices.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProductsAndServices.Location = new System.Drawing.Point(353, 477);
            this.dgvProductsAndServices.Name = "dgvProductsAndServices";
            this.dgvProductsAndServices.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductsAndServices.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProductsAndServices.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvProductsAndServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductsAndServices.Size = new System.Drawing.Size(899, 125);
            this.dgvProductsAndServices.TabIndex = 68;
            // 
            // lblGuests
            // 
            this.lblGuests.AutoSize = true;
            this.lblGuests.Font = new System.Drawing.Font("Microsoft Tai Le", 16F);
            this.lblGuests.Location = new System.Drawing.Point(353, 64);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(77, 29);
            this.lblGuests.TabIndex = 69;
            this.lblGuests.Text = "Guests";
            // 
            // lblApartments
            // 
            this.lblApartments.AutoSize = true;
            this.lblApartments.Font = new System.Drawing.Font("Microsoft Tai Le", 16F);
            this.lblApartments.Location = new System.Drawing.Point(353, 272);
            this.lblApartments.Name = "lblApartments";
            this.lblApartments.Size = new System.Drawing.Size(125, 29);
            this.lblApartments.TabIndex = 70;
            this.lblApartments.Text = "Apartments";
            // 
            // lblProductsAndServices
            // 
            this.lblProductsAndServices.AutoSize = true;
            this.lblProductsAndServices.Font = new System.Drawing.Font("Microsoft Tai Le", 16F);
            this.lblProductsAndServices.Location = new System.Drawing.Point(353, 445);
            this.lblProductsAndServices.Name = "lblProductsAndServices";
            this.lblProductsAndServices.Size = new System.Drawing.Size(224, 29);
            this.lblProductsAndServices.TabIndex = 71;
            this.lblProductsAndServices.Text = "Products and Services";
            // 
            // btnPaymentStatus
            // 
            this.btnPaymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPaymentStatus.Location = new System.Drawing.Point(1057, 198);
            this.btnPaymentStatus.Name = "btnPaymentStatus";
            this.btnPaymentStatus.Size = new System.Drawing.Size(195, 34);
            this.btnPaymentStatus.TabIndex = 77;
            this.btnPaymentStatus.Text = "Payment Status";
            this.btnPaymentStatus.UseVisualStyleBackColor = true;
            // 
            // lblAdults
            // 
            this.lblAdults.AutoSize = true;
            this.lblAdults.Font = new System.Drawing.Font("Microsoft Tai Le", 16F);
            this.lblAdults.Location = new System.Drawing.Point(63, 317);
            this.lblAdults.Name = "lblAdults";
            this.lblAdults.Size = new System.Drawing.Size(73, 29);
            this.lblAdults.TabIndex = 78;
            this.lblAdults.Text = "Adults";
            // 
            // lblKids
            // 
            this.lblKids.AutoSize = true;
            this.lblKids.Font = new System.Drawing.Font("Microsoft Tai Le", 16F);
            this.lblKids.Location = new System.Drawing.Point(83, 363);
            this.lblKids.Name = "lblKids";
            this.lblKids.Size = new System.Drawing.Size(53, 29);
            this.lblKids.TabIndex = 80;
            this.lblKids.Text = "Kids";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Tai Le", 16F);
            this.lblDuration.Location = new System.Drawing.Point(40, 234);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(96, 29);
            this.lblDuration.TabIndex = 82;
            this.lblDuration.Text = "Duration";
            // 
            // lblMomentOfReservation
            // 
            this.lblMomentOfReservation.AutoSize = true;
            this.lblMomentOfReservation.Font = new System.Drawing.Font("Microsoft Tai Le", 16F);
            this.lblMomentOfReservation.Location = new System.Drawing.Point(44, 96);
            this.lblMomentOfReservation.Name = "lblMomentOfReservation";
            this.lblMomentOfReservation.Size = new System.Drawing.Size(92, 29);
            this.lblMomentOfReservation.TabIndex = 89;
            this.lblMomentOfReservation.Text = "Made in";
            // 
            // dtpMomentOfReservation
            // 
            this.dtpMomentOfReservation.Enabled = false;
            this.dtpMomentOfReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpMomentOfReservation.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMomentOfReservation.Location = new System.Drawing.Point(142, 96);
            this.dtpMomentOfReservation.Name = "dtpMomentOfReservation";
            this.dtpMomentOfReservation.Size = new System.Drawing.Size(138, 29);
            this.dtpMomentOfReservation.TabIndex = 88;
            // 
            // btnHousekeeper
            // 
            this.btnHousekeeper.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnHousekeeper.Location = new System.Drawing.Point(1057, 96);
            this.btnHousekeeper.Name = "btnHousekeeper";
            this.btnHousekeeper.Size = new System.Drawing.Size(195, 34);
            this.btnHousekeeper.TabIndex = 90;
            this.btnHousekeeper.Text = "Housekeeping";
            this.btnHousekeeper.UseVisualStyleBackColor = true;
            // 
            // btnCheckin
            // 
            this.btnCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCheckin.Location = new System.Drawing.Point(1057, 248);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(195, 34);
            this.btnCheckin.TabIndex = 91;
            this.btnCheckin.Text = "Check-In";
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCheckout.Location = new System.Drawing.Point(1057, 296);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(195, 34);
            this.btnCheckout.TabIndex = 92;
            this.btnCheckout.Text = "Check-Out";
            this.btnCheckout.UseVisualStyleBackColor = true;
            // 
            // btnAddGuest
            // 
            this.btnAddGuest.Enabled = false;
            this.btnAddGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAddGuest.Location = new System.Drawing.Point(554, 227);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(195, 34);
            this.btnAddGuest.TabIndex = 93;
            this.btnAddGuest.Text = "Add Guest";
            this.btnAddGuest.UseVisualStyleBackColor = true;
            this.btnAddGuest.Click += new System.EventHandler(this.btnAddGuest_Click);
            // 
            // btnRemoveGuest
            // 
            this.btnRemoveGuest.Enabled = false;
            this.btnRemoveGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnRemoveGuest.Location = new System.Drawing.Point(755, 227);
            this.btnRemoveGuest.Name = "btnRemoveGuest";
            this.btnRemoveGuest.Size = new System.Drawing.Size(195, 34);
            this.btnRemoveGuest.TabIndex = 94;
            this.btnRemoveGuest.Text = "Remove Guest";
            this.btnRemoveGuest.UseVisualStyleBackColor = true;
            this.btnRemoveGuest.Click += new System.EventHandler(this.btnRemoveGuest_Click);
            // 
            // lblReservedApartments
            // 
            this.lblReservedApartments.AutoSize = true;
            this.lblReservedApartments.Font = new System.Drawing.Font("Microsoft Tai Le", 16F);
            this.lblReservedApartments.Location = new System.Drawing.Point(11, 274);
            this.lblReservedApartments.Name = "lblReservedApartments";
            this.lblReservedApartments.Size = new System.Drawing.Size(125, 29);
            this.lblReservedApartments.TabIndex = 95;
            this.lblReservedApartments.Text = "Apartments";
            // 
            // btnDeleteReservation
            // 
            this.btnDeleteReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDeleteReservation.Location = new System.Drawing.Point(1057, 344);
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.btnDeleteReservation.Size = new System.Drawing.Size(195, 34);
            this.btnDeleteReservation.TabIndex = 96;
            this.btnDeleteReservation.Text = "Delete Reservation";
            this.btnDeleteReservation.UseVisualStyleBackColor = true;
            this.btnDeleteReservation.Click += new System.EventHandler(this.btnDeleteReservation_Click);
            // 
            // ReservationInfoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1322, 669);
            this.Controls.Add(this.btnDeleteReservation);
            this.Controls.Add(this.lblReservedApartments);
            this.Controls.Add(this.btnRemoveGuest);
            this.Controls.Add(this.btnAddGuest);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnCheckin);
            this.Controls.Add(this.btnHousekeeper);
            this.Controls.Add(this.lblMomentOfReservation);
            this.Controls.Add(this.dtpMomentOfReservation);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblKids);
            this.Controls.Add(this.lblAdults);
            this.Controls.Add(this.btnPaymentStatus);
            this.Controls.Add(this.lblProductsAndServices);
            this.Controls.Add(this.lblApartments);
            this.Controls.Add(this.lblGuests);
            this.Controls.Add(this.dgvProductsAndServices);
            this.Controls.Add(this.dgvApartments);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.btnViewGuest);
            this.Controls.Add(this.lblCheckout);
            this.Controls.Add(this.dtpCheckout);
            this.Controls.Add(this.lblCheckin);
            this.Controls.Add(this.dtpCheckin);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvGuests);
            this.Controls.Add(this.lblReservationInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReservationInfoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation Info";
            this.Load += new System.EventHandler(this.ReservationInfoFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsAndServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGuests;
        private System.Windows.Forms.Label lblReservationInfo;
        private System.Windows.Forms.DateTimePicker dtpCheckin;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCheckin;
        private System.Windows.Forms.Label lblCheckout;
        private System.Windows.Forms.DateTimePicker dtpCheckout;
        private System.Windows.Forms.Button btnViewGuest;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.DataGridView dgvApartments;
        private System.Windows.Forms.DataGridView dgvProductsAndServices;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.Label lblApartments;
        private System.Windows.Forms.Label lblProductsAndServices;
        private System.Windows.Forms.Button btnPaymentStatus;
        private System.Windows.Forms.Label lblAdults;
        private System.Windows.Forms.Label lblKids;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblMomentOfReservation;
        private System.Windows.Forms.DateTimePicker dtpMomentOfReservation;
        private System.Windows.Forms.Button btnHousekeeper;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnAddGuest;
        private System.Windows.Forms.Button btnRemoveGuest;
        private System.Windows.Forms.Label lblReservedApartments;
        private System.Windows.Forms.Button btnDeleteReservation;
    }
}