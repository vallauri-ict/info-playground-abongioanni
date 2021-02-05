using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TriggerForm
{
    public partial class FormDrivers : Form
    {       
        public static string[] tables = { "Driver", "StoricoCancellazioni", "StoricoAggiornamenti" };
        public static object oldValue;
        public FormDrivers()
        {
            InitializeComponent();
            dgv.Height = ClientSize.Height - toolStrip.Height; //this => parent form
            dgv.Width = ClientSize.Width;
            dgv.Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.MultiSelect = false;

            Reset();
        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dgv.Columns[dgv.CurrentCell.ColumnIndex].Name;
            int number = Convert.ToInt32(dgv.CurrentRow.Cells["number"].Value);
            object newValue = dgv.CurrentCell.Value;
            Update(columnName, number, newValue);
        }

        /*private void dgv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldValue = dgv.CurrentCell.Value;
        }*/

        private void tsbNew_Click(object sender, EventArgs e)
        {
            FormInsert frm = new FormInsert();
            Visible = false;
            frm.ShowDialog();
            Visible = true;
            Reset();
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count != 0 && 
                MessageBox.Show("Are you sure to delete selected item?", "WARNING", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int number = Convert.ToInt32(dgv.CurrentRow.Cells["number"].Value);
                string sql = $"DELETE FROM Driver WHERE number={number};";

                Commons.Query(sql);
                Reset();
            }
        }

        private void leftbtn_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(leftbtn.Tag);

            switch (index)
            {
                case 0:
                    {
                        leftbtn.Enabled = false;
                        rightbtn.Tag = index + 1;
                        dgv.ReadOnly = false;
                        dgv.Columns["number"].ReadOnly = true;
                        tsbNew.Enabled = tsbCancel.Enabled = true;
                    }
                    break;
                case 1:
                    {
                        leftbtn.Tag = index - 1;
                        rightbtn.Tag = index + 1;
                        rightbtn.Enabled = true;
                        dgv.ReadOnly = true;
                        tsbNew.Enabled = tsbCancel.Enabled = false;
                    }
                    break;
            }

            dgv.DataSource = GetDataTable(tables[index]);
        }

        private void rightbtn_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(rightbtn.Tag);

            switch (index)
            {
                case 1:
                    {
                        leftbtn.Tag = index - 1;
                        leftbtn.Enabled = true;
                        rightbtn.Tag = index + 1;
                        dgv.ReadOnly = true;
                        tsbNew.Enabled = tsbCancel.Enabled = false;
                    }
                    break;
                case 2:
                    {
                        leftbtn.Tag = index - 1;
                        rightbtn.Enabled = false;
                        dgv.ReadOnly = true;
                        tsbNew.Enabled = tsbCancel.Enabled = false;
                    }
                    break;
            }

            dgv.DataSource = GetDataTable(tables[index]);
        }

        private void Reset()
        {
            dgv.DataSource = GetDataTable("Driver");
            dgv.Columns["number"].ReadOnly = true;
        }

        private void Update(string columnName, int primaryKey, object newValue)
        {
            string sql;
            try
            {
                int checkInt = Convert.ToInt32(newValue);
                sql = $"UPDATE Driver SET {columnName}={checkInt} WHERE number={primaryKey};";
                Commons.Query(sql);
                return;
            }
            catch (Exception e) 
            {
                //MessageBox.Show(e.Message);
            }

            try
            {
                string checkString = newValue.ToString();
                sql = $"UPDATE Driver SET {columnName}='{checkString}' WHERE number={primaryKey};";
                Commons.Query(sql);
                return;
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
            }

            try
            {
                DateTime checkDateTime = Convert.ToDateTime(newValue);
                string date = checkDateTime.ToString("yyyy-MM-dd");
                sql = $"UPDATE Driver SET {columnName}='{date}' WHERE number={primaryKey};";
                Commons.Query(sql);
                return;
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
            }
        }

        public DataTable GetDataTable(string table)
        {
            DataTable retVal = new DataTable();
            SqlConnection con = new SqlConnection(Commons.CONNECTION_STRING);
            string sql = $"SELECT * FROM {table}";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(retVal);
            con.Close();
            da.Dispose();
            return retVal;
        }
    }
}
