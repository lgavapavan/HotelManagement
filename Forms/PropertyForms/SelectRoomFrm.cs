using HotelsPro2.Entities;
using HotelsPro2.Entities.Enums;
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
    public partial class SelectRoomFrm : Form
    {
        public DateTime Cin { get; set; }
        public DateTime Cout { get; set; }
        public short Apartments { get; set; }
        public short Adult { get; set; }
        public short Kids { get; set; }
        public int CatId { get; set; }
        public decimal Value { get; set; }
        public SelectRoomFrm(DateTime checkin, DateTime checkout, int categoryId, short apartments, short adult, short kids, decimal value)
        {
            InitializeComponent();
            this.Cin = checkin;
            this.Cout = checkout;
            this.CatId = categoryId;
            this.Apartments = apartments;
            this.Adult = adult;
            this.Kids = kids;
            this.Value = value;
        }

        private void RoomManagementFrm_Load(object sender, EventArgs e)
        {
            dgvRooms.DataSource = GetApartmentList();
            dgvRooms.Columns["apartment_id"].Visible = false;
            if (dgvRooms.Rows.Count == 0)
            {
                btnSelect.Enabled = false;
            }
        }

        private DataTable GetApartmentList()
        {
            DataTable dtAvailableApartments = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("DisplayApartmentsFromCategory", con))
                {
                    cmd.Parameters.Add("_category", MySqlDbType.Int32).Value = this.CatId;
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtAvailableApartments.Load(reader);

                    con.Close();
                }

                using (MySqlCommand cmd = new MySqlCommand("RemoveReservedApartmentsFromDataTable", con))                
                {
                    cmd.Parameters.Add("_checkin", MySqlDbType.Date).Value = this.Cin;
                    cmd.Parameters.Add("_checkout", MySqlDbType.Date).Value = this.Cout;
                    cmd.Parameters.Add("_category", MySqlDbType.Int32).Value = this.CatId;
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int i = dtAvailableApartments.Rows.Count-1; i >= 0; i--)
                            {
                                DataRow dr = dtAvailableApartments.Rows[i];
                                if (int.Parse(dr["apartment_id"].ToString()) == int.Parse(reader[0].ToString()))
                                {
                                    dr.Delete();
                                }
                            }
                            dtAvailableApartments.AcceptChanges();
                        }
                    }
                    con.Close();
                }
            }

            //this section removes from the list the apartments that are currently selected for this reservation 
            if (Globals.apartments != null)
            {
                foreach (var item in Globals.apartments)
                {
                    for (int i = dtAvailableApartments.Rows.Count-1; i >= 0; i--)
                    {
                        DataRow dr = dtAvailableApartments.Rows[i];
                        if (dr["apartment_id"].ToString() == item.Id.ToString())
                        {
                            dr.Delete();
                            for (int j = i; j < dtAvailableApartments.Rows.Count-1; j++)
                            {
                                DataRow dr2 = dtAvailableApartments.Rows[j];
                                DataRow dr3 = dtAvailableApartments.Rows[j + 1];
                                dr2 = dr3;
                            }
                            dtAvailableApartments.AcceptChanges();
                        }
                    }
                }
            }
            dtAvailableApartments.AcceptChanges();
            return dtAvailableApartments;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dgvRooms.Rows[dgvRooms.SelectedCells[0].RowIndex];
            Apartment apartment = new Apartment();
            apartment.Id = short.Parse(row.Cells[0].Value.ToString());
            apartment.Number = short.Parse(row.Cells[1].Value.ToString());
            apartment.Value = this.Value;
            ApartmentCategory apartmentCategory = new ApartmentCategory();
            apartmentCategory.Title = row.Cells[2].Value.ToString();
            apartmentCategory.RoomCapacity = byte.Parse(row.Cells[3].Value.ToString());
            apartment.ApartmentCategory = apartmentCategory;
            Globals.apartments.Add(apartment);
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
            var form = new NewReservationFrm(this.Cin, this.Cout, this.Apartments, this.Kids, this.Adult);
            form.Show();
        }
    }
}
