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
    public partial class FormUserManagement : Form
    {
        DataTable dtUsers;
        DataTable dtUserPermission;
        FormMain formMain;
        public FormUserManagement(FormMain formMain)
        {
            InitializeComponent();
            InitializeData();
            this.formMain = formMain;
        }
        void InitializeData()
        {

           
            dtUsers = AppUsers.GetAll();
            dgUsers.DataSource = dtUsers;

            dgUsers.Columns[0].Visible =false;
            dgUsers.Columns[2].HeaderText = "USER NAME";
            dgUsers.Columns[2].Width = 200;
            dgUsers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgUsers.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgUsers.Columns[2].Visible = true;
            dgUsers.Columns[1].Visible =false;
            dgUsers.Columns[3].Visible =false;
            dgUsers.Columns[4].Visible =false;


        }

     
        void LoadUserPermission()
        {
            if (dgUsers.SelectedRows.Count <= 0)
                return;
            {
                int userid = Convert.ToInt32(dgUsers.SelectedRows[0].Cells["AppUserId"].Value.ToString());
                dtUserPermission = AppUserPermissions.Get(userid);
                foreach (Control control in this.pnPermission.Controls)
                {
                    if (control is CheckBox)
                    {
                        ((CheckBox)control).Checked = false;
                    }
                }
                if (dtUserPermission.Rows.Count > 0)
                {
                    foreach (DataRow row in dtUserPermission.Rows)
                    {
                        CheckBox permission =
                        (CheckBox)this.pnPermission.Controls[row["UserPermission"].ToString()];
                        if (permission != null)
                            permission.Checked = true;
                    }
                }

            }
        }

       

       

      

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnSelete_Click_1(object sender, EventArgs e)
        {
            foreach (Control control in this.pnPermission.Controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = true;
                }
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            foreach (Control control in this.pnPermission.Controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
            }
        }

        private void btnApply_Click_1(object sender, EventArgs e)
        {
            DialogResult confirmation;
            confirmation = MessageBox.Show("Do you really want to update user permission?",
            "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                if (dgUsers.SelectedRows.Count > 0)
                {
                    int userid =
                    Convert.ToInt32(dgUsers.SelectedRows[0].Cells["AppUserId"].Value.ToString());
                    AppUserPermissions.Delete(userid);
                    foreach (Control control in this.pnPermission.Controls)
                    {
                        if (control is CheckBox)
                        {
                            bool value = ((CheckBox)control).Checked;
                            if (value)
                            {
                                AppUserPermission permission = new AppUserPermission();
                                permission.AppUserId = userid;
                                permission.UserPermission = control.Name;
                                AppUserPermissions.Add(permission);
                            }
                        }
                    }
                }
            }
        }

        private void dgUsers_SelectionChanged_1(object sender, EventArgs e)
        {
            LoadUserPermission();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormUserManagementAddEdit formUserManagementAddEdit = new FormUserManagementAddEdit(null);
            if (formUserManagementAddEdit.ShowDialog() == DialogResult.OK)
            {
                InitializeData();
                dgUsers.Rows[dgUsers.Rows.Count - 1].Selected = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgUsers.SelectedRows.Count > 0)

            {
                int selectedrow = dgUsers.SelectedRows[0].Index;
                int userid =
                Convert.ToInt32(dgUsers.SelectedRows[0].Cells[0].Value);

                AppUser user = AppUsers.Get(userid);
                if (user != null)
                {
                    FormUserManagementAddEdit formUserManagementAddEdit = new FormUserManagementAddEdit(user);
                    if (formUserManagementAddEdit.ShowDialog() == DialogResult.OK)
                    {
                        InitializeData();
                        dgUsers.Rows[selectedrow].Selected = true;
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirmation;
            confirmation = MessageBox.Show("Do you really want to delete this user?",
            "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {

                int userid =
                Convert.ToInt32(dgUsers.SelectedRows[0].Cells["AppUserId"].Value.ToString());
                AppUserPermissions.Delete(userid);
                AppUsers.Delete(userid);
                MessageBox.Show("User had deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InitializeData();


            }
        }
    }
}
