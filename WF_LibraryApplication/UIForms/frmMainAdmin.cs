using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_LibraryApplication.Helpers;

namespace WF_LibraryApplication.UIForms
{
    enum Gender
    {
        Male,
        Female
    }

    public partial class frmMainAdmin : Form
    {
        bool dataChanged = false;
        DataTable dt;

        public frmMainAdmin()
        {
            InitializeComponent();

            dgvUsersData.DataError += new DataGridViewDataErrorEventHandler(dataGridView_DataError);

            dt = dsGender.Tables[0];
            DataRow dr;
            Array array = System.Enum.GetValues(typeof(Gender));
            foreach(Gender g in array)
            {
                dr = dt.NewRow();
                dr[0] = g;
                dt.Rows.Add(dr);
            }

            dr = dt.NewRow();
            dr[0] = "";
            dt.Rows.Add(dr);
            
            

        }


        void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                spGetAllUsersInfoTableAdapter.Adapter.Update(dsGetAllUsersInfo);
                MessageBox.Show("DB Updated");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMainAdmin_Load(object sender, EventArgs e)
        {
            

            // TODO: This line of code loads data into the 'dsGetAllUsersRoles.spGetAllUsersRoles' table. You can move, or remove it, as needed.
            this.spGetAllUsersRolesTableAdapter.Fill(this.dsGetAllUsersRoles.spGetAllUsersRoles);
            // TODO: This line of code loads data into the 'dsGetAllUsersInfo.spGetAllUsersInfo' table. You can move, or remove it, as needed.
            this.spGetAllUsersInfoTableAdapter.Fill(this.dsGetAllUsersInfo.spGetAllUsersInfo);

            //DataGridViewComboBoxColumn kvCol = dgvUsersData.Columns["gender"] as DataGridViewComboBoxColumn;
            //kvCol.ValueType = typeof(String);

            

        }

        void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        // Add code in user interface
        

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dataRow = dsGetAllUsersInfo.Tables[0].NewRow();
                dataRow["login"] = "";
                dataRow["password"] = "";
                dsGetAllUsersInfo.Tables[0].Rows.Add(dataRow);

                dgvUsersData.ClearSelection();
                dgvUsersData.Rows[dgvUsersData.Rows.Count - 1].Selected = true;
                dgvUsersData.FirstDisplayedScrollingRowIndex = dgvUsersData.Rows.Count - 1;

                DataRow[] roles = dsGetAllUsersRoles.Tables[0].Select("role = 'User'");
                int userCode = 0;
                if (roles != null)
                    userCode = int.Parse(roles[0][1].ToString().Trim());
                //foreach (DataRow rolesRow in roles)
                //{
                //    userCode = int.Parse(rolesRow.ToString().Trim());
                //}

                DataRow row = dsGetAllUsersRoles.Tables[0].NewRow();
                row["userId"] = dataRow["id"];
                row["roleId"] = userCode;
                row["role"] = "User";
                dsGetAllUsersRoles.Tables[0].Rows.Add(row);



                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemoveRow_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =
                MessageBox.Show("Delete Row?", "Alert",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if(dialogResult == DialogResult.OK)
            {
                foreach (DataGridViewRow row in dgvUsersData.SelectedRows)
                    dgvUsersData.Rows.Remove(row);
            }
                
        }

        private void dgvUsersData_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dialogResult =
                MessageBox.Show("Delete Row?", "Alert",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvUsersData.Rows)
            {
                row.Selected = false;
                foreach(DataGridViewCell cell in row.Cells)
                    if(cell.Value != null && cell.Value.ToString().Contains(tbStrToFind.Text))
                    {
                        row.Selected = true;
                        break;
                    }
                //if (row.Selected)
                    //break;
            }
        }

        private void tbLoginToFind_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void tbNameToFind_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            (dgvUsersData.DataSource as BindingSource).Filter =
                $"login like '%{tbLoginToFind.Text}%' and fullName like '%{tbNameToFind.Text}%'";
        }

        private void frmMainAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(dataChanged)
            {
                DialogResult dialogResult =
                    MessageBox.Show("Save your changes?", "Alert",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        btnSave_Click(null, null);
                        break;
                    case DialogResult.No:
                        e.Cancel = false;
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void dgvUsersData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dataChanged = true;
        }

        private void dgvUsersData_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            dataChanged = true;
        }

        private void dgvUsersData_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            dataChanged = true;
        }

        private void dgvUsersData_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            string cName = dgv.Columns[e.ColumnIndex].Name;
            string cellValue = e.FormattedValue.ToString().Trim();
            //MessageBox.Show(cName);
            String msg = null;
            switch(cName)
            {
                case "login":
                    msg = ValidationEngine.ValidateLoginErrorMessage(cellValue);
                    break;    
            }
            dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = msg;

        }

        private void dgvUsersData_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsersData.SelectedRows.Count == 1)
                    (dgvUserRoles.DataSource as BindingSource).Filter =
                        $"Convert(userId, 'System.String') like '{dgvUsersData.SelectedRows[0].Cells[0].Value.ToString().Trim()}'";
                else
                    (dgvUserRoles.DataSource as BindingSource).Filter =
                        $"Convert(userId, 'System.String') = null";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
