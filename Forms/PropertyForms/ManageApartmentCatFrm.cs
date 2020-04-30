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
    public partial class ManageApartmentCatFrm : Form
    {
        public ManageApartmentCatFrm()
        {
            InitializeComponent();
        }

        private void ManageApartmentCatFrm_Load(object sender, EventArgs e)
        {
            dgvCategory.DataSource = GetApartmentCategories();
            dgvCategory.Columns["category_id"].Visible = false;
        }

        private DataTable GetApartmentCategories()
        {
            DataTable dtCategories = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("DisplayCategories", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtCategories.Load(reader);

                    con.Close();
                }
            }
            return dtCategories;
        }
    }
}
