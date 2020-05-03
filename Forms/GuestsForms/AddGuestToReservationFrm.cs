using HotelsPro2.Entities;
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
    public partial class AddGuestToReservationFrm : Form
    {
        public Reservation Reservation { get; set; }
        public Guest Guest { get; set; }
        public AddGuestToReservationFrm(int reservationId)
        {
            InitializeComponent();
            this.Reservation = new Reservation();
            this.Reservation.Id = reservationId;
        }
        private void SelectGuestFrm_Load(object sender, EventArgs e)
        {
            dgvGuests.DataSource = GetGuestsList();
            dgvGuests.Columns["guest_id"].Visible = false;
            dgvGuests.Columns["Name"].Visible = false;
            dgvGuests.Columns["Last Name"].Visible = false;
        }

        private void btnSearchGuest_Click(object sender, EventArgs e)
        {
            dgvGuests.DataSource = null;
            dgvGuests.Refresh();
            dgvGuests.DataSource = SearchGuest();
            dgvGuests.Columns["Name"].Visible = false;
            dgvGuests.Columns["Last Name"].Visible = false;
        }

        private DataTable SearchGuest()
        {
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connString);

            con.Open();
            MySqlCommand cmd = new MySqlCommand("SearchGuest", con);
            cmd.Parameters.Add("pname", MySqlDbType.VarChar, 55).Value = txtSearchGuest.Text.Trim();
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dtGuestSearched = new DataTable();
            dtGuestSearched.Load(reader);
            con.Close();
            return dtGuestSearched;
        }


        private DataTable GetGuestsList()
        {
            DataTable dtGuests = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("DisplayGuests", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtGuests.Load(reader);

                    con.Close();
                }
            }
            return dtGuests;
        }

        private void btnSelectGuest_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dgvGuests.Rows[dgvGuests.SelectedCells[0].RowIndex];
            if (row.Cells[4].Value.ToString() == Globals.hotelCountry)
            {
                Guest guest = new NationalGuest();
                guest.Id = int.Parse(row.Cells["guest_id"].Value.ToString());
                guest.FirstName = row.Cells["Name"].Value.ToString();
                guest.LastName = row.Cells["Last Name"].Value.ToString();
                guest.Email = row.Cells["Email"].Value.ToString();
                this.Guest = guest;
            }
            else
            {
                Guest guest = new InternationalGuest();
                guest.Id = int.Parse(row.Cells[0].Value.ToString());
                guest.FirstName = row.Cells["Name"].Value.ToString();
                guest.LastName = row.Cells["Last Name"].Value.ToString();
                guest.Email = row.Cells["Email"].Value.ToString();
                this.Guest = guest;
            }

            MySqlConnection con = new MySqlConnection(Globals.connString);
            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO _reservation_guest(guest_id, reservation_id) " +
                "VALUES(@guestId, @reservationId)", con))
            {
                cmd.Parameters.Add("@guestId", MySqlDbType.Int32).Value = this.Guest.Id;
                cmd.Parameters.Add("@reservationId", MySqlDbType.Int32).Value = this.Reservation.Id;                
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            MessageBox.Show("Guest added to reservation");
            this.Close();
        }

        private void SelectGuestFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form = new ReservationInfoFrm();
            form.Show();
        }
    }
}
