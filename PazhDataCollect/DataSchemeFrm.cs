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
        DataTable RemoteTB, RemoteAddTB, LocalTB, LocalAddTB=new DataTable();
        BindingSource RemoteBS, RemoteAddBC, LocalBC, LocalAddBC=null;
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
            if (Properties.Settings.Default.ShamsiDate == true)
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
            maskedTextBox1.Text = Properties.Settings.Default.DaysBefore.ToString();
            //chbDate.CheckState = CheckState.Unchecked;
        }

        private void BtnRemote_Click(object sender, EventArgs e)
        {
            RemoteCN.ConnectionString = Properties.Settings.Default.RemoteCN;
           
            //MessageBox.Show("select COLUMN_NAME,TABLE_NAME from INFORMATION_SCHEMA.COLUMNS where  TABLE_NAME=\"" + "TEST" + "\"");
            if (cbRemote.Text != "" && RemoteCN.ConnectionString !="")
            {
                RemoteTB = UT.FN_GetTbColumnList(RemoteCN, cbRemote.Text);
                MessageBox.Show(RemoteTB.Rows.Count.ToString());
                dgRemote.DataSource = RemoteTB;
                //RemoteBS.DataSource = RemoteTB;
                
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
                Properties.Settings.Default.ShamsiDate = false;
            else
                Properties.Settings.Default.ShamsiDate = true;
            if (chbFormatDate.CheckState == CheckState.Checked)
                Properties.Settings.Default.Digitz8 = true;
            else
                Properties.Settings.Default.Digitz8 = false;
            Properties.Settings.Default.DaysBefore =Convert.ToInt32( maskedTextBox1.Text);
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
            
            LocalCN.ConnectionString = Properties.Settings.Default.LocalCN;
            using (LocalCN)
            {
                using (SqlDataAdapter a = new SqlDataAdapter(
                                   "SELECT TOP 100 * FROM " + cbLocal.Text, LocalCN))
                {
                    
                    DataTable t = new DataTable();
                    a.Fill(t);
                    
                    dgSQLView.DataSource = t;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
