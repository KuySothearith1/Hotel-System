using Hotet_System.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotet_System.Forms
{
    public partial class FormRoom : Form
    {
        DataTable dtRoom;
        FormMain formMain;
        public FormRoom(FormMain formMain)
        {
            InitializeComponent();
            InitializeData();
            this.formMain = formMain;
        }
        private void InitializeData()
        {
           
            dtRoom = Rooms.GetAll();

            dgRooms.DataSource = dtRoom;


            dgRooms.Columns[0].Visible =false;
            dgRooms.Columns[1].Visible =false;
            dgRooms.Columns[1].HeaderText = "Room List";
            dgRooms.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgRooms.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;

            dgRooms.Columns[2].Visible = true;
            dgRooms.Columns[2].Width = 370;
            dgRooms.Columns[3].Visible = true;
            dgRooms.Columns[3].Width = 370;
            dgRooms.Columns[4].Visible = true;
            dgRooms.Columns[4].Width = 370;
            dgRooms.Columns[5].Visible = false;
            dgRooms.Columns[5].Width = 370;
            dgRooms.Columns[6].Visible = true;
            dgRooms.Columns[6].Width = 370;
            dgRooms.Columns[6].DefaultCellStyle.Format = "#,##0.00$";
            dgRooms.Columns[7].Visible = false;
            dgRooms.Columns[7].Width = 370;
        



        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormRoomAddEdit formAddEdit = new FormRoomAddEdit(null);
            if (formAddEdit.ShowDialog() == DialogResult.OK)
            {
                InitializeData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgRooms.SelectedRows.Count >= 0)

            {
                int roomid = Convert.ToInt32(dgRooms.SelectedRows[0].Cells["RoomId"].Value.ToString());
                Room room = Rooms.Get(roomid);
                if (room == null)
                {
                    MessageBox.Show("Cannot find Item");
                }
                else
                {

                    FormRoomAddEdit formRoomAddEdit = new FormRoomAddEdit(room);
                    if (formRoomAddEdit.ShowDialog() == DialogResult.OK)
                    {
                        InitializeData();
                    }

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgRooms.SelectedRows.Count >= 0)
            {


                DialogResult confirm = MessageBox.Show("Are you sure to delete this Record?", "Confirm",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes)
                    return;

                int roomid = Convert.ToInt32(dgRooms.SelectedRows[0].Cells["RoomId"].Value.ToString());
                Rooms.Delete(roomid);

                MessageBox.Show("Room has Deleted Successfully");
                InitializeData();

            }
        }

        private void dgRooms_SelectionChanged(object sender, EventArgs e)
        {

            if (dgRooms.SelectedRows.Count <= 0)
                return;
            {

                int roomid = Convert.ToInt32(dgRooms.SelectedRows[0].Cells["RoomId"].Value.ToString());
                Room room = Rooms.Get(roomid);


                if (room != null)
                {
                    txtRoomName.Text = room.RoomName;
                    txtRoomType.Text = room.RoomType;
                    txtStatus.Text = room.Status;
                    txtPrice.Text = room.Price.ToString();

                    if (room.Image != null)
                    {
                        MemoryStream ms = new MemoryStream(room.Image);
                        Image image = System.Drawing.Image.FromStream(ms);
                        PicImage.Image = image;
                    }
                    else
                    {
                        PicImage.Image = null;
                    }

                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchString = txtSearch.Text;
            string connectionString = "Data Source=192.168.56.1:1521/XEPDB1;User Id=MyHotelData; Password=12345;";

            string sql = "SELECT * FROM Room WHERE RoomType LIKE :searchString";

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
                            dgRooms.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching data: " + ex.Message);
            }

        }

        private void dgRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PicImage_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormRoom_Load(object sender, EventArgs e)
        {
            InitializeData();

            DataTable dtUserPermission = AppUserPermissions.Get(formMain.UserLogin.AppUserId);
            foreach (DataRow row in dtUserPermission.Rows)
            {
                if (row["UserPermission"].ToString() == "RoomCreate")
                {
                    btnNew.Visible = true;
                }

                if (row["UserPermission"].ToString() == "RoomModify")
                {
                    btnEdit.Visible = true;
                }

                if (row["UserPermission"].ToString() == "RoomDelete")
                {
                    btnDelete.Visible = true;

                }
            }
        }
    }
}
