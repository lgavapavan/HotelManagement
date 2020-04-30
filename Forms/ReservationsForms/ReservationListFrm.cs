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
    public partial class ReservationListFrm : Form
    {
        public DateTime Date { get; set; }
        public ReservationListFrm()
        {
            InitializeComponent();
            dgvReservations.DataSource = GetReservations();
            dgvReservations.Columns["reservation_id"].Visible = false;
        }

        public ReservationListFrm(DateTime date)
        {
            InitializeComponent();
            this.Date = date;
            dgvReservations.DataSource = GetReservationsFromToday();
            dgvReservations.Columns["reservation_id"].Visible = false;
            dtpCheckout.Value = dtpCheckin.Value.AddDays(1);
        }

        private void ReservationListFrm_Load(object sender, EventArgs e)
        {
            dtpCheckout.Value = dtpCheckin.Value.AddDays(1);
        }

        private DataTable GetReservations()
        {
            DataTable dtReservations = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("DisplayAllReservations", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtReservations.Load(reader);

                    con.Close();
                }
            }

            return dtReservations;
        }

        public DataTable GetReservationsFromToday()
        {
            DataTable dtReservationsFromToday = new DataTable();
            MySqlConnection con = new MySqlConnection(Globals.connString);
            using (MySqlCommand cmd = new MySqlCommand("GetReservationsStayingToday", con))
            {
                cmd.Parameters.Add("_today", MySqlDbType.Date).Value = this.Date;
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                dtReservationsFromToday.Load(reader);

                con.Close();
            }

            return dtReservationsFromToday;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvReservations.DataSource = null;
            dgvReservations.Refresh();
            dgvReservations.DataSource = GetReservationsBetweenDates();
            btnClearSearch.Visible = true;
            dgvReservations.Columns["reservation_id"].Visible = false;
        }

        private DataTable GetReservationsBetweenDates()
        {
            DataTable dtReservationsBetweenDates = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connString);

            con.Open();
            MySqlCommand cmd = new MySqlCommand("DisplayReservationsBetweenDates", con);
            cmd.Parameters.Add("_check_in", MySqlDbType.Date).Value = dtpCheckin.Value;
            cmd.Parameters.Add("_check_out", MySqlDbType.Date).Value = dtpCheckout.Value;
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataReader reader = cmd.ExecuteReader();
            dtReservationsBetweenDates.Load(reader);
            con.Close();

            return dtReservationsBetweenDates;
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            var form = new ReservationInfoFrm();
            Globals.reservationId = dgvReservations_SelectionChanged(sender, e);
            form.Show();
            this.Close();
        }

        private int dgvReservations_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvReservations.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvReservations.Rows[selectedrowindex];
                int a = Convert.ToInt32(selectedRow.Cells["reservation_id"].Value);
                return a;
            }
            else
            {
                return 0;
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            dgvReservations.DataSource = null;
            dgvReservations.Refresh();
            dgvReservations.DataSource = GetReservations();
            dgvReservations.Columns["reservation_id"].Visible = false;
            btnClearSearch.Visible = false;
        }
    }
}
