using Hotet_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotet_System.Forms
{
    public partial class FormRoomAddEdit : Form
    {
        bool newroom;
        Room room;
        public FormRoomAddEdit(Room room)
        {
            

            InitializeComponent();
            cboRoomType.Items.Add("Singel Room");
            cboRoomType.Items.Add("Double Room");
            cboRoomType.Items.Add("Triple Room");
            cboRoomType.Items.Add("Duplex Room");
            cboRoomType.Items.Add("Cabana");
            cboRoomType.Items.Add("Premium  Room");
            cboStatus.Items.Add("Available");
            cboStatus.Items.Add("Busy");
            if (room == null)
            {
                lblTitle.Text = "New Room";
                btnSave.Text = "Save";
                this.newroom = true;
                this.room = new Room();
                txtRoomName.Focus();
            }
            else
            {
                lblTitle.Text = "Edit Room";
                btnSave.Text = "Update";
                this.newroom = false;
                this.room = room;
                txtRoomName.Focus();
                txtRoomName.Text = room.RoomName;
                cboRoomType.Text = room.RoomType;
                cboStatus.Text = room.Status.ToString();
                txtPrice.Text = room.Price.ToString();

                if (room.Image != null)
                {
                    MemoryStream ms = new MemoryStream(room.Image);
                    Image image = System.Drawing.Image.FromStream(ms);
                    Image.Image = image;
                }
                else
                {
                    Image.Image = null;
                }

                this.room = room;



            }
        }

        

        private void btnBrowe_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            this.Image.Load(dialog.FileName);
        }
        private bool DoValidation()
        {
            bool result = true;
            if (txtRoomName.Text.Trim() == "")
            {
                epRoomName.SetError(txtRoomName, "Please enter Room Number");
                result = false;
            }
            return result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DoValidation())

            {

                this.room.RoomName = txtRoomName.Text.Trim();
                this.room.RoomType = cboRoomType.Text.Trim();
                this.room.Status = cboStatus.Text.Trim();
                this.room.Price = Convert.ToDouble(txtPrice.Text.Trim());


                if (Image.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        Image.Image.Save(ms, ImageFormat.Jpeg);
                        byte[] image = ms.ToArray();
                        room.Image = image;
                    }
                }


                if (newroom)
                {
                    Rooms.Add(this.room);
                }
                else
                {
                    Rooms.Update(this.room);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
