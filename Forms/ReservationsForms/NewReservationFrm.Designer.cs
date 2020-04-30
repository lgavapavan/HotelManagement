namespace HotelsPro2.Forms
{
    partial class NewReservationFrm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewReservationFrm));
            this.lblNewReservation = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnSelectGuest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCheckout = new System.Windows.Forms.Label();
            this.dtpCheckout = new System.Windows.Forms.DateTimePicker();
            this.lblKids = new System.Windows.Forms.Label();
            this.lblAdults = new System.Windows.Forms.Label();
            this.nudKids = new System.Windows.Forms.NumericUpDown();
            this.nudAdults = new System.Windows.Forms.NumericUpDown();
            this.dtpCheckin = new System.Windows.Forms.DateTimePicker();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCheckin = new System.Windows.Forms.Label();
            this.lblApartments = new System.Windows.Forms.Label();
            this.nudApartments = new System.Windows.Forms.NumericUpDown();
            this.btnAvailability = new System.Windows.Forms.Button();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.category_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartments_available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAvailableCategories = new System.Windows.Forms.Label();
            this.btnNewGuest = new System.Windows.Forms.Button();
            this.lblSelectedApartments = new System.Windows.Forms.Label();
            this.dgvSelectedApartments = new System.Windows.Forms.DataGridView();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.picRemove = new System.Windows.Forms.PictureBox();
            this.hotel_adminDataSet = new HotelsPro2.hotel_adminDataSet();
            this.apartmentcategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartment_categoriesTableAdapter = new HotelsPro2.hotel_adminDataSetTableAdapters.apartment_categoriesTableAdapter();
            this.btnChangeDates = new System.Windows.Forms.Button();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.lblCategoriesToChoose = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGuestId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudKids)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudApartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedApartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_adminDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentcategoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewReservation
            // 
            this.lblNewReservation.AutoSize = true;
            this.lblNewReservation.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewReservation.Location = new System.Drawing.Point(483, 15);
            this.lblNewReservation.Name = "lblNewReservation";
            this.lblNewReservation.Size = new System.Drawing.Size(255, 40);
            this.lblNewReservation.TabIndex = 34;
            this.lblNewReservation.Text = "New Reservation";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSubmit.Location = new System.Drawing.Point(364, 609);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(203, 39);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnSelectGuest
            // 
            this.btnSelectGuest.Enabled = false;
            this.btnSelectGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSelectGuest.Location = new System.Drawing.Point(257, 423);
            this.btnSelectGuest.Name = "btnSelectGuest";
            this.btnSelectGuest.Size = new System.Drawing.Size(203, 39);
            this.btnSelectGuest.TabIndex = 8;
            this.btnSelectGuest.Text = "Select Guest";
            this.btnSelectGuest.UseVisualStyleBackColor = true;
            this.btnSelectGuest.Click += new System.EventHandler(this.btnSelectGuest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.25F);
            this.label1.Location = new System.Drawing.Point(300, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 71;
            this.label1.Text = "Guest Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(419, 536);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(387, 26);
            this.txtEmail.TabIndex = 70;
            // 
            // lblCheckout
            // 
            this.lblCheckout.AutoSize = true;
            this.lblCheckout.Font = new System.Drawing.Font("Microsoft Tai Le", 13.25F);
            this.lblCheckout.Location = new System.Drawing.Point(255, 97);
            this.lblCheckout.Name = "lblCheckout";
            this.lblCheckout.Size = new System.Drawing.Size(89, 23);
            this.lblCheckout.TabIndex = 69;
            this.lblCheckout.Text = "Check out";
            // 
            // dtpCheckout
            // 
            this.dtpCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckout.Location = new System.Drawing.Point(350, 97);
            this.dtpCheckout.Name = "dtpCheckout";
            this.dtpCheckout.Size = new System.Drawing.Size(121, 26);
            this.dtpCheckout.TabIndex = 1;
            this.dtpCheckout.ValueChanged += new System.EventHandler(this.dtpCheckout_ValueChanged);
            // 
            // lblKids
            // 
            this.lblKids.AutoSize = true;
            this.lblKids.Font = new System.Drawing.Font("Microsoft Tai Le", 13.25F);
            this.lblKids.Location = new System.Drawing.Point(1058, 96);
            this.lblKids.Name = "lblKids";
            this.lblKids.Size = new System.Drawing.Size(43, 23);
            this.lblKids.TabIndex = 67;
            this.lblKids.Text = "Kids";
            // 
            // lblAdults
            // 
            this.lblAdults.AutoSize = true;
            this.lblAdults.Font = new System.Drawing.Font("Microsoft Tai Le", 13.25F);
            this.lblAdults.Location = new System.Drawing.Point(912, 97);
            this.lblAdults.Name = "lblAdults";
            this.lblAdults.Size = new System.Drawing.Size(61, 23);
            this.lblAdults.TabIndex = 66;
            this.lblAdults.Text = "Adults";
            // 
            // nudKids
            // 
            this.nudKids.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nudKids.Location = new System.Drawing.Point(1107, 95);
            this.nudKids.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudKids.Name = "nudKids";
            this.nudKids.Size = new System.Drawing.Size(38, 26);
            this.nudKids.TabIndex = 4;
            // 
            // nudAdults
            // 
            this.nudAdults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nudAdults.Location = new System.Drawing.Point(979, 96);
            this.nudAdults.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudAdults.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdults.Name = "nudAdults";
            this.nudAdults.Size = new System.Drawing.Size(38, 26);
            this.nudAdults.TabIndex = 3;
            this.nudAdults.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpCheckin
            // 
            this.dtpCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckin.Location = new System.Drawing.Point(107, 97);
            this.dtpCheckin.Name = "dtpCheckin";
            this.dtpCheckin.Size = new System.Drawing.Size(121, 26);
            this.dtpCheckin.TabIndex = 0;
            this.dtpCheckin.ValueChanged += new System.EventHandler(this.dtpCheckin_ValueChanged);
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Font = new System.Drawing.Font("Microsoft Tai Le", 13.25F);
            this.lblGuestName.Location = new System.Drawing.Point(300, 504);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(107, 23);
            this.lblGuestName.TabIndex = 62;
            this.lblGuestName.Text = "Guest Name";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(419, 501);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(387, 26);
            this.txtName.TabIndex = 61;
            // 
            // lblCheckin
            // 
            this.lblCheckin.AutoSize = true;
            this.lblCheckin.Font = new System.Drawing.Font("Microsoft Tai Le", 13.25F);
            this.lblCheckin.Location = new System.Drawing.Point(25, 97);
            this.lblCheckin.Name = "lblCheckin";
            this.lblCheckin.Size = new System.Drawing.Size(76, 23);
            this.lblCheckin.TabIndex = 60;
            this.lblCheckin.Text = "Check in";
            // 
            // lblApartments
            // 
            this.lblApartments.AutoSize = true;
            this.lblApartments.Font = new System.Drawing.Font("Microsoft Tai Le", 13.25F);
            this.lblApartments.Location = new System.Drawing.Point(725, 97);
            this.lblApartments.Name = "lblApartments";
            this.lblApartments.Size = new System.Drawing.Size(103, 23);
            this.lblApartments.TabIndex = 73;
            this.lblApartments.Text = "Apartments";
            // 
            // nudApartments
            // 
            this.nudApartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nudApartments.Location = new System.Drawing.Point(834, 96);
            this.nudApartments.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudApartments.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudApartments.Name = "nudApartments";
            this.nudApartments.Size = new System.Drawing.Size(38, 26);
            this.nudApartments.TabIndex = 2;
            this.nudApartments.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAvailability
            // 
            this.btnAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnAvailability.Location = new System.Drawing.Point(476, 168);
            this.btnAvailability.Name = "btnAvailability";
            this.btnAvailability.Size = new System.Drawing.Size(203, 39);
            this.btnAvailability.TabIndex = 5;
            this.btnAvailability.Text = "Check Availability";
            this.btnAvailability.UseVisualStyleBackColor = true;
            this.btnAvailability.Click += new System.EventHandler(this.btnAvailability_Click);
            // 
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToDeleteRows = false;
            this.dgvCategories.AllowUserToResizeColumns = false;
            this.dgvCategories.AllowUserToResizeRows = false;
            this.dgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.category_id,
            this.category_name,
            this.apartments_available,
            this.total_price});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategories.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCategories.Location = new System.Drawing.Point(12, 281);
            this.dgvCategories.MultiSelect = false;
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.ReadOnly = true;
            this.dgvCategories.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCategories.RowTemplate.Height = 28;
            this.dgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategories.Size = new System.Drawing.Size(514, 114);
            this.dgvCategories.TabIndex = 6;
            // 
            // category_id
            // 
            this.category_id.HeaderText = "Category ID";
            this.category_id.Name = "category_id";
            this.category_id.ReadOnly = true;
            this.category_id.Visible = false;
            // 
            // category_name
            // 
            this.category_name.HeaderText = "Category";
            this.category_name.Name = "category_name";
            this.category_name.ReadOnly = true;
            // 
            // apartments_available
            // 
            this.apartments_available.HeaderText = "Apartments Available";
            this.apartments_available.Name = "apartments_available";
            this.apartments_available.ReadOnly = true;
            // 
            // total_price
            // 
            dataGridViewCellStyle7.Format = "C2";
            this.total_price.DefaultCellStyle = dataGridViewCellStyle7;
            this.total_price.HeaderText = "Total Price";
            this.total_price.Name = "total_price";
            this.total_price.ReadOnly = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnCancel.Location = new System.Drawing.Point(583, 609);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(203, 39);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAvailableCategories
            // 
            this.lblAvailableCategories.AutoSize = true;
            this.lblAvailableCategories.Font = new System.Drawing.Font("Microsoft Tai Le", 13.25F);
            this.lblAvailableCategories.Location = new System.Drawing.Point(12, 255);
            this.lblAvailableCategories.Name = "lblAvailableCategories";
            this.lblAvailableCategories.Size = new System.Drawing.Size(176, 23);
            this.lblAvailableCategories.TabIndex = 77;
            this.lblAvailableCategories.Text = "Categories available: ";
            // 
            // btnNewGuest
            // 
            this.btnNewGuest.Enabled = false;
            this.btnNewGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnNewGuest.Location = new System.Drawing.Point(476, 423);
            this.btnNewGuest.Name = "btnNewGuest";
            this.btnNewGuest.Size = new System.Drawing.Size(203, 39);
            this.btnNewGuest.TabIndex = 9;
            this.btnNewGuest.Text = "New Guest";
            this.btnNewGuest.UseVisualStyleBackColor = true;
            // 
            // lblSelectedApartments
            // 
            this.lblSelectedApartments.AutoSize = true;
            this.lblSelectedApartments.Font = new System.Drawing.Font("Microsoft Tai Le", 13.25F);
            this.lblSelectedApartments.Location = new System.Drawing.Point(631, 255);
            this.lblSelectedApartments.Name = "lblSelectedApartments";
            this.lblSelectedApartments.Size = new System.Drawing.Size(175, 23);
            this.lblSelectedApartments.TabIndex = 80;
            this.lblSelectedApartments.Text = "Selected apartments:";
            // 
            // dgvSelectedApartments
            // 
            this.dgvSelectedApartments.AllowUserToDeleteRows = false;
            this.dgvSelectedApartments.AllowUserToResizeColumns = false;
            this.dgvSelectedApartments.AllowUserToResizeRows = false;
            this.dgvSelectedApartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelectedApartments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSelectedApartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSelectedApartments.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSelectedApartments.Location = new System.Drawing.Point(635, 281);
            this.dgvSelectedApartments.MultiSelect = false;
            this.dgvSelectedApartments.Name = "dgvSelectedApartments";
            this.dgvSelectedApartments.ReadOnly = true;
            this.dgvSelectedApartments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSelectedApartments.RowTemplate.Height = 28;
            this.dgvSelectedApartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectedApartments.Size = new System.Drawing.Size(514, 114);
            this.dgvSelectedApartments.TabIndex = 7;
            // 
            // picAdd
            // 
            this.picAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAdd.Image = ((System.Drawing.Image)(resources.GetObject("picAdd.Image")));
            this.picAdd.Location = new System.Drawing.Point(566, 308);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(24, 24);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAdd.TabIndex = 81;
            this.picAdd.TabStop = false;
            this.picAdd.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // picRemove
            // 
            this.picRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRemove.Image = ((System.Drawing.Image)(resources.GetObject("picRemove.Image")));
            this.picRemove.Location = new System.Drawing.Point(566, 354);
            this.picRemove.Name = "picRemove";
            this.picRemove.Size = new System.Drawing.Size(24, 24);
            this.picRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRemove.TabIndex = 82;
            this.picRemove.TabStop = false;
            this.picRemove.Click += new System.EventHandler(this.picRemove_Click);
            // 
            // hotel_adminDataSet
            // 
            this.hotel_adminDataSet.DataSetName = "hotel_adminDataSet";
            this.hotel_adminDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // apartmentcategoriesBindingSource
            // 
            this.apartmentcategoriesBindingSource.DataMember = "apartment_categories";
            this.apartmentcategoriesBindingSource.DataSource = this.hotel_adminDataSet;
            // 
            // apartment_categoriesTableAdapter
            // 
            this.apartment_categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // btnChangeDates
            // 
            this.btnChangeDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnChangeDates.Location = new System.Drawing.Point(695, 423);
            this.btnChangeDates.Name = "btnChangeDates";
            this.btnChangeDates.Size = new System.Drawing.Size(203, 39);
            this.btnChangeDates.TabIndex = 10;
            this.btnChangeDates.Text = "Check Other Dates";
            this.btnChangeDates.UseVisualStyleBackColor = true;
            this.btnChangeDates.Click += new System.EventHandler(this.btnChangeDates_Click);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Tai Le", 13.25F);
            this.lblDuration.Location = new System.Drawing.Point(521, 98);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(132, 23);
            this.lblDuration.TabIndex = 85;
            this.lblDuration.Text = "Duration: 1 day";
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.lblAvailability.Location = new System.Drawing.Point(707, 180);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(66, 16);
            this.lblAvailability.TabIndex = 86;
            this.lblAvailability.Text = "Availability";
            this.lblAvailability.Visible = false;
            // 
            // lblCategoriesToChoose
            // 
            this.lblCategoriesToChoose.AutoSize = true;
            this.lblCategoriesToChoose.Font = new System.Drawing.Font("Microsoft Tai Le", 13.25F);
            this.lblCategoriesToChoose.Location = new System.Drawing.Point(568, 278);
            this.lblCategoriesToChoose.Name = "lblCategoriesToChoose";
            this.lblCategoriesToChoose.Size = new System.Drawing.Size(20, 23);
            this.lblCategoriesToChoose.TabIndex = 87;
            this.lblCategoriesToChoose.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.label2.Location = new System.Drawing.Point(540, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 36);
            this.label2.TabIndex = 88;
            this.label2.Text = "Apartments\r\nremaining";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGuestId
            // 
            this.txtGuestId.Enabled = false;
            this.txtGuestId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestId.Location = new System.Drawing.Point(822, 536);
            this.txtGuestId.Name = "txtGuestId";
            this.txtGuestId.Size = new System.Drawing.Size(50, 26);
            this.txtGuestId.TabIndex = 89;
            this.txtGuestId.Visible = false;
            // 
            // NewReservationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1163, 655);
            this.Controls.Add(this.txtGuestId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCategoriesToChoose);
            this.Controls.Add(this.lblAvailability);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.btnChangeDates);
            this.Controls.Add(this.picRemove);
            this.Controls.Add(this.picAdd);
            this.Controls.Add(this.lblSelectedApartments);
            this.Controls.Add(this.dgvSelectedApartments);
            this.Controls.Add(this.btnNewGuest);
            this.Controls.Add(this.lblAvailableCategories);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.btnAvailability);
            this.Controls.Add(this.lblApartments);
            this.Controls.Add(this.nudApartments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblCheckout);
            this.Controls.Add(this.dtpCheckout);
            this.Controls.Add(this.lblKids);
            this.Controls.Add(this.lblAdults);
            this.Controls.Add(this.nudKids);
            this.Controls.Add(this.nudAdults);
            this.Controls.Add(this.dtpCheckin);
            this.Controls.Add(this.lblGuestName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCheckin);
            this.Controls.Add(this.btnSelectGuest);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblNewReservation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewReservationFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Reservation";
            this.Load += new System.EventHandler(this.NewReservationFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudKids)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudApartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedApartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_adminDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentcategoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNewReservation;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnSelectGuest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCheckout;
        private System.Windows.Forms.DateTimePicker dtpCheckout;
        private System.Windows.Forms.Label lblKids;
        private System.Windows.Forms.Label lblAdults;
        private System.Windows.Forms.NumericUpDown nudKids;
        private System.Windows.Forms.NumericUpDown nudAdults;
        private System.Windows.Forms.DateTimePicker dtpCheckin;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCheckin;
        private System.Windows.Forms.Label lblApartments;
        private System.Windows.Forms.NumericUpDown nudApartments;
        private System.Windows.Forms.Button btnAvailability;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAvailableCategories;
        private System.Windows.Forms.Button btnNewGuest;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartments_available;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_price;
        private System.Windows.Forms.Label lblSelectedApartments;
        private System.Windows.Forms.DataGridView dgvSelectedApartments;
        private System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.PictureBox picRemove;
        private hotel_adminDataSet hotel_adminDataSet;
        private System.Windows.Forms.BindingSource apartmentcategoriesBindingSource;
        private hotel_adminDataSetTableAdapters.apartment_categoriesTableAdapter apartment_categoriesTableAdapter;
        private System.Windows.Forms.Button btnChangeDates;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Label lblCategoriesToChoose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGuestId;
    }
}