using HotelsPro2.Entities;
using HotelsPro2.Entities.Enums;
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
    public partial class SelectRoomCheckinFrm : Form
    {
        public int ReservationId { get; set; }
        public List<int> ReservationApartmentId { get; set; }
        public Apartment Apartment { get; set; }
        public Guest Guest { get; set; }
        public SelectRoomCheckinFrm()
        {
            InitializeComponent();
        }
        public SelectRoomCheckinFrm(int reservationId, List<int> reservationApartmentId, Guest guest)
        {
            InitializeComponent();
            this.ReservationId = reservationId;
            this.ReservationApartmentId = reservationApartmentId;
            this.Guest = guest;
            this.Apartment = null;
        }

        private void RoomManagementFrm_Load(object sender, EventArgs e)
        {
            dgvRooms.DataSource = GetApartmentList();
            dgvRooms.Columns["Apartment Id"].Visible = false;
            dgvRooms.Columns["Reservation Apartment Id"].Visible = false;
            if (dgvRooms.Rows.Count == 0)
            {
                btnSelect.Enabled = false;
            }
        }

        private DataTable GetApartmentList()
        {
            DataTable dtAvailableApartments = new DataTable();
            DataTable dt = new DataTable();
            
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                for (int i = 0; i <= this.ReservationApartmentId.Count-1; i++)
                {
                    int count = 0;
                    using (MySqlCommand cmd = new MySqlCommand("" +
                        "SELECT COUNT(*) " +
                        "FROM _guests_on_a_reservation " +
                        "WHERE reservation_apartment_id = @reservation_apartment_id", con))
                    {
                        cmd.Parameters.Add("@reservation_apartment_id", MySqlDbType.Int32).Value = this.ReservationApartmentId[i];
                        con.Open();

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                count = int.Parse(reader[0].ToString());
                            }
                        }

                        using (MySqlCommand cmd2 = new MySqlCommand("ShowApartmentsFromReservationStillAvailable",con))
                        {
                            cmd2.Parameters.Add("_count", MySqlDbType.Int32).Value = count;
                            cmd2.Parameters.Add("_reservation_apartment_id", MySqlDbType.Int32).Value = this.ReservationApartmentId[i];
                            cmd2.CommandType = CommandType.StoredProcedure;

                            using (MySqlDataReader reader2 = cmd2.ExecuteReader())
                            {
                                dtAvailableApartments.Load(reader2);
                            }
                        }
                        dt.Merge(dtAvailableApartments);
                        con.Close();
                    }
                }

            }
            return dtAvailableApartments;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dgvRooms.Rows[dgvRooms.SelectedCells[0].RowIndex];
            Apartment apartment = new Apartment();
            apartment.Id = short.Parse(row.Cells[0].Value.ToString()); //gets the reservation_apartment_id
            apartment.Number = short.Parse(row.Cells[2].Value.ToString());
            ApartmentCategory apartmentCategory = new ApartmentCategory();
            apartmentCategory.Title = row.Cells[3].Value.ToString();
            apartment.ApartmentCategory = apartmentCategory;
            this.Apartment = apartment;
            this.Close();
        }

        private int dgvRooms_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvRooms.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvRooms.Rows[selectedrowindex];
                int a = Convert.ToInt32(selectedRow.Cells["apartment_id"].Value);
                return a;
            }
            else
            {
                return 0;
            }
        }

        private void SelectRoomFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Apartment != null)
            {
                var form = new CheckinFrm(this.ReservationId, this.Guest, this.Apartment, this.ReservationApartmentId);
                form.Show();
            }
            else
            {
                var form = new CheckinFrm(this.ReservationId, this.Guest, this.ReservationApartmentId);
                form.Show();
            }
        }
    }
}
