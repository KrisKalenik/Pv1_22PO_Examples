namespace WF_LibraryApplication.UIForms
{
    partial class frmMainAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.dgvUsersData = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsGender = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spGetAllUsersInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsGetAllUsersInfo = new WF_LibraryApplication.dsGetAllUsersInfo();
            this.tbStrToFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbLoginToFind = new System.Windows.Forms.TextBox();
            this.tbNameToFind = new System.Windows.Forms.TextBox();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnRemoveRow = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvUserRoles = new System.Windows.Forms.DataGridView();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spGetAllUsersRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsGetAllUsersRoles = new WF_LibraryApplication.dsGetAllUsersRoles();
            this.spGetAllUsersInfoTableAdapter = new WF_LibraryApplication.dsGetAllUsersInfoTableAdapters.spGetAllUsersInfoTableAdapter();
            this.spGetAllUsersRolesTableAdapter = new WF_LibraryApplication.dsGetAllUsersRolesTableAdapters.spGetAllUsersRolesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetAllUsersInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGetAllUsersInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetAllUsersRolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGetAllUsersRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(713, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // dgvUsersData
            // 
            this.dgvUsersData.AllowUserToAddRows = false;
            this.dgvUsersData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsersData.AutoGenerateColumns = false;
            this.dgvUsersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.login,
            this.passwordDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.gender,
            this.birthdayDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dgvUsersData.DataSource = this.spGetAllUsersInfoBindingSource;
            this.dgvUsersData.Location = new System.Drawing.Point(12, 71);
            this.dgvUsersData.Name = "dgvUsersData";
            this.dgvUsersData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsersData.Size = new System.Drawing.Size(854, 233);
            this.dgvUsersData.TabIndex = 1;
            this.dgvUsersData.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvUsersData_CellValidating);
            this.dgvUsersData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsersData_CellValueChanged);
            this.dgvUsersData.SelectionChanged += new System.EventHandler(this.dgvUsersData_SelectionChanged);
            this.dgvUsersData.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvUsersData_UserAddedRow);
            this.dgvUsersData.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvUsersData_UserDeletedRow);
            this.dgvUsersData.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvUsersData_UserDeletingRow);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // login
            // 
            this.login.DataPropertyName = "login";
            this.login.HeaderText = "Логин";
            this.login.Name = "login";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "fullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "fullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gender.DataPropertyName = "gender";
            this.gender.DataSource = this.dsGender;
            this.gender.DisplayMember = "Genders.type";
            this.gender.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.gender.HeaderText = "gender";
            this.gender.Name = "gender";
            this.gender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gender.ValueMember = "Genders.type";
            this.gender.Width = 65;
            // 
            // dsGender
            // 
            this.dsGender.DataSetName = "NewDataSet";
            this.dsGender.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1});
            this.dataTable1.TableName = "Genders";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "type";
            this.dataColumn1.MaxLength = 20;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // spGetAllUsersInfoBindingSource
            // 
            this.spGetAllUsersInfoBindingSource.DataMember = "spGetAllUsersInfo";
            this.spGetAllUsersInfoBindingSource.DataSource = this.dsGetAllUsersInfo;
            // 
            // dsGetAllUsersInfo
            // 
            this.dsGetAllUsersInfo.DataSetName = "dsGetAllUsersInfo";
            this.dsGetAllUsersInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbStrToFind
            // 
            this.tbStrToFind.Location = new System.Drawing.Point(12, 35);
            this.tbStrToFind.Name = "tbStrToFind";
            this.tbStrToFind.Size = new System.Drawing.Size(100, 20);
            this.tbStrToFind.TabIndex = 2;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(118, 35);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbLoginToFind
            // 
            this.tbLoginToFind.Location = new System.Drawing.Point(234, 35);
            this.tbLoginToFind.Name = "tbLoginToFind";
            this.tbLoginToFind.Size = new System.Drawing.Size(100, 20);
            this.tbLoginToFind.TabIndex = 4;
            this.tbLoginToFind.TextChanged += new System.EventHandler(this.tbLoginToFind_TextChanged);
            // 
            // tbNameToFind
            // 
            this.tbNameToFind.Location = new System.Drawing.Point(352, 35);
            this.tbNameToFind.Name = "tbNameToFind";
            this.tbNameToFind.Size = new System.Drawing.Size(100, 20);
            this.tbNameToFind.TabIndex = 5;
            this.tbNameToFind.TextChanged += new System.EventHandler(this.tbNameToFind_TextChanged);
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(429, 322);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(75, 23);
            this.btnAddRow.TabIndex = 6;
            this.btnAddRow.Text = "Add Row";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnRemoveRow
            // 
            this.btnRemoveRow.Location = new System.Drawing.Point(510, 322);
            this.btnRemoveRow.Name = "btnRemoveRow";
            this.btnRemoveRow.Size = new System.Drawing.Size(93, 23);
            this.btnRemoveRow.TabIndex = 7;
            this.btnRemoveRow.Text = "Remove Row";
            this.btnRemoveRow.UseVisualStyleBackColor = true;
            this.btnRemoveRow.Click += new System.EventHandler(this.btnRemoveRow_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(713, 322);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvUserRoles
            // 
            this.dgvUserRoles.AutoGenerateColumns = false;
            this.dgvUserRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdDataGridViewTextBoxColumn,
            this.roleIdDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dgvUserRoles.DataSource = this.spGetAllUsersRolesBindingSource;
            this.dgvUserRoles.Location = new System.Drawing.Point(12, 322);
            this.dgvUserRoles.Name = "dgvUserRoles";
            this.dgvUserRoles.Size = new System.Drawing.Size(343, 116);
            this.dgvUserRoles.TabIndex = 9;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "userId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "userId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // roleIdDataGridViewTextBoxColumn
            // 
            this.roleIdDataGridViewTextBoxColumn.DataPropertyName = "roleId";
            this.roleIdDataGridViewTextBoxColumn.HeaderText = "roleId";
            this.roleIdDataGridViewTextBoxColumn.Name = "roleIdDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // spGetAllUsersRolesBindingSource
            // 
            this.spGetAllUsersRolesBindingSource.DataMember = "spGetAllUsersRoles";
            this.spGetAllUsersRolesBindingSource.DataSource = this.dsGetAllUsersRoles;
            // 
            // dsGetAllUsersRoles
            // 
            this.dsGetAllUsersRoles.DataSetName = "dsGetAllUsersRoles";
            this.dsGetAllUsersRoles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spGetAllUsersInfoTableAdapter
            // 
            this.spGetAllUsersInfoTableAdapter.ClearBeforeFill = true;
            // 
            // spGetAllUsersRolesTableAdapter
            // 
            this.spGetAllUsersRolesTableAdapter.ClearBeforeFill = true;
            // 
            // frmMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.dgvUserRoles);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemoveRow);
            this.Controls.Add(this.btnAddRow);
            this.Controls.Add(this.tbNameToFind);
            this.Controls.Add(this.tbLoginToFind);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tbStrToFind);
            this.Controls.Add(this.dgvUsersData);
            this.Controls.Add(this.btnLogOut);
            this.Name = "frmMainAdmin";
            this.Text = "frmMainAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainAdmin_FormClosing);
            this.Load += new System.EventHandler(this.frmMainAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetAllUsersInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGetAllUsersInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetAllUsersRolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGetAllUsersRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DataGridView dgvUsersData;
        private System.Windows.Forms.TextBox tbStrToFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbLoginToFind;
        private System.Windows.Forms.TextBox tbNameToFind;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnRemoveRow;
        private System.Windows.Forms.Button btnSave;
        private dsGetAllUsersInfo dsGetAllUsersInfo;
        private System.Windows.Forms.BindingSource spGetAllUsersInfoBindingSource;
        private dsGetAllUsersInfoTableAdapters.spGetAllUsersInfoTableAdapter spGetAllUsersInfoTableAdapter;
        private System.Windows.Forms.DataGridView dgvUserRoles;
        private dsGetAllUsersRoles dsGetAllUsersRoles;
        private System.Windows.Forms.BindingSource spGetAllUsersRolesBindingSource;
        private dsGetAllUsersRolesTableAdapters.spGetAllUsersRolesTableAdapter spGetAllUsersRolesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Data.DataSet dsGender;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
    }
}