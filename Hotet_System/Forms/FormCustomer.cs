using Hotet_System.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotet_System.Forms
{

    public partial class FormCustomer : Form
    {
        DataTable dtCustomer;
        FormMain formMain;
        
        

        public FormCustomer(FormMain formMain)
        {
            InitializeComponent();
            InitializeData();
            this.formMain = formMain;
            
        }


        private void InitializeData()
        {

            dtCustomer = Customers.GetAll();

            dgCustomers.DataSource = dtCustomer;

            dgCustomers.Columns[0].Visible =false;
            dgCustomers.Columns[4].HeaderText = "CUSTOMER NAME";
            dgCustomers.Columns[4].Width = 200;
            dgCustomers.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgCustomers.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgCustomers.Columns[4].Visible = true;
            dgCustomers.Columns[3].Visible = false;
            dgCustomers.Columns[5].Visible = false;
            dgCustomers.Columns[1].Visible = false;
            dgCustomers.Columns[2].Visible = false;
            dgCustomers.Columns[6].Visible = false;
            dgCustomers.Columns[7].Visible = false;
            dgCustomers.Columns[8].Visible = false;
            dgCustomers.Columns[9].Visible = false;

        }
        private void txtCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormCustomerAddEdit formCustomerAddEdit = new FormCustomerAddEdit(null);
            if (formCustomerAddEdit.ShowDialog() == DialogResult.OK)
            {
                InitializeData();
            }
        }

        private void dgCustomers_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgCustomers.SelectedRows.Count >= 0)
            {
                int customerid =
                Convert.ToInt32(dgCustomers.SelectedRows[0].Cells["CustomerId"].Value.ToString());
                Customer customer = Customers.Get(customerid);
                if (customer == null)
                {
                    MessageBox.Show("Cannot find customer");
                }
                else
                {
                    FormCustomerAddEdit formAddEdit = new
                    FormCustomerAddEdit(customer);
                    if (formAddEdit.ShowDialog() == DialogResult.OK)
                    {
                        InitializeData();
                    }

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(this, "Confirmation!\nDo you really want to delete this record ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                int customerid =
                Convert.ToInt32(dgCustomers.SelectedRows[0].Cells["CustomerId"].Value.ToString());
                Customers.Delete(customerid);
                MessageBox.Show("Customer had deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InitializeData();
            }
        }

        private void dgCustomers_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgCustomers.SelectedRows.Count <= 0)
                return;
            int customerid = Convert.ToInt32(dgCustomers.SelectedRows[0].Cells["CustomerId"].Value.ToString());
            Customer customer = Customers.Get(customerid);
            if (customer != null)
            {
                txtCode.Text = customer.CustomerCode;
                txtType.Text = customer.CustomerType;
                txtName.Text = customer.CustomerName;
                txtSex.Text = customer.Sex;
                txtDob.Text = customer.Dob;
                txtPhone.Text = customer.Phone;
                txtPassport.Text = customer.PassportNumber;
                txtCountry.Text = customer.Country;


            }
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            DataTable dtUserPermission = AppUserPermissions.Get(formMain.UserLogin.AppUserId);
            foreach (DataRow row in dtUserPermission.Rows)
            {

                if (row["UserPermission"].ToString() == "CustomerCreate")
                {
                    btnNew.Visible = true;
                }

                if (row["UserPermission"].ToString() == "CustomerModify")
                {
                    btnEdit.Visible = true;
                }

                if (row["UserPermission"].ToString() == "CustomerDelete")
                {
                    btnDelete.Visible = true;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string searchString = txtSearch.Text;
            string connectionString = "Data Source=192.168.56.1:1521/XEPDB1;User Id=MyHotelData; Password=12345;"; 
            
            string sql = "SELECT * FROM Customer WHERE CustomerName LIKE :searchString";

            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        command.Parameters.Add(new OracleParameter(":searchString", "%" + searchString + "%"));

                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Update the DataGridView with the search results
                            dgCustomers.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching data: " + ex.Message);
            }

           

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void dgCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }


    }

        
    }


