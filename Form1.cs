using HotelsPro2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelsPro2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void newReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new NewReservationFrm();
            form.Show();
        }

        private void calendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new CalendarFrm();
            form.Show();
        }

        private void ratesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new RatesFrm();
            form.Show();
        }

        private void checkinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new CheckinsTodayFrm();
            form.Show();
        }

        private void checkoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new CheckoutsTodayFrm();
            form.Show();
        }

        private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ReservationListFrm();
            form.Show();
        }

        private void openCloseApartmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new OpenCloseApartmentFrm();
            form.Show();
        }

        private void newGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new GuestRegistrationFrm();
            form.Show();
        }

        private void guestListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new GuestListFrm();
            form.Show();
        }

        private void policiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new PropertyPoliciesFrm();
            form.Show();
        }

        private void manageRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new RoomManagementFrm();
            form.Show();
        }

        private void manageRoomCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ManageApartmentCatFrm();
            form.Show();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new EmployeesFrm();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void picCalendar_Click(object sender, EventArgs e)
        {
            var form = new CalendarFrm();
            form.Show();
        }

        private void lblCalendar_Click(object sender, EventArgs e)
        {
            var form = new CalendarFrm();
            form.Show();
        }

        private void picNewGuest_Click(object sender, EventArgs e)
        {
            var form = new GuestRegistrationFrm();
            form.Show();
        }

        private void lblNewGuest_Click(object sender, EventArgs e)
        {
            var form = new GuestRegistrationFrm();
            form.Show();
        }

        private void picNewReservation_Click(object sender, EventArgs e)
        {
            var form = new NewReservationFrm();
            form.Show();
        }

        private void lblNewReservation_Click(object sender, EventArgs e)
        {
            var form = new NewReservationFrm();
            form.Show();
        }

        private void picReservationList_Click(object sender, EventArgs e)
        {
            var form = new ReservationListFrm();
            form.Show();
        }

        private void lblReservationList_Click(object sender, EventArgs e)
        {
            var form = new ReservationListFrm();
            form.Show();
        }

        private void picGuestList_Click(object sender, EventArgs e)
        {
            var form = new GuestListFrm();
            form.Show();
        }

        private void lblGuestList_Click(object sender, EventArgs e)
        {
            var form = new GuestListFrm();
            form.Show();
        }

        private void picCheckIn_Click(object sender, EventArgs e)
        {
            var form = new CheckinsTodayFrm();
            form.Show();
        }

        private void lblCheckIn_Click(object sender, EventArgs e)
        {
            var form = new CheckinsTodayFrm();
            form.Show();
        }

        private void picCheckOut_Click(object sender, EventArgs e)
        {
            var form = new CheckoutsTodayFrm();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var form = new CheckoutsTodayFrm();
            form.Show();
        }

        private void picGuestsToday_Click(object sender, EventArgs e)
        {
            var form = new ReservationListFrm(DateTime.Today);
            form.Show();
        }

        private void lblGuestsToday_Click(object sender, EventArgs e)
        {
            var form = new ReservationListFrm(DateTime.Today);
            form.Show();
        }
    }
}
