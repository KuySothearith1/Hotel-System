using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotet_System.Forms
{
    public partial class FormInvoice : Form
    {
        public string Date,CustomerName,Checkin,CheckOut,Payment,RoomName,Quantity,Price,Total;

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtND_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtRoom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCheckOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtCheckIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Print(this.panelPrint);
        }

        private void printInvoice_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width /2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
        }

        public FormInvoice()
        {
            InitializeComponent();
            Date = DateTime.Now.ToString("dddd,dd,MMMM,yyyy");
        }

        private void Print(Panel pn1)
        {
            PrinterSettings PS =new PrinterSettings();
            panelPrint = pn1;
            getprintarea(pn1);
            printInvoiceDialog.Document =printInvoice;
            printInvoice.PrintPage += new PrintPageEventHandler(printInvoice_PrintPage);
            printInvoiceDialog.ShowDialog();
        }

        private Bitmap memoryimg;
        private void getprintarea(Panel pn1)
        {
            memoryimg = new Bitmap(pn1.Width, pn1.Height);
            pn1.DrawToBitmap(memoryimg,new Rectangle(0,0,pn1.Width,pn1.Height));
        }
        private void FormInvoice_Load(object sender, EventArgs e)
        {
            txtDate.Text =Date;
            txtCustomerName.Text =CustomerName;
            txtCheckOut.Text =CheckOut;
            txtCheckIn.Text = Checkin;
            txtPayment.Text = Payment;
            txtRoom.Text = RoomName;
            txtPrice.Text = Price;
            txtND.Text = Quantity;
            txtTotal.Text= Total;
        }
    }
}
