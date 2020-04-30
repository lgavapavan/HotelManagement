using HotelsPro2.Entities;
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
    public partial class CheckinsTodayFrm : Form
    {
        // This form shows reservations where the Check-in date matches the selected day on the DateTimePicker
        // The user will  select the desired reservation and proceed to "CheckinFrm.cs" so he can check the 
        // guests in.
        public CheckinsTodayFrm()
        {
            InitializeComponent();
        }

        private void CheckinFrm_Load(object sender, EventArgs e)
        {
            dgvReservations.DataSource = ReservationsArrivingIn();
            CheckIfThereAreReservations();
            HideColumns();
        }

        private DataTable ReservationsArrivingIn()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = new MySqlConnection(Globals.connString);

            // DisplayReservationsArrivingIn -> Procedure that gets reservations from a specific date 
            // where the Check-in hasn't been done yet 
            using (MySqlCommand cmd = new MySqlCommand("DisplayReservationsArrivingIn", con))
            {
                con.Open();
                cmd.Parameters.Add("_date", MySqlDbType.Date).Value = dtpDateFilter.Value;
                cmd.CommandType = CommandType.StoredProcedure;

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            con.Close();
            return dt;
        }

        private void dtpDateFilter_ValueChanged(object sender, EventArgs e)
        {
            dgvReservations.DataSource = null;
            dgvReservations.Update();
            dgvReservations.DataSource = ReservationsArrivingIn();
            HideColumns();
            CheckIfThereAreReservations();
        }

        private void HideColumns()
        {
            dgvReservations.Columns["main_guest_id"].Visible = false;
            dgvReservations.Columns["document"].Visible = false;
            dgvReservations.Columns["reservation_id"].Visible = false;
        }

        private void btnSelectReservation_Click(object sender, EventArgs e)
        {
            dtpDateFilter.Enabled = false;
            dgvReservations.Enabled = false;
            btnFindByDocument.Enabled = false;
            btnFindByName.Enabled = false;
            txtFindByDocument.Enabled = false;
            txtFindByName.Enabled = false;
            
            Globals.reservationId = int.Parse(dgvReservations.SelectedRows[0].Cells["reservation_id"].Value.ToString());
            var form = new ReservationInfoFrm();
            form.Show();
            this.Close();
        }

        private void CheckIfThereAreReservations()
        {
            // This method prevents the user to click the "Select button" if there are no reservations displayed
           
            int rows = 0;
            rows = dgvReservations.Rows.Count;
            if (rows <= 1)
            {
                btnSelectReservation.Enabled = false;
            }
            else
            {
                btnSelectReservation.Enabled = true;
            }
        }
    }
}
