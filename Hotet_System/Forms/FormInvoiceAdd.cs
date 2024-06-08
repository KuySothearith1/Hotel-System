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
    public partial class FormInvoiceAdd : Form
    {
        FormMain formMain;
        public string Date, CustomerName, Checkin, CheckOut, Payment, RoomName; 
            public double Quantity, Price, Total;


        public FormInvoiceAdd(FormMain formMain)
        {
            InitializeComponent();
            this.formMain=formMain;
        }

        private void FormInvoiceAdd_Load(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
              
            FormInvoice formInvoice = new FormInvoice();
            formInvoice.CustomerName = txtCustomerName.Text;
            formInvoice.RoomName = txtRoomName.Text;
           
            
            if (cboPayment.SelectedIndex == -1)
                formInvoice.Payment ="";
            else 
                formInvoice.Payment = cboPayment.SelectedItem.ToString();
           
                double Quantity = Convert.ToDouble(txtND.Text);
                formInvoice.Quantity =txtND.Text;
                double Price = Convert.ToDouble(txtPrice.Text);
                formInvoice.Price = txtPrice.Text;

                double Total = Price * Quantity;
                txtTotal.Text = Total.ToString();
                formInvoice.Total =  Convert.ToString(txtTotal.Text);
                formInvoice.Checkin = Convert.ToString(dtpCheckIn.Text);
                formInvoice.CheckOut = Convert.ToString(dtpCheckOut.Text);


                formInvoice.ShowDialog();
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtRoomName.Clear();
            txtPrice.Clear();
            txtTotal.Clear();
            txtND.Clear();
            dtpCheckIn.Value = DateTime.Now;
            dtpCheckOut.Value = DateTime.Now;
            cboPayment.SelectedIndex = -1;
        }
    }
}
