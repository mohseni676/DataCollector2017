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
using System.Data.Sql;
namespace PazhDataCollect
{
    public partial class mainFrm : Form
    {
        DataTable TB = new DataTable();
        Utility UT = new Utility();
        SqlConnectionStringBuilder RemoteCN = new SqlConnectionStringBuilder();
        SqlConnectionStringBuilder LocalCN = new SqlConnectionStringBuilder();
        public mainFrm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (UT.CheckServerAvailablity(txtRserver.Text.Trim()) == true)
                {
                    //MessageBox.Show("ارتباط با سرور بر قرار است.");
                    cbDBList.Items.Clear();
                    List<string> DBs = new List<string>();
                    DBs = UT.FN_GetDBList(txtRserver.Text.Trim(), txtDBUser.Text.Trim(), txtDBPassword.Text);
                    cbDBList.Items.AddRange(DBs.ToArray());
                    MessageBox.Show("بانک اطلاعاتی مد نظر را از لیست انتخاب نمایید.");
                    panel3.Enabled = true;
                    panel2.Enabled = false;
                }
                else
                {
                    MessageBox.Show("خطا: ارتباط با سرور بر قرار نمی باشد، آدرس و پورت را بررسی کنید.");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("خطا: " + er.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder cn = new SqlConnectionStringBuilder();
            cn.DataSource = txtRserver.Text.Trim();
            cn.UserID = txtDBUser.Text.Trim();
            cn.Password = txtDBPassword.Text;
            cn.InitialCatalog = cbDBList.Text.Trim();

            Properties.Settings.Default.RemoteCN = cn.ConnectionString.ToString();
            Properties.Settings.Default.Save();
            MessageBox.Show("تنظیمات مربوط به سرور راه دور ذخیره شد.");
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.RemoteCN != "")
            {
                RemoteCN.ConnectionString = Properties.Settings.Default.RemoteCN;
                txtRserver.Text = RemoteCN.DataSource.ToString();
                txtDBUser.Text = RemoteCN.UserID.ToString();
                txtDBPassword.Text = RemoteCN.Password.ToString();
                cbDBList.Text = RemoteCN.InitialCatalog.ToString();
            }
            if (Properties.Settings.Default.LocalCN != "")
            {
                LocalCN.ConnectionString = Properties.Settings.Default.LocalCN;
                txtLServer.Text = LocalCN.DataSource.ToString();
                txtLDBUser.Text = LocalCN.UserID.ToString();
                txtLPassword.Text = LocalCN.Password.ToString();
                cbLDBname.Text = LocalCN.InitialCatalog.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                if (UT.CheckServerAvailablity(txtLServer.Text.Trim()) == true)
                {
                    //MessageBox.Show("ارتباط با سرور بر قرار است.");
                    cbLDBname.Items.Clear();
                    List<string> DBs = new List<string>();
                    DBs = UT.FN_GetDBList(txtLServer.Text.Trim(), txtLDBUser.Text.Trim(), txtLPassword.Text);
                    cbLDBname.Items.AddRange(DBs.ToArray());
                    MessageBox.Show("بانک اطلاعاتی مد نظر را از لیست انتخاب نمایید.");
                    panel4.Enabled = true;
                    panel5.Enabled = false;
                }
                else
                {
                    MessageBox.Show("خطا: ارتباط با سرور بر قرار نمی باشد، آدرس و پورت را بررسی کنید.");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("خطا: " + er.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder cn = new SqlConnectionStringBuilder();
            cn.DataSource = txtLServer.Text.Trim();
            cn.UserID = txtLDBUser.Text.Trim();
            cn.Password = txtLPassword.Text;
            cn.InitialCatalog = cbLDBname.Text.Trim();

            Properties.Settings.Default.LocalCN = cn.ConnectionString.ToString();
            Properties.Settings.Default.Save();
            MessageBox.Show("تنظیمات مربوط به سرور فروشگاه ذخیره شد.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataSchemeFrm Dform = new DataSchemeFrm();
            Dform.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            panel6.Enabled = true;
            using (SqlConnection LCN = new SqlConnection(Properties.Settings.Default.LocalCN))
            {
                LCN.Open();
                txtSQL.Text = UT.FN_GetQueryString();

                try
                {
                    using (SqlDataAdapter DT = new SqlDataAdapter(txtSQL.Text, LCN))
                    {

                        DT.Fill(TB);
                        dgLocal.DataSource = TB;
                    }
                }catch (Exception err)
                {
                    MessageBox.Show("خطای اجرای Query : \r\n"+ err.Message +"\r\n"+err.HResult);
                }
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            using (SqlConnection LCN = new SqlConnection(Properties.Settings.Default.RemoteCN))
            {
                LCN.Open();
                    using (SqlBulkCopy Copy = new SqlBulkCopy(LCN))
                {





                    Copy.DestinationTableName = Properties.Settings.Default.RemoteDB;

                    //Column Mapping
                    if (TB.Columns.Contains("ShopID"))
                        Copy.ColumnMappings.Add("ShopID", "ShopID");
                    if (TB.Columns.Contains("ShopName"))
                        Copy.ColumnMappings.Add("ShopName", "ShopName");
                    if (TB.Columns.Contains("Fac_Serial"))
                        Copy.ColumnMappings.Add("Fac_Serial", "Fac_Serial");
                    if (TB.Columns.Contains("Fac_NO"))
                        Copy.ColumnMappings.Add("Fac_NO", "Fac_NO");
                    if (TB.Columns.Contains("RegDate"))
                        Copy.ColumnMappings.Add("RegDate", "RegDate");
                    if (TB.Columns.Contains("FacItem_Date"))
                        Copy.ColumnMappings.Add("FacItem_Date", "FacItem_Date");
                    if (TB.Columns.Contains("FacItem_Time"))
                        Copy.ColumnMappings.Add("FacItem_Time", "FacItem_Time");
                    if (TB.Columns.Contains("FacItem_ID"))
                        Copy.ColumnMappings.Add("FacItem_ID", "FacItem_ID");
                    if (TB.Columns.Contains("FacItem_Name"))
                        Copy.ColumnMappings.Add("FacItem_Name", "FacItem_Name");
                    if (TB.Columns.Contains("FacItem_Fee"))
                        Copy.ColumnMappings.Add("FacItem_Fee", "FacItem_Fee");
                    if (TB.Columns.Contains("FacItem_QT"))
                        Copy.ColumnMappings.Add("FacItem_QT", "FacItem_QT");
                    if (TB.Columns.Contains("FacItem_Discount"))
                        Copy.ColumnMappings.Add("FacItem_Discount", "FacItem_Discount");
                    if (TB.Columns.Contains("Fac_Discount"))
                        Copy.ColumnMappings.Add("Fac_Discount", "Fac_Discount");
                    if (TB.Columns.Contains("Fac_Total"))
                        Copy.ColumnMappings.Add("Fac_Total", "Fac_Total");
                    //End Column Mapping
                    MessageBox.Show(Copy.ColumnMappings[0].ToString());
                    Copy.SqlRowsCopied +=
                    new SqlRowsCopiedEventHandler(OnSqlRowsCopied);
                    Copy.NotifyAfter = 10;
                    try
                    {
                        Copy.WriteToServer(TB);
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("خطا در کپی :" + er.Message);
                    }
                    
                }
            }
        }

        private void OnSqlRowsCopied(object sender, SqlRowsCopiedEventArgs e)
        {
            lblCount.Text = e.RowsCopied.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void mainFrm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.Hide();
            else
                this.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
    }
}
