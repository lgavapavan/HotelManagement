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
    public partial class RoomManagementFrm : Form
    {
        public RoomManagementFrm()
        {
            InitializeComponent();
        }

        private void RoomManagementFrm_Load(object sender, EventArgs e)
        {
            dgvRooms.DataSource = GetApartmentList();
        }

        private DataTable GetApartmentList()
        {
            DataTable dtApartments = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("DisplayApartments", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtApartments.Load(reader);

                    con.Close();
                }
            }

            return dtApartments;
        }
        private void btnNewRoom_Click(object sender, EventArgs e)
        {
            var form = new NewRoomFrm();
            form.Show();
        }

    }
}
