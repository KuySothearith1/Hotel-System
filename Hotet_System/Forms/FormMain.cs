using Hotet_System.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotet_System.Forms
{
    
    public partial class FormMain : Form
    {
        FormCustomer customer;
        FormRoom room;
        FormUserManagement setting;
        FormDashBoard dashboard;
        FormReservation reservation;
        FormInvoiceAdd invoice;
        DataTable dtUserPermission;
        public AppUser UserLogin { get; set; }
        public FormMain()
        {
            
            InitializeComponent();
            
        }

       

        private void btnCustomer_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = btnCustomer.Height;
            SidePanel.Top =btnCustomer.Top;
            if (customer == null)
            {
                customer = new FormCustomer(this);
                customer.TopLevel = false;
                pnMain.Controls.Add(customer);
                customer.Show();
                customer.BringToFront();
            }
            else
            {
                customer.BringToFront();
            }
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnRoom.Height;
            SidePanel.Top =btnRoom.Top;
            if (room == null)
            {
                room = new FormRoom(this);
                room.TopLevel = false;
                pnMain.Controls.Add(room);
                room.Show();
                room.BringToFront();
            }
            else
            {
                room.BringToFront();
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
          
            SidePanel.Height = btnSetting.Height;
            SidePanel.Top =btnSetting.Top;
            if (setting == null)
            {
                setting = new FormUserManagement(this);
                setting.TopLevel = false;
                setting.FormBorderStyle = FormBorderStyle.None;
                setting.Dock = DockStyle.Fill;
                pnMain.Controls.Add(setting);
                setting.Show();
                setting.BringToFront();
            }
            else
            {
                setting.BringToFront();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            this.Hide();
            formLogin.ShowDialog();
            this.Close();
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnDashboard.Height;
            SidePanel.Top =btnDashboard.Top;
            if (dashboard == null)
            {
                dashboard = new FormDashBoard(this);
                dashboard.TopLevel = false;
                pnMain.Controls.Add(dashboard);
                dashboard.Show();
                dashboard.BringToFront();
            }
            else
            {
                dashboard.BringToFront();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            if (this.UserLogin.IsAdmin)
            {
                btnSetting.Visible = true;
            }
            else
            {
                btnSetting.Visible = false;
            }

            dtUserPermission = AppUserPermissions.Get(this.UserLogin.AppUserId);
            foreach (DataRow row in dtUserPermission.Rows)
            {
                if (row["UserPermission"].ToString() == "CustomerView")
                {
                    btnCustomer.Visible = true;
                }
                if (row["UserPermission"].ToString() == "ReservationView")
                {
                    btnReservation.Visible = true;
                }
                if (row["UserPermission"].ToString() == "RoomView")
                {
                    btnRoom.Visible = true;
                }
               
            }

            string connectionString = "Data Source=192.168.56.1:1521/XEPDB1;User Id=MyHotelData; Password=12345;";
            string Customer = "Customer";
            string Room = "Room";
            string Reservation = "Reservation";
            string AppUser = "AppUser";


            int rowCount = 0;

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                string sql = $"SELECT COUNT(*) AS row_count FROM {Customer}";
                OracleCommand command = new OracleCommand(sql, connection);

                connection.Open();

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        rowCount = Convert.ToInt32(reader["row_count"]);
                    }
                }
            }


            lblCustomer.Text = rowCount.ToString();

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                string sql = $"SELECT COUNT(*) AS row_count FROM {Room}";
                OracleCommand command = new OracleCommand(sql, connection);

                connection.Open();

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        rowCount = Convert.ToInt32(reader["row_count"]);
                    }
                }
            }


            lblRoom.Text = rowCount.ToString();

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                string sql = $"SELECT COUNT(*) AS row_count FROM {Reservation}";
                OracleCommand command = new OracleCommand(sql, connection);

                connection.Open();

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        rowCount = Convert.ToInt32(reader["row_count"]);
                    }
                }
            }
            lblReservation.Text = rowCount.ToString();
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                string sql = $"SELECT COUNT(*) AS row_count FROM {AppUser}";
                OracleCommand command = new OracleCommand(sql, connection);

                connection.Open();

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        rowCount = Convert.ToInt32(reader["row_count"]);
                    }
                }
            }
            lblAppUser.Text = rowCount.ToString();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnReservation.Height;
            SidePanel.Top =btnReservation.Top;
            if (reservation == null)
            {
                reservation = new FormReservation(this);
                reservation.TopLevel = false;
                pnMain.Controls.Add(reservation);
                reservation.Show();
                reservation.BringToFront();
            }
            else
            {
                reservation.BringToFront();
            }
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnInvoice.Height;
            SidePanel.Top =btnInvoice.Top;
            if (invoice == null)
            {
                invoice = new FormInvoiceAdd(this);
                invoice.TopLevel = false;
                pnMain.Controls.Add(invoice);
                invoice.Show();
                invoice.BringToFront();
            }
            else
            {
                invoice.BringToFront();
            }
        }
    }
    
}
