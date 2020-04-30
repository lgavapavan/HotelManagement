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
using HotelsPro2.Entities;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace HotelsPro2.Forms
{
    public partial class GuestListFrm : Form
    {
        public GuestListFrm()
        {
            InitializeComponent();
        }

        private void GuestListFrm_Load(object sender, EventArgs e)
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
            dgvGuests.Columns["guest_id"].Visible = false;
            dgvGuests.Columns["Name"].Visible = false;
            dgvGuests.Columns["Last Name"].Visible = false;

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

        private DataTable SearchGuest()
        {
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connString);

            con.Open();
            MySqlCommand cmd = new MySqlCommand("SearchGuest", con);
            cmd.Parameters.Add("pname", MySqlDbType.VarChar,55).Value = txtSearchGuest.Text.Trim();
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dtGuestSearched = new DataTable();
            dtGuestSearched.Load(reader);
            con.Close();
            return dtGuestSearched;
        }

        private void btnNewGuest_Click(object sender, EventArgs e)
        {
            var form = new GuestRegistrationFrm();
            form.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {   
            MySqlConnection con = new MySqlConnection(Globals.connString);

            con.Open();

            MySqlCommand cmd = new MySqlCommand("DeleteGuest", con);
            int guestId = dgvGuests_SelectionChanged(sender, e);
            Globals.guestId = guestId;
            //Creates a string 'name' that holds the content in the Name Column from the selected row
            int selectedrowindex = dgvGuests.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvGuests.Rows[selectedrowindex];
            string name = Convert.ToString(selectedRow.Cells["Name"].Value);

            
            cmd.Parameters.Add("_id", MySqlDbType.Int32).Value = guestId;
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                DialogResult dialog = MessageBox.Show($"Are you sure you would like to delete {name}", "Delete Guest", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Guest deleted successfully");
                    dgvGuests.DataSource = null;
                    dgvGuests.Refresh();
                    dgvGuests.DataSource = GetGuestsList();
                    dgvGuests.Columns["guest_id"].Visible = false;
                }
                else
                {
                    MessageBox.Show("Ok, aborting deletion");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            con.Close();
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

        private void btnEditGuest_Click(object sender, EventArgs e)
        {
            var form = new EditGuestFrm();
            Globals.guestId = dgvGuests_SelectionChanged(sender, e);
            form.Show();
            this.Close();
        }
    }
}