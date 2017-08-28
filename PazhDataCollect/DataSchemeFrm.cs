using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Globalization;
namespace PazhDataCollect
{
    public partial class DataSchemeFrm : Form
    {
        SqlConnection RemoteCN = new SqlConnection();
        SqlConnection LocalCN = new SqlConnection();
        Utility UT = new Utility();
        DataTable RemoteTB = new DataTable(), RemoteAddTB = new DataTable(), LocalTB = new DataTable(), LocalAddTB=new DataTable();
        BindingSource RemoteBS = new BindingSource(), RemoteAddBS = new BindingSource(), LocalBS = new BindingSource(), LocalAddBS=new BindingSource();
        public DataSchemeFrm()
        {
            InitializeComponent();
        }

        private void DataSchemeFrm_Load(object sender, EventArgs e)
        {
            RemoteCN.ConnectionString = Properties.Settings.Default.RemoteCN;
            LocalCN.ConnectionString = Properties.Settings.Default.LocalCN;
            cbRemote.Items.AddRange(UT.FN_GetDBTableList(RemoteCN).ToArray());
            cbLocal.Items.AddRange(UT.FN_GetDBTableList(LocalCN).ToArray());
            txtLocalSQL.Text = Properties.Settings.Default.LocalSQL;
           // txtRemoteSQL.Text = Properties.Settings.Default.RemoteSQL;
            cbDateField.Text = Properties.Settings.Default.DateField;
            txtLocalDB.Text = Properties.Settings.Default.LocalDB;
            txtRemoteDB.Text = Properties.Settings.Default.RemoteDB;
            txtShopName.Text = Properties.Settings.Default.ShopName;
            txtShopID.Text = Properties.Settings.Default.ShopID;
            if (Properties.Settings.Default.TarikhMiladi == false)
            {
               // MessageBox.Show("1");
                chbDate.CheckState = CheckState.Unchecked;
            }
            else
            {
               // MessageBox.Show("2");
                chbDate.CheckState = CheckState.Checked;
            }
            if (Properties.Settings.Default.Digitz8 == true)
            {
                chbFormatDate.CheckState = CheckState.Checked;
            }
            else
            {
                chbFormatDate.CheckState = CheckState.Unchecked;
            }
            mtxtDate.Text = Properties.Settings.Default.DaysBefore.ToString();
            //chbDate.CheckState = CheckState.Unchecked;
        }

        private void BtnRemote_Click(object sender, EventArgs e)
        {
            RemoteCN.ConnectionString = Properties.Settings.Default.RemoteCN;

            
            //MessageBox.Show("select COLUMN_NAME,TABLE_NAME from INFORMATION_SCHEMA.COLUMNS where  TABLE_NAME=\"" + "TEST" + "\"");
            if (cbRemote.Text != "" && RemoteCN.ConnectionString !="")
            {
                RemoteTB = UT.FN_GetTbColumnList(RemoteCN, cbRemote.Text);
                // MessageBox.Show(RemoteTB.Rows.Count.ToString());
                RemoteBS.DataSource = RemoteTB;
                dgRemote.DataSource = RemoteBS;
                RemoteAddTB = RemoteTB.Clone();
                RemoteAddBS.DataSource = RemoteAddTB;
                dgRemoteAdd.DataSource = RemoteAddBS;

                
            }
            else
            {
                MessageBox.Show("لطفا یک جدول را انتخاب نمایید.");
            }
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            LocalCN.ConnectionString = Properties.Settings.Default.LocalCN;
            if (cbLocal.Text != "" && LocalCN.ConnectionString != "")
            {
                LocalTB = UT.FN_GetTbColumnList(LocalCN, cbLocal.Text);
                LocalBS.DataSource = LocalTB;
                dgLocal.DataSource = LocalBS;
                LocalAddTB = LocalTB.Clone();
                LocalAddBS.DataSource = LocalAddTB;
                dgLocalAdd.DataSource = LocalAddBS;


            }
            else
            {
                MessageBox.Show("لطفا یک جدول را انتخاب نمایید.");
            }
        }

        private void lbRemote_Click(object sender, EventArgs e)
        {
            
        }

        private void lbRemote_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbRemote_DoubleClick(object sender, EventArgs e)
        {
          //  txtResualt.Text += lbRemote.SelectedItem.ToString() + " = ";
            
            
        }

        private void lbLocal_DoubleClick(object sender, EventArgs e)
        {
           // txtResualt.Text += lbLocal.SelectedItem.ToString() + " , ";
        }

        private void lbRemoteAdded_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbRemoteAdded_DoubleClick(object sender, EventArgs e)
        {
        }

        private void dgRemote_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgRemote.Rows.Count >= 1)
            {
                foreach (DataGridViewRow Row in dgRemote.SelectedRows)
                {
                    DataRow RW1 = RemoteTB.Rows[Row.Index];
                    RemoteAddTB.ImportRow(RW1);
                    RemoteTB.Rows.RemoveAt(Row.Index);
                }
            }

        }

        private void dgRemoteAdd_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgRemoteAdd.Rows.Count >= 1)
            {
                foreach (DataGridViewRow Row in dgRemoteAdd.SelectedRows)
                {
                    DataRow RW1 = RemoteAddTB.Rows[Row.Index];
                    RemoteTB.ImportRow(RW1);
                    RemoteAddTB.Rows.RemoveAt(Row.Index);
                }
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            LocalCN.ConnectionString = Properties.Settings.Default.LocalCN;
            using (LocalCN)
            {
                using (SqlDataAdapter a = new SqlDataAdapter(
                                   "SELECT TOP 5000 * FROM " + cbLocal.Text, LocalCN))
                {

                    DataTable t = new DataTable();
                    a.Fill(t);

                    dgSQLView.DataSource = t;
                }
            }

        }

        private void dgLocal_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgLocal.Rows.Count >= 1)
            {
                foreach (DataGridViewRow Row in dgLocal.SelectedRows)
                {
                    DataRow RW1 = LocalTB.Rows[Row.Index];
                    LocalAddTB.ImportRow(RW1);
                    LocalTB.Rows.RemoveAt(Row.Index);
                }
            }

        }

        private void dgLocalAdd_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgLocalAdd.Rows.Count >= 1)
            {
                foreach (DataGridViewRow Row in dgLocalAdd.SelectedRows)
                {
                    DataRow RW1 = LocalAddTB.Rows[Row.Index];
                    LocalTB.ImportRow(RW1);
                    LocalAddTB.Rows.RemoveAt(Row.Index);
                }
            }

        }

        private void btnSQLOutlet_Click(object sender, EventArgs e)
        {
            if (LocalAddTB.Rows.Count != RemoteAddTB.Rows.Count)
            {
                MessageBox.Show("باید تعداد ردیفهای جداول محلی و راه دور یکسان باشد");
            }
            else
            {
                int i = 0;
                int count = RemoteAddTB.Rows.Count;
                string txtSQL = null;
                txtSQL += "SELECT N'" + txtShopName.Text + "' AS ShopName , N'" + txtShopID.Text + "' AS ShopID , ";
                foreach (DataRow rw in RemoteAddTB.Rows)
                {
                    if (i < count - 1)
                    {
                        txtSQL += "CAST(" + LocalAddTB.Rows[i][0].ToString() + " AS " + RemoteAddTB.Rows[i][1].ToString() + "(" + RemoteAddTB.Rows[i][2] + ")) AS " + RemoteAddTB.Rows[i][0].ToString() + " , ";
                    }
                    else
                    {
                        txtSQL += "CAST(" + LocalAddTB.Rows[i][0].ToString() + " AS " + RemoteAddTB.Rows[i][1].ToString() + "(" + RemoteAddTB.Rows[i][2] + ")) AS " + RemoteAddTB.Rows[i][0].ToString();
                    }
                    i++;
                }
                txtSQL += " FROM " + cbLocal.Text;
                string txt2SQL = " WHERE " + cbDateField.Text + "='" + UT.FN_FormatDate(DateTime.Now.AddDays(-1 * Convert.ToInt32(mtxtDate.Text)), chbDate.Checked, chbFormatDate.Checked) + "'";
                MessageBox.Show(txtSQL+txt2SQL);
                txtLocalSQL.Text = txtSQL;
                txtLocalDB.Text = cbLocal.Text;
                txtRemoteDB.Text = cbRemote.Text;
            }
        }

        private void cbDateField_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbDateField_Click(object sender, EventArgs e)
        {
            cbDateField.Items.Clear();

            foreach (DataRow rw in LocalAddTB.Rows)
            {
                cbDateField.Items.Add(rw[0].ToString());
            }

        }

        private void lbLocalAdded_DoubleClick(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LocalSQL = txtLocalSQL.Text;
            //Properties.Settings.Default.RemoteSQL = txtRemoteSQL.Text;
            Properties.Settings.Default.DateField = cbDateField.Text;
            Properties.Settings.Default.LocalDB = txtLocalDB.Text;
            Properties.Settings.Default.RemoteDB = txtRemoteDB.Text;
            if (chbDate.CheckState==CheckState.Checked)
                Properties.Settings.Default.TarikhMiladi = true;
            else
                Properties.Settings.Default.TarikhMiladi = false;
            if (chbFormatDate.CheckState == CheckState.Checked)
                Properties.Settings.Default.Digitz8 = true;
            else
                Properties.Settings.Default.Digitz8 = false;
            Properties.Settings.Default.DaysBefore =Convert.ToInt32( mtxtDate.Text);
            Properties.Settings.Default.ShopName = txtShopName.Text;
            Properties.Settings.Default.ShopID = txtShopID.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("تنظیمات ذخیره شد.");
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
