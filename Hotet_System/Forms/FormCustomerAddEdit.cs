using Hotet_System.Models;
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
    public partial class FormCustomerAddEdit : Form
    {
        Customer customer;
        bool newcustomer;
        public event EventHandler CustomerSaved;
        public FormCustomerAddEdit(Customer customer)
        {
            InitializeComponent();

            cboCustomerType.Items.Add("Solo Traveler");
            cboCustomerType.Items.Add("Couples");
            cboCustomerType.Items.Add("Family Group");
            cboCustomerType.Items.Add("Other");
            cboSex.Items.Add("Male");
            cboSex.Items.Add("Female");

            if (customer == null)
            {
                this.customer=new Customer();
                lblTitle.Text = "New Customer";
                this.newcustomer = true;
                txtCustomerName.Focus();
                btnSave.Text = "Save";


            }
            else
            {
                this.customer = customer;
                this.newcustomer = false;
                lblTitle.Text = "Edit Customer";
                InitializeData();
                txtCustomerName.Focus();

            }
        }
        void InitializeData()
        {
            txtCustomerCode.Text = customer.CustomerCode;
            cboCustomerType.Text = customer.CustomerType;
            txtCustomerName.Text = customer.CustomerName;
            cboSex.Text = customer.Sex;
            dtpDob.Text = customer.Dob;
            txtPhoneNumber.Text = customer.Phone;
            txtPassport.Text = customer.PassportNumber;
            txtCountry.Text = customer.Country;


        }
        private void OnCustomerSaved()
        {
            CustomerSaved?.Invoke(this, EventArgs.Empty);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (DoValidation())
            {
                this.customer.CustomerCode = txtCustomerCode.Text.Trim();
                this.customer.CustomerType = cboCustomerType.Text.Trim();
                this.customer.CustomerName = txtCustomerName.Text.Trim();
                this.customer.Sex = cboSex.Text.Trim();
                this.customer.Dob = Convert.ToString(dtpDob.Text); 
                this.customer.Phone = txtPhoneNumber.Text.Trim();
                this.customer.PassportNumber = txtPassport.Text.Trim();
                this.customer.Country = txtCountry.Text.Trim();

                if (newcustomer)
                {
                    Customers.Add(this.customer);
                }
                else
                {
                    Customers.Update(this.customer);
                }

                // Raise the event to notify subscribers
                OnCustomerSaved();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }
        private bool DoValidation()
        {
            bool result = true;
            if (txtCustomerName.Text.Trim() == "")
            {
                epCustomerName.SetError(txtCustomerName, "Please enter Customer Name");
                result = false;
            }
            return result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormCustomerAddEdit_Load(object sender, EventArgs e)
        {

        }
    }
    
}
