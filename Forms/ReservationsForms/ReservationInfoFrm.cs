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
        public int ReservationId { get; set; }
        public ReservationInfoFrm()
        {
            InitializeComponent();            
        }

        private void ReservationInfoFrm_Load(object sender, EventArgs e)
        {
            // Globals.reservationId is set when the user selected the reservation in the previous form.
            this.ReservationId = Globals.reservationId;

            dgvGuests.DataSource = GetGuestsFromReservation();
            dgvGuests.Columns["guest_id"].Visible = false;
            dgvApartments.DataSource = GetApartmentsFromReservation();
            dgvProductsAndServices.DataSource = GetProductsFromReservation();
            GetReservationInfo();

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
                dtpCheckin.Value = DateTime.Parse(reader["checkin"].ToString());
                dtpCheckout.Value = DateTime.Parse(reader["checkout"].ToString());
                lblAdults.Text = $"Adults: {reader["adults"]}";
                lblKids.Text = $"Kids: {reader["kids"]}";
                lblDuration.Text = $"Duration: {reader["duration"]} days";
                dtpMomentOfReservation.Value = DateTime.Parse(reader["moment_of_reservation"].ToString());
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
            var form = new CheckinFrm(this.ReservationId);
            form.Show();
        }
    }
}
