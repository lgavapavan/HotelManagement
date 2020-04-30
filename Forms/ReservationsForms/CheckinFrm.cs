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

namespace HotelsPro2.Forms.ReservationsForms
{
    public partial class CheckinFrm : Form
    {
        // This form is where the user will select the guests (or create guests if they still don't have a record)
        // and assign each of them to their specific rooms.

        public int ReservationId { get; set; }
        public Guest Guest { get; set; }
        public Apartment Apartment { get; set; }
        public CheckinFrm()
        {
            InitializeComponent();
        }

        public CheckinFrm(int reservationId)
        {
            InitializeComponent();
            this.ReservationId = reservationId;
        }

        public CheckinFrm(int reservationId, Guest guest)
        {
            InitializeComponent();
            this.ReservationId = reservationId;
            this.Guest = guest;
            txtGuestName.Text = guest.FirstName + " " + guest.LastName;
        }

        public CheckinFrm(int reservationId, Guest guest, Apartment apartment)
        {
            InitializeComponent();
            this.ReservationId = reservationId;
            this.Guest = guest;
            txtGuestName.Text = guest.FirstName + " " + guest.LastName;

        }
        private void CheckinFrm_Load(object sender, EventArgs e)
        {
            dgvGuests.DataSource = GetGuestsInEachApartment();
        }

        private void btnSelectGuest_Click(object sender, EventArgs e)
        {
            var form = new SelectGuestCheckinFrm(this.ReservationId);
            form.Show();
            this.Close();
        }

        private DataTable GetGuestsInEachApartment()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = new MySqlConnection(Globals.connString);
            using (MySqlCommand cmd = new MySqlCommand("DisplayGuestsInEachApartment", con))
            {
                con.Open();
                cmd.Parameters.Add("_reservation_id", MySqlDbType.Int32).Value = this.ReservationId;
                cmd.CommandType = CommandType.StoredProcedure;

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
                con.Close();
            }
            return dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Globals.connString);
            using (MySqlCommand cmd = new MySqlCommand("SaveGuestInARoom", con))
            {
                //PAREI AQUI
                //cmd.Parameters.Add("_reservation_apartment_id",MySqlDbType.Int32).Value = this.Apartment.Number 
            }
        }

        private void btnSelectApartment_Click(object sender, EventArgs e)
        {
            //var form = new SelectRoomCheckinFrm()
        }
    }
}
