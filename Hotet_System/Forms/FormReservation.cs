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
    public partial class FormReservation : Form
    {
        DataTable dtReservation;
        DataTable dtReservationDetail;
        BindingSource bsReservation;
        FormMain formMain;
        public FormReservation(FormMain formMain)
        {
            this.formMain = formMain;
            InitializeComponent();
            InitializeData();

            cboCheckin.Items.Add("Already");
            cboCheckin.Items.Add("Note Yet");
            cboCheckOut.Items.Add("Already");
            cboCheckOut.Items.Add("Not Yet");
            cboPayment.Items.Add("Already");
            cboPayment.Items.Add("Not Yet");

        }
        void InitializeData()
        {
            LoadCustomer();  
            LoadReservation();

        }
        void LoadReservation()
        {
            dtReservation = Reservations.GetAll();
            bsReservation = new BindingSource();
            bsReservation.DataSource = dtReservation;

            txtReservationId.DataBindings.Clear();
            txtReservationId.DataBindings.Add(new Binding("Text", bsReservation, "ReservationId"));
            cboCustomer.DataBindings.Clear();
            cboCustomer.DataBindings.Add(new Binding("SelectedValue", bsReservation, "CustomerId"));
            dtpCheckIn.DataBindings.Clear();
            dtpCheckIn.DataBindings.Add(new Binding("Text", bsReservation, "CheckInDate", true));
            cboCheckin.DataBindings.Clear();
            cboCheckin.DataBindings.Add(new Binding("Text", bsReservation, "IsCheckIn"));
            //txtND.DataBindings.Clear();
            //txtND.DataBindings.Add(new Binding("Text", bsReservation, "NumberofDay"));
            txtNA.DataBindings.Clear();
            txtNA.DataBindings.Add(new Binding("Text", bsReservation, "NumberofAdult"));
            txtNC.DataBindings.Clear();
            txtNC.DataBindings.Add(new Binding("Text", bsReservation, "NumberofChildrens"));
            txtMemo.DataBindings.Clear();
            txtMemo.DataBindings.Add(new Binding("Text", bsReservation, "Memo"));
            dtpCheckOut.DataBindings.Clear();
            dtpCheckOut.DataBindings.Add(new Binding("Text", bsReservation, "CheckOutDate", true));
            cboPayment.DataBindings.Clear();
            cboPayment.DataBindings.Add(new Binding("Text", bsReservation, "IsPay"));
            cboCheckOut.DataBindings.Clear();
            cboCheckOut.DataBindings.Add(new Binding("Text", bsReservation, "IsCheckOut"));



            LoadReservationDetail();
        }

        void LoadReservationDetail()
        {
            if (bsReservation.Count <= 0)
            {
                dtReservationDetail = ReservationDetails.Get(0);
            }
            else
            {
                DataRowView current = (DataRowView)bsReservation.Current;
                int reservationid = Convert.ToInt32(current["ReservationId"].ToString());
                dtReservationDetail = ReservationDetails.Get(reservationid);
            }
            dgReservationDetail.Columns[0].Visible = false;
            dgReservationDetail.Columns[0].DataPropertyName = "ReservationDetailId";

            dgReservationDetail.Columns[1].Visible = false;
            dgReservationDetail.Columns[1].DataPropertyName = "ReservationId";
           
            

            dgReservationDetail.Columns[2].Visible = true;
            dgReservationDetail.Columns[2].HeaderText = "Room Name";
            dgReservationDetail.Columns[2].Width = 250;
            dgReservationDetail.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgReservationDetail.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgReservationDetail.Columns[2].DataPropertyName = "RoomId"; DataGridViewComboBoxColumn column = (DataGridViewComboBoxColumn)dgReservationDetail.Columns[2];
            column.DisplayMember = "RoomName";
            column.ValueMember = "RoomId";
            column.DataSource = Rooms.GetAll();

            dgReservationDetail.Columns[3].Visible = true;
            dgReservationDetail.Columns[3].HeaderText = "Room Type";
            dgReservationDetail.Columns[3].Width = 250;
            dgReservationDetail.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgReservationDetail.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgReservationDetail.Columns[3].DataPropertyName = "RoomId"; DataGridViewComboBoxColumn column1 = (DataGridViewComboBoxColumn)dgReservationDetail.Columns[3];
            column1.DisplayMember = "RoomType";
            column1.ValueMember = "RoomType";
            column1.DataSource = Rooms.GetAll();
            dgReservationDetail.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgReservationDetail.Columns[3].DataPropertyName = "RoomType";

            dgReservationDetail.Columns[4].Visible = true;
            dgReservationDetail.Columns[4].HeaderText = "Room Status";
            dgReservationDetail.Columns[4].Width = 250;
            dgReservationDetail.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgReservationDetail.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgReservationDetail.Columns[4].DataPropertyName = "RoomId"; DataGridViewComboBoxColumn column2 = (DataGridViewComboBoxColumn)dgReservationDetail.Columns[4];
            column2.DisplayMember = "Status";
            column2.ValueMember = "Status";
            column2.DataSource = Rooms.GetAll();
            dgReservationDetail.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgReservationDetail.Columns[4].DataPropertyName = "Status";

            dgReservationDetail.Columns[5].Visible = true;
            dgReservationDetail.Columns[5].HeaderText = "Number Of Day";
            dgReservationDetail.Columns[5].Width = 250;
            dgReservationDetail.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgReservationDetail.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgReservationDetail.Columns[5].DataPropertyName = "Quantity";

            dgReservationDetail.Columns[6].Visible = true;
            dgReservationDetail.Columns[6].HeaderText = "Price";
            dgReservationDetail.Columns[6].Width = 250;
            dgReservationDetail.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgReservationDetail.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgReservationDetail.Columns[6].DefaultCellStyle.Format = "#,##0.00$";
            dgReservationDetail.Columns[6].DataPropertyName = "Price";

            dgReservationDetail.Columns[7].Visible = true;
            dgReservationDetail.Columns[7].HeaderText = "Total";
            dgReservationDetail.Columns[7].Width = 250;
            dgReservationDetail.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgReservationDetail.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgReservationDetail.Columns[7].DefaultCellStyle.Format = "#,##0.00$";
            dgReservationDetail.Columns[7].DataPropertyName = "Amount";

            


            dgReservationDetail.DataSource = dtReservationDetail;
        }
        void LoadCustomer()
        {
            DataTable dtCustomer = Customers.GetAll();
            cboCustomer.DataSource = dtCustomer;
            cboCustomer.DisplayMember = "CustomerName";
            cboCustomer.ValueMember = "CustomerId";
        }
        void AllowEditSale(bool value)
        {
            cboCustomer.Enabled = value;
            dtpCheckIn.Enabled = value;
            cboCheckin.Enabled = value;
            //txtND.Enabled = value;
            txtNA.Enabled = value;
            txtNC.Enabled = value;
            txtMemo.Enabled = value;
            dtpCheckOut.Enabled = value;  
            cboCheckOut.Enabled = value;
            cboPayment.Enabled = value;

            dgReservationDetail.Enabled = value;
            btnSave.Enabled = value;
        }

        
        private void FormReservation_Load(object sender, EventArgs e)
        {
            dgReservationDetail.DataError += dgReservationDetail_DataError;

            LoadCustomer(); 
            LoadReservation();
            AllowEditSale(false);
            InitializeData();
            DataTable dtUserPermission = AppUserPermissions.Get(formMain.UserLogin.AppUserId);
            foreach (DataRow row in dtUserPermission.Rows)
            {
                if (row["UserPermission"].ToString() == "ReservationCreate")
                {
                    btnNew.Visible = true;
                    btnSave.Visible = true;
                }
                if (row["UserPermission"].ToString() == "ReservationModify")
                {
                    btnEdit.Visible = true;

                }

                if (row["UserPermission"].ToString() == "ReservationDelete")
                {
                    btnDelete.Visible = true;
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bsReservation.AddNew();
            dtReservationDetail.Rows.Clear();
            AllowEditSale(true);
            btnSave.Text = "Save";
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        

        

        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AllowEditSale(true);
            btnSave.Text = "Update";
        }

     
       

      

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bsReservation.Count <= 0)
                return;
            DialogResult confirmation = MessageBox.Show(
            "Are you sure to delete this record?",
            "Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (confirmation != DialogResult.Yes)
                return;
            int reservationid = Convert.ToInt32(txtReservationId.Text);
            ReservationDetails.Delete(reservationid);
            Reservations.Delete(reservationid);
            MessageBox.Show("Reservation has deleted successfully");
            InitializeData();

           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgReservationDetail.EndEdit();
            if (!DoValidation())
                return;
            DataRowView datarow = (DataRowView)bsReservation.Current;
            if (datarow.IsNew)
            {
                if (DoValidation())
                {
                    Reservation reservation = new Reservation();
                    reservation.CustomerId = Convert.ToInt32(cboCustomer.SelectedValue);
                    reservation.CheckInDate = dtpCheckIn.Value;
                    reservation.IsCheckIn = cboCheckin.Text.Trim();
                    //reservation.NumberOfDay = txtND.Text.Trim();
                    reservation.NumberOfAdult =Convert.ToInt32(txtNA.Text.Trim());
                    reservation.NumberOfChildrens = Convert.ToInt32(txtNC.Text.Trim());
                    reservation.Memo = txtMemo.Text.Trim();
                    reservation.CheckOutDate = dtpCheckOut.Value;
                    reservation.IsPay = cboPayment.Text.Trim();
                    reservation.IsCheckOut = cboCheckOut.Text.Trim();

                    int reservationid = Reservations.Add(reservation);
                    if (reservationid > 0)
                    {
                        dtReservationDetail.Columns["ReservationId"].DefaultValue = reservationid;
                        dgReservationDetail.Refresh();
                        dtReservationDetail.AcceptChanges();
                        foreach (DataRow row in dtReservationDetail.Rows)

                        {
                            ReservationDetail reservationDetail = new ReservationDetail();
                            reservationDetail.ReservationId = reservationid;
                            reservationDetail.RoomId = Convert.ToInt32(row["RoomId"].ToString());
                            reservationDetail.RoomType = row["RoomType"].ToString();
                            reservationDetail.Status = row["Status"].ToString();
                            reservationDetail.Quantity = Convert.ToDouble(row["Quantity"].ToString());
                            reservationDetail.Price = Convert.ToDouble(row["Price"].ToString());
                            ReservationDetails.Add(reservationDetail);
                        }
                    }
                    MessageBox.Show("Reservation has added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InitializeData();
                    AllowEditSale(false);
                    LoadReservation();
                }
            }
            else
            {
                if (DoValidation())
                {

                    Reservation reservation = new Reservation();
                    reservation.ReservationId = Convert.ToInt32(txtReservationId.Text);
                    reservation.CustomerId = Convert.ToInt32(cboCustomer.SelectedValue);
                    reservation.CheckInDate = dtpCheckIn.Value;
                    reservation.IsCheckIn = cboCheckin.Text.ToString();
                    //reservation.NumberOfDay = txtND.Text.Trim(); 
                    reservation.NumberOfAdult = Convert.ToInt32(txtNA.Text.Trim());
                    reservation.NumberOfChildrens = Convert.ToInt32(txtNC.Text.Trim());
                    reservation.Memo = txtMemo.Text.Trim();
                    reservation.CheckOutDate = dtpCheckOut.Value;
                    reservation.IsPay = cboPayment.Text.ToString();
                    reservation.IsCheckOut = cboCheckOut.Text.ToString();
                    Reservations.Update(reservation);
                    ReservationDetails.Delete(reservation.ReservationId);
                    dgReservationDetail.Refresh();
                    dtReservationDetail.AcceptChanges();


                    foreach (DataRow row in dtReservationDetail.Rows)
                    {
                        ReservationDetail reservationDetail = new ReservationDetail();
                        reservationDetail.ReservationId = reservation.ReservationId;
                        reservationDetail.RoomId = Convert.ToInt32(row["RoomId"].ToString());
                        reservationDetail.RoomType = row["RoomType"].ToString();
                        reservationDetail.Status = row["Status"].ToString();
                        reservationDetail.Quantity = Convert.ToDouble(row["Quantity"].ToString());
                        reservationDetail.Price = Convert.ToDouble(row["Price"].ToString());
                        reservationDetail.Amount = Convert.ToDouble(row["Amount"].ToString()); 
                        ReservationDetails.Add(reservationDetail);
                        

                    }
                    MessageBox.Show("Reservation has updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InitializeData();
                    AllowEditSale(false);
                }
            }
            bool DoValidation()
            {
                bool result = true;
                if (cboCustomer.SelectedIndex < 0)
                {
                    epCustomers.SetError(cboCustomer, "Please enter Customer name");
                    result = false;
                }
                return result;
            }
        }

        private void dgReservationDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgReservationDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= 0)
                return;
            if (e.ColumnIndex == 5 && e.ColumnIndex == 6)
            {
                double Quanity, Price, TotalPrice;
                double.TryParse(dgReservationDetail.SelectedRows[0].Cells[5].Value.ToString(), out Quanity);
                double.TryParse(dgReservationDetail.SelectedRows[0].Cells[6].Value.ToString(), out Price);
                TotalPrice = Quanity * Price;
                dgReservationDetail.SelectedRows[0].Cells[6].Value = TotalPrice;
            }
        }

        private void dgReservationDetail_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception is FormatException)
            {

                if
                    (e.ColumnIndex >= 0 && e.ColumnIndex < dgReservationDetail.Columns.Count &&
                         dgReservationDetail.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn) ;



            }
        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

       
        

       

       
        private void btnPervious_Click_2(object sender, EventArgs e)
        {
            bsReservation.CancelEdit();
            bsReservation.MovePrevious();
            
            LoadReservationDetail();
        }

        private void btnNext_Click_2(object sender, EventArgs e)
        {
            
            bsReservation.CancelEdit();
            bsReservation.MoveNext();
            LoadReservationDetail();
            
        }
    }
}
