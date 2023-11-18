using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_LibraryApplication.Database;

namespace WF_LibraryApplication.UIForms
{
    public partial class frmMainUser : Form
    {

        readonly object databaseLock = new object();
        private delegate void SafeCallDelegate(DataTable dt);
        public frmMainUser()
        {
            InitializeComponent();
        }

        private void frmMainUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'localDatabaseDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.localDatabaseDataSet.Table);

        }

        private void tableBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.localDatabaseDataSet);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(WriteToDB);
            thread1.Name = "Thread_1";

            Thread thread2 = new Thread(WriteToDB);
            thread2.Name = "Thread_2";

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();
        }

        void WriteToDB()
        {
            try
            {
                lock (databaseLock)
                {
                    using (SqlConnection connection = new SqlConnection(DatabaseManager.LocalDbConnectionString))
                    {
                        connection.Open();
                        int n = 50000;
                        for (int i = 1; i < n; i++)
                        {
                            string qrInsert =
                                $"INSERT INTO [dbo].[Table] " +
                                $"VALUES ({i}, '{Thread.CurrentThread.Name}')";
                            SqlCommand sqlCommand = new SqlCommand(qrInsert, connection);
                            sqlCommand.ExecuteNonQuery();
                            bgWorker.ReportProgress( i / n * 100);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.Fill(this.localDatabaseDataSet.Table);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefreshInBack_Click(object sender, EventArgs e)
        {
            bgWorker.WorkerSupportsCancellation = true;
            btnRefreshInBack.Enabled = false;

            if (!bgWorker.IsBusy)
                bgWorker.RunWorkerAsync();
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            using (SqlConnection conn = new SqlConnection(DatabaseManager.LocalDbConnectionString))
            {
                conn.Open();

                int n = 50000;
                for (int i = 1; i < n; i++)
                {
                    string qrInsert =
                        $"INSERT INTO [dbo].[Table] " +
                        $"VALUES ({i}, 'bgWorker')";
                    SqlCommand sqlCommand = new SqlCommand(qrInsert, conn);
                    sqlCommand.ExecuteNonQuery();
                    bgWorker.ReportProgress(100 * i / n );
                }


                using (SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[Table]", conn))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                       
                        DataRow dr;
                        while (rdr.Read())
                        {
                            Invoke(new MethodInvoker(delegate
                            {
                                tableDataGridView.ReadOnly = true;
                                dr = localDatabaseDataSet.Table.NewRow();
                                dr[0] = rdr.GetInt32(0);
                                dr[1] = rdr.GetString(1).ToString();
                                localDatabaseDataSet.Table.Rows.Add(dr);
                                
                            }));
                        }
                    }
                }
            }
 
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                toolStripProgressBar1.Value = e.ProgressPercentage;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("BgWorker Finished Work");
            tableDataGridView.Enabled = true;
        }

        private void FillDataGrid(DataTable dt)
        {
            if (this.InvokeRequired)
            {
                var d = new SafeCallDelegate(FillDataGrid);
                Invoke(d, new object[] { dt });
            }
            else
            {
                //...
                DataGridFiller(dt);
            }
        }

        private void DataGridFiller(DataTable dt)
        {
            BindingSource dataSource = new BindingSource(dt, null);
            tableDataGridView.DataSource = dataSource;
        }
    }
}
