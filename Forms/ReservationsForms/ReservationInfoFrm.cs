using HotelsPro2.Entities;
using HotelsPro2.Forms.ReservationsForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelsPro2.Forms
{
    public partial class ReservationInfoFrm : Form
    {
        // This form displays all relevant information for a specific reservation
        public List<int> ReservationApartmentId { get; set; }
        public Reservation Reservation { get; set; }
        public ReservationInfoFrm()
        {
            InitializeComponent();
            this.Reservation = new Reservation();

        }

        private void ReservationInfoFrm_Load(object sender, EventArgs e)
        {
            // Globals.reservationId is set when the user selected the reservation in the previous form.
            this.Reservation.Id = Globals.reservationId;

            dgvGuests.DataSource = GetGuestsFromReservation();
            dgvGuests.Columns["guest_id"].Visible = false;
            dgvApartments.DataSource = GetApartmentsFromReservation();
            dgvApartments.Columns["Reservation Apartment Id"].Visible = false;
            dgvApartments.Columns["Apartment Id"].Visible = false;
            dgvProductsAndServices.DataSource = GetProductsFromReservation();
            GetReservationInfo();
            if (dgvGuests.Rows.Count<(this.Reservation.Adults+this.Reservation.Kids))
            {
                btnAddGuest.Enabled = true;
            }
            

        }

        // Method that brings up relevant information about the reservation, like check-in and check-out dates
        // number of guests, number of apartments ...
        private void GetReservationInfo()
        {
            MySqlConnection con = new MySqlConnection(Globals.connString);

            con.Open();

            MySqlCommand cmd = new MySqlCommand("DisplayReservationInfo", con);
            cmd.Parameters.Add("_reservation_id", MySqlDbType.Int32).Value = Globals.reservationId;
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Reservation reservation = new Reservation();
                reservation.Id = this.Reservation.Id;
                reservation.Checkin = DateTime.Parse(reader["checkin"].ToString());
                dtpCheckin.Value = reservation.Checkin;
                reservation.Checkout = DateTime.Parse(reader["checkout"].ToString());
                dtpCheckout.Value = reservation.Checkout;
                reservation.Adults = byte.Parse(reader["adults"].ToString());
                lblAdults.Text = $"Adults: {reservation.Adults}";
                reservation.Kids = byte.Parse(reader["kids"].ToString());
                lblKids.Text = $"Kids: {reservation.Kids}";
                reservation.Duration = short.Parse(reader["duration"].ToString());
                lblDuration.Text = $"Duration: {reservation.Duration} days";
                reservation.MomentOfReservation = DateTime.Parse(reader["moment_of_reservation"].ToString());
                dtpMomentOfReservation.Value = reservation.MomentOfReservation;
                this.Reservation = reservation;
            }

            // Calculating sum of consumed products:
            decimal sum = 0;
            for (int i = 0; i < dgvProductsAndServices.Rows.Count; i++)
            {
                sum += Convert.ToDecimal(dgvProductsAndServices.Rows[i].Cells["Subtotal"].Value);
            }
            lblTotal.Text = $"Total: {sum.ToString()}";
            con.Close();
        }

        // Method that brings all guests that belong to this reservation
        private DataTable GetGuestsFromReservation()
        {
            DataTable dtGuests = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            MySqlConnection con = new MySqlConnection(connString);

            con.Open();

            MySqlCommand cmd = new MySqlCommand("ShowGuestsFromReservation", con);
            cmd.Parameters.Add("_reservation_id", MySqlDbType.Int32).Value = Globals.reservationId;
            cmd.CommandType = CommandType.StoredProcedure;

            MySqlDataReader reader = cmd.ExecuteReader();

            dtGuests.Load(reader);

            con.Close();

            return dtGuests;
        }

        // Method that gets all the apartments rented for this reservation
        private DataTable GetApartmentsFromReservation()
        {
            DataTable dtApartments = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            MySqlConnection con = new MySqlConnection(connString);

            con.Open();

            MySqlCommand cmd = new MySqlCommand("ShowApartmentsFromReservation", con);
            cmd.Parameters.Add("_reservation_id", MySqlDbType.Int32).Value = Globals.reservationId;
            cmd.CommandType = CommandType.StoredProcedure;

            MySqlDataReader reader = cmd.ExecuteReader();

            dtApartments.Load(reader);

            con.Close();

            return dtApartments;
        }

        // Method that gets all the services and products that were consumed in this reservation
        private DataTable GetProductsFromReservation()
        {
            DataTable dtProducts = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            MySqlConnection con = new MySqlConnection(connString);

            con.Open();

            MySqlCommand cmd = new MySqlCommand("ShowProductsFromReservation", con);
            cmd.Parameters.Add("_reservation_id", MySqlDbType.Int32).Value = Globals.reservationId;
            cmd.CommandType = CommandType.StoredProcedure;

            MySqlDataReader reader = cmd.ExecuteReader();

            dtProducts.Load(reader);

            con.Close();

            return dtProducts;
        }

        private void btnViewGuest_Click(object sender, EventArgs e)
        {
            var form = new ViewGuestFrm();
            Globals.guestId = dgvGuests_SelectionChanged(sender, e);
            form.Show();
        }

        private int dgvGuests_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGuests.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvGuests.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvGuests.Rows[selectedrowindex];
                int a = Convert.ToInt32(selectedRow.Cells["guest_id"].Value);
                return a;
            }
            else
            {
                return 0;
            }
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            if (this.ReservationApartmentId != null)
                this.ReservationApartmentId.Clear();
            List<int> a = new List<int>();
            for (int i = 0; i <= dgvApartments.Rows.Count-1; i++)
            {
                a.Add(int.Parse(dgvApartments.Rows[i].Cells["Reservation Apartment Id"].Value.ToString()));
            }
            this.ReservationApartmentId = a;
            var form = new CheckinFrm(this.Reservation.Id, this.ReservationApartmentId);
            form.Show();
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            var form = new AddGuestToReservationFrm(this.Reservation.Id);
            form.Show();
            this.Close();
        }
    }
}
