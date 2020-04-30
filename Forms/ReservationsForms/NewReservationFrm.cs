using HotelsPro2.Entities;
using HotelsPro2.Entities.Enums;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelsPro2.Forms
{
    public partial class NewReservationFrm : Form
    {
        // In this form the user will create new reservations
        public NewReservationFrm()
        {
            InitializeComponent();
            FormShrink();
            Globals.apartments.Clear();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public NewReservationFrm(DateTime cin, DateTime cout, short apartments, short kids, short adults)
        {
            InitializeComponent();
            FormShrink();
            LoadReservationInfo(cin, cout, apartments, kids, adults);
            
            if (CheckAvailability())
            {
                if (CheckForRoomCapacity())
                {
                    dgvCategories.Rows.Clear();
                    dgvSelectedApartments.Rows.Clear();
                    CheckCategoryAvailability();
                    DisableAllButtons();
                    FormGrow();
                }
            }
            LoadSelectedApartments();
            dgvSelectedApartments.Columns[0].Visible = false;
            dgvSelectedApartments.Columns[3].DefaultCellStyle.Format = "C2";
            
        }

        public NewReservationFrm(DateTime cin, DateTime cout, short apartments, short kids, short adults, Guest guest)
        {
            InitializeComponent();
            FormShrink();
            LoadReservationInfo(cin, cout, apartments, kids, adults);

            if (CheckAvailability())
            {
                if (CheckForRoomCapacity())
                {
                    dgvCategories.Rows.Clear();
                    dgvSelectedApartments.Rows.Clear();
                    CheckCategoryAvailability();
                    DisableAllButtons();
                    picAdd.Enabled = false;
                    picRemove.Enabled = false;
                    FormGrow2();
                }
            }
            LoadSelectedApartments();
            dgvSelectedApartments.Columns[0].Visible = false;
            dgvSelectedApartments.Columns[3].DefaultCellStyle.Format = "C2";
            txtName.Text = guest.FirstName + " " + guest.LastName;
            txtEmail.Text = guest.Email;
            txtGuestId.Text = guest.Id.ToString();
        }

        private void NewReservationFrm_Load(object sender, EventArgs e)
        {
            // This makes sure Check-out date will always be after Check-in, and the reservation will 
            // have at least 1 day
            dtpCheckin.MinDate = DateTime.Now;
            dtpCheckout.MinDate = dtpCheckin.Value.AddDays(1);
        }

        private void btnSelectGuest_Click(object sender, EventArgs e)
        {
            // Passes the parameters selected for the reservation to the "SelectGuestFrm", so when the user
            // chooses the guest, this form will receive these parameters back.
            var form = new SelectGuestFrm(dtpCheckin.Value.Date, dtpCheckout.Value.Date, (short)nudApartments.Value, (short)nudKids.Value, (short)nudAdults.Value);
            form.Show();
            this.Close();
        }

        private void btnAvailability_Click(object sender, EventArgs e)
        {
            var form = new NewReservationFrm(dtpCheckin.Value.Date, dtpCheckout.Value.Date, (short)nudApartments.Value, (short)nudKids.Value, (short)nudAdults.Value);
            form.Show();
            this.Close();
        }

        private bool CheckAvailability()
        {
            MySqlConnection con = new MySqlConnection(Globals.connString);

            //CheckForApartmentsAvailability
            try
            {
                int occupiedApartments = 0;
                int totalApartments = 0;
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("CheckForApartmentsAvailability", con);
                    cmd.Parameters.Add("_checkin", MySqlDbType.Date).Value = dtpCheckin.Value.Date;
                    cmd.Parameters.Add("_checkout", MySqlDbType.Date).Value = dtpCheckout.Value.Date;
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        occupiedApartments += reader.GetInt32(0);
                    }
                    con.Close();
                }
                catch (Exception)
                {
                    con.Close();
                    throw;
                }
                try
                {
                    con.Open();
                    MySqlCommand cmd2 = new MySqlCommand("SELECT COUNT(*) FROM apartments", con);
                    MySqlDataReader reader2 = cmd2.ExecuteReader();
                    while (reader2.Read())
                    {
                        totalApartments = reader2.GetInt32(0);
                    }
                    con.Close();
                }
                catch (Exception)
                {
                    con.Close();
                    throw;
                }

                if ((totalApartments - occupiedApartments) >= nudApartments.Value)
                {
                    Available(totalApartments - occupiedApartments);
                    return true;
                }
                else
                {
                    NotAvailable();
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool CheckForRoomCapacity()
        {
            MySqlConnection con = new MySqlConnection(Globals.connString);
            int hotelCapacity = 0;
            try
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("CheckForRoomCapacity", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        hotelCapacity += reader.GetInt32(0);
                    }
                    con.Close();
                }
                catch (Exception)
                {
                    con.Close();
                    throw;
                }
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("CheckForOccupiedCapacity", con);
                    cmd.Parameters.Add("_checkin", MySqlDbType.Date).Value = dtpCheckin.Value.Date;
                    cmd.Parameters.Add("_checkout", MySqlDbType.Date).Value = dtpCheckout.Value.Date;
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        hotelCapacity -= reader.GetInt32(0);
                    }
                    con.Close();
                }
                catch (Exception)
                {
                    con.Close();
                    throw;
                }
                
                
                if (hotelCapacity >= (nudAdults.Value + nudKids.Value))
                {
                    return true;
                }
                else
                {
                    NoRoomAvailable();
                    return false;
                }
            }
            catch (Exception)
            {
                con.Close();
                throw;
            }
        }

        private void CheckCategoryAvailability()
        {
            using (MySqlConnection con = new MySqlConnection(Globals.connString))
            {
                con.Open();
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT category_id," +
                        "title FROM apartment_categories", con))
                    {
                        using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                using (MySqlConnection con2 = new MySqlConnection(Globals.connString))
                                {
                                    con2.Open();
                                    using (MySqlCommand cmd2 = new MySqlCommand("SELECT COUNT(*) FROM apartments AS a " +
                                    "INNER JOIN apartment_categories AS ac " +
                                    "ON a.category_id = ac.category_id " +
                                    "WHERE a.category_id = @id ", con2))
                                    {
                                        cmd2.Parameters.Add("@id", MySqlDbType.Int32).Value = reader[0];
                                        using (MySqlDataReader reader2 = cmd2.ExecuteReader())
                                        {
                                            while (reader2.Read())
                                            {
                                                int totalApartments = int.Parse(reader2[0].ToString());
                                                using (MySqlConnection con3 = new MySqlConnection(Globals.connString))
                                                {
                                                    con3.Open();
                                                    using (MySqlCommand cmd3 = new MySqlCommand(
                                                    "SELECT COUNT(DISTINCT(ra.apartment_id)) " +
                                                    "FROM apartments AS a " +
                                                    "INNER JOIN _reservation_apartment AS ra " +
                                                    "ON a.apartment_id = ra.apartment_id " +
                                                    "INNER JOIN reservations AS r " +
                                                    "ON ra.reservation_id = r.reservation_id " +
                                                    "WHERE( " +
                                                    "(a.category_id = @id) AND " +
                                                    "((r.checkin <= @checkin AND r.checkout > @checkin) " +
                                                    "OR " +
                                                    "(r.checkin >= @checkin AND r.checkin <= @checkout) " +
                                                    "));", con3))
                                                    {
                                                        cmd3.Parameters.Add("@checkin", MySqlDbType.Date).Value = dtpCheckin.Value.Date;
                                                        cmd3.Parameters.Add("@checkout", MySqlDbType.Date).Value = dtpCheckout.Value.Date;
                                                        cmd3.Parameters.Add("@id", MySqlDbType.Int32).Value = reader[0];
                                                        MySqlDataReader reader3 = cmd3.ExecuteReader();
                                                        while (reader3.Read())
                                                        {
                                                            totalApartments -= int.Parse(reader3[0].ToString());
                                                        }
                                                        if (totalApartments >= 1)
                                                        {
                                                            using (MySqlConnection con4 = new MySqlConnection(Globals.connString))
                                                            {
                                                                con4.Open();
                                                                using (MySqlCommand cmd4 = new MySqlCommand("GetTotalPriceForStay", con4))
                                                                {
                                                                    cmd4.Parameters.Add("_checkin", MySqlDbType.Int32).Value = ConvertDateToNumber(dtpCheckin.Value.Date);
                                                                    cmd4.Parameters.Add("_checkout", MySqlDbType.Int32).Value = ConvertDateToNumber(dtpCheckout.Value.Date);
                                                                    cmd4.CommandType = CommandType.StoredProcedure;
                                                                    using (MySqlDataReader reader4 = cmd4.ExecuteReader())
                                                                    {
                                                                        while (reader4.Read())
                                                                        {
                                                                            DataGridViewRow row = (DataGridViewRow)dgvCategories.Rows[0].Clone();
                                                                            row.Cells[0].Value = reader[0];
                                                                            row.Cells[1].Value = reader[1];
                                                                            row.Cells[2].Value = totalApartments;
                                                                            if (int.Parse(reader[0].ToString()) == 1) //se categoria for standard_room
                                                                            {
                                                                                row.Cells[3].Value = reader4[0];
                                                                            }
                                                                            else if (int.Parse(reader[0].ToString()) == 2) //se categoria for standard_deluxe_room
                                                                            {
                                                                                row.Cells[3].Value = reader4[1];
                                                                            }
                                                                            dgvCategories.Rows.Add(row);
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {

                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void dtpCheckin_ValueChanged(object sender, EventArgs e)
        {
            dtpCheckout.MinDate = dtpCheckin.Value.AddDays(1);
            UpdateDurationLabel(dtpCheckin.Value.Date, dtpCheckout.Value.Date);
        }

        private int ConvertDateToNumber(DateTime date)
        {
            int days = 0;
            if (DateTime.IsLeapYear(date.Year))
            {
                switch (date.Month)
                {
                    case 1:
                        days += 0;
                        break;
                    case 2:
                        days += 31;
                        break;
                    case 3:
                        days = 60;
                        break;
                    case 4:
                        days = 91;
                        break;
                    case 5:
                        days = 121;
                        break;
                    case 6:
                        days = 152;
                        break;
                    case 7:
                        days = 182;
                        break;
                    case 8:
                        days = 213;
                        break;
                    case 9:
                        days = 244;
                        break;
                    case 10:
                        days = 274;
                        break;
                    case 11:
                        days = 305;
                        break;
                    case 12:
                        days = 335;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (date.Month)
                {
                    case 1:
                        days += 0;
                        break;
                    case 2:
                        days += 31;
                        break;
                    case 3:
                        days = 59;
                        break;
                    case 4:
                        days = 90;
                        break;
                    case 5:
                        days = 120;
                        break;
                    case 6:
                        days = 151;
                        break;
                    case 7:
                        days = 181;
                        break;
                    case 8:
                        days = 212;
                        break;
                    case 9:
                        days = 243;
                        break;
                    case 10:
                        days = 273;
                        break;
                    case 11:
                        days = 304;
                        break;
                    case 12:
                        days = 334;
                        break;
                    default:
                        break;
                }
            }
            days += date.Day;
            return days;
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblCategoriesToChoose.Text) > 0)
            {
                decimal value = dgvGetValue();
                int categoryId = dgvCategories_SelectionChanged(sender, e);
                var form = new SelectRoomFrm(dtpCheckin.Value.Date, dtpCheckout.Value.Date, categoryId, (short)nudApartments.Value, (short)nudAdults.Value, (short)nudKids.Value, value);
                form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("There are no more apartments to select");
            }
        }

        private void picRemove_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblCategoriesToChoose.Text) < nudApartments.Value)
            {
                int selectedrowindex = dgvSelectedApartments.SelectedCells[0].RowIndex;
                DataGridViewRow dgvRow = dgvSelectedApartments.Rows[selectedrowindex];
                if (Globals.apartments != null)
                {
                    for (int i = 0; i < Globals.apartments.Count; i++)
                    {
                        if (Globals.apartments[i].Number == Convert.ToInt16(dgvRow.Cells["Apartment Number"].Value.ToString()))
                        {
                            Globals.apartments.Remove(Globals.apartments[i]);
                        }
                    }
                }
                dgvSelectedApartments.Rows.RemoveAt(selectedrowindex);
                lblCategoriesToChoose.Text = (int.Parse(lblCategoriesToChoose.Text) + 1).ToString();
                btnSelectGuest.Enabled = false;
                btnNewGuest.Enabled = false;
            }
        }

        private void NotAvailable()
        {
            lblAvailability.Visible = true;
            lblAvailability.Text = "There are no apartments available for these dates";
            lblAvailability.ForeColor = Color.Red;
        }

        private void NoRoomAvailable()
        {
            lblAvailability.Visible = true;
            lblAvailability.Text = "No room available for this amount of guests";
            lblAvailability.ForeColor = Color.Red;
        }

        private void Available(int apartments)
        {
            lblAvailability.Visible = true;
            lblAvailability.Text = $"{apartments} apartments available";
            lblAvailability.ForeColor = Color.Green;
        }

        private void btnChangeDates_Click(object sender, EventArgs e)
        {
            EnableAllButtons();
            FormShrink();
            Globals.apartments.Clear();
        }

        private void UpdateDurationLabel(DateTime checkin, DateTime checkout)
        {
            if ((checkout.Date-checkin.Date).Days == 1)
            {
                lblDuration.Text = $"Duration: 1 day";
            }
            else
            {
                lblDuration.Text = $"Duration: {(checkout.Date - checkin.Date).Days} days";
            }            
        }

        private void dtpCheckout_ValueChanged(object sender, EventArgs e)
        {
            UpdateDurationLabel(dtpCheckin.Value.Date, dtpCheckout.Value.Date);
        }

        private void DisableAllButtons()
        {            
            dtpCheckin.Enabled = false;
            dtpCheckout.Enabled = false;
            nudAdults.Enabled = false;
            nudKids.Enabled = false;
            nudApartments.Enabled = false;
            btnAvailability.Enabled = false;
        }

        private void EnableAllButtons()
        {
            lblAvailability.Visible = false;
            dtpCheckin.Enabled = true;
            dtpCheckout.Enabled = true;
            nudAdults.Enabled = true;
            nudKids.Enabled = true;
            nudApartments.Enabled = true;
            btnAvailability.Enabled = true;
        }

        private int dgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvCategories.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvCategories.Rows[selectedrowindex];
                int a = Convert.ToInt32(selectedRow.Cells["category_id"].Value);
                return a;
            }
            else
            {
                return 0;
            }
        }

        private decimal dgvGetValue()
        {
            int selectedrowindex = dgvCategories.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvCategories.Rows[selectedrowindex];
            decimal value = Convert.ToDecimal(selectedRow.Cells["total_price"].Value);
            return value;
        }

        private void LoadSelectedApartments()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Apartment Id", typeof(short));
            dt.Columns.Add("Apartment Number", typeof(short));
            dt.Columns.Add("Apartment Category", typeof(string));
            dt.Columns.Add("Sub Total", typeof(decimal));

            foreach (var item in Globals.apartments)
            {
                DataRow row = dt.NewRow();
                row["Apartment Id"] = item.Id;
                row["Apartment Number"] = item.Number;
                row["Apartment Category"] = item.ApartmentCategory.Title;
                row["Sub Total"] = item.Value;
                dt.Rows.Add(row);
            }
            dgvSelectedApartments.DataSource = dt;
            lblCategoriesToChoose.Text = (nudApartments.Value - Globals.apartments.Count()).ToString();
            if (nudApartments.Value - Globals.apartments.Count() == 0)
            {
                btnSelectGuest.Enabled = true;
                btnNewGuest.Enabled = true;
            }
        }

        private void LoadReservationInfo(DateTime cin, DateTime cout, short apartments, short kids, short adults)
        {
            dtpCheckin.Value = cin;
            dtpCheckout.Value = cout;
            nudAdults.Value = adults;
            nudKids.Value = kids;
            nudApartments.Value = apartments;
        }

        private void FormShrink()
        {
            this.Height = 281;
        }

        private void FormGrow()
        {
            this.Height = 508;
        }

        private void FormGrow2()
        {
            this.Height = 694;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Globals.connString);
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SaveNewReservation", con))
                {
                    con.Open();
                    cmd.Parameters.Add("_adults", MySqlDbType.Int16).Value = nudAdults.Value;
                    cmd.Parameters.Add("_kids", MySqlDbType.Int16).Value = nudKids.Value;
                    cmd.Parameters.Add("_duration", MySqlDbType.Int16).Value = (dtpCheckout.Value.Date - dtpCheckin.Value.Date).Days;
                    cmd.Parameters.Add("_main_guest_id", MySqlDbType.Int32).Value = int.Parse(txtGuestId.Text);
                    cmd.Parameters.Add("_checkin", MySqlDbType.Date).Value = dtpCheckin.Value.Date;
                    cmd.Parameters.Add("_checkout", MySqlDbType.Date).Value = dtpCheckout.Value.Date;
                    cmd.Parameters.Add("_moment_of_reservation", MySqlDbType.DateTime).Value = DateTime.Now;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                using (MySqlCommand cmd = new MySqlCommand("GetLastReservationId", con))
                {
                    con.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Globals.reservationId = int.Parse(reader[0].ToString());
                        }
                    }
                    con.Close();
                }

                for (int i = 0; i <= Globals.apartments.Count-1; i++)
                {
                    using (MySqlCommand cmd = new MySqlCommand("SaveSelectedApartments", con))
                    {
                        con.Open();
                        cmd.Parameters.Add("_reservation_id", MySqlDbType.Int32).Value = Globals.reservationId;
                        cmd.Parameters.Add("_apartment_id", MySqlDbType.Int16).Value = Globals.apartments[i].Id;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                
                using (MySqlCommand cmd = new MySqlCommand("GetLastReservationApartmentId", con))
                {
                    int reservationApartmentId = 0;
                    con.Open();
                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            reservationApartmentId = int.Parse(reader[0].ToString());
                        }
                    }

                    using (MySqlCommand cmd2 = new MySqlCommand("InsertMainGuestOnReservation", con))
                    {
                        cmd2.Parameters.Add("_reservation_apartment_id", MySqlDbType.Int32).Value = reservationApartmentId;
                        cmd2.Parameters.Add("_guest_id", MySqlDbType.Int32).Value = int.Parse(txtGuestId.Text);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.ExecuteNonQuery();                        
                    }
                    con.Close();
                }
                MessageBox.Show("Reservation saved successfully");
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
