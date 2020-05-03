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
    public partial class SelectGuestCheckinFrm : Form
    {
        public Guest Guest { get; set; }
        public int ReservationId { get; set; }
        public List<int> ReservationApartmentId { get; set; }
        public List<int> GuestsIds { get; set; }
        public SelectGuestCheckinFrm(int reservationId, List<int> reservationApartmentId, List<int> guests)
        {
            InitializeComponent();
            this.ReservationId = reservationId;
            this.ReservationApartmentId = reservationApartmentId;
            this.GuestsIds = guests;
        }
        private void SelectGuestFrm_Load(object sender, EventArgs e)
        {
            dgvGuests.DataSource = GetGuestsFromReservation();
            RemoveGuestsThatAlreadyHaveAnApartment();
            dgvGuests.Columns["guest_id"].Visible = false;
            dgvGuests.Columns["First Name"].Visible = false;
            dgvGuests.Columns["Last Name"].Visible = false;
            if (dgvGuests.Rows.Count == 0)
            {
                btnSelectGuest.Enabled = false;
                btnSearchGuest.Enabled = false;
            }
        }

        private void btnSearchGuest_Click(object sender, EventArgs e)
        {
            dgvGuests.DataSource = null;
            dgvGuests.Refresh();
            dgvGuests.DataSource = SearchGuest();
            RemoveGuestsThatAlreadyHaveAnApartment();
            dgvGuests.Columns["guest_id"].Visible = false;
            dgvGuests.Columns["First Name"].Visible = false;
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

        private void btnSelectGuest_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dgvGuests.Rows[dgvGuests.SelectedCells[0].RowIndex];
            if (row.Cells[4].Value.ToString() == Globals.hotelCountry)
            {
                Guest guest = new NationalGuest();
                guest.Id = int.Parse(row.Cells["guest_id"].Value.ToString());
                guest.FirstName = row.Cells["First Name"].Value.ToString();
                guest.LastName = row.Cells["Last Name"].Value.ToString();
                guest.Email = row.Cells["Email"].Value.ToString();
                this.Guest = guest;
            }
            else
            {
                Guest guest = new InternationalGuest();
                guest.Id = int.Parse(row.Cells["guest_id"].Value.ToString());
                guest.FirstName = row.Cells["First Name"].Value.ToString();
                guest.LastName = row.Cells["Last Name"].Value.ToString();
                guest.Email = row.Cells["Email"].Value.ToString();
                this.Guest = guest;
            }
            this.Close();
            var form = new CheckinFrm(this.ReservationId, this.Guest, this.ReservationApartmentId);
            form.Show();
        }

        private void RemoveGuestsThatAlreadyHaveAnApartment()
        {
            for (int i = 0; i <= dgvGuests.Rows.Count-1; i++)
            {
                for (int j = 0; j <= this.GuestsIds.Count-1; j++)
                {
                    if (int.Parse(dgvGuests.Rows[i].Cells["guest_id"].Value.ToString()) == this.GuestsIds[j])
                    {
                        dgvGuests.Rows.RemoveAt(i);
                    }
                }
            }
        }

        private void SelectGuestFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
