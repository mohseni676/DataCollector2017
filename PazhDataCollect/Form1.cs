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
        int DaysBefore;
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
            txtTimer.Text = (Properties.Settings.Default.timer / 60000).ToString();
            timer1.Interval = Properties.Settings.Default.timer;
            DaysBefore = Properties.Settings.Default.DaysBefore;

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
            //panel6.Enabled = true;
            using (SqlConnection LCN = new SqlConnection(Properties.Settings.Default.LocalCN))
            {
                LCN.Open();
                txtSQL.Text = UT.FN_GetQueryString(Convert.ToInt32( txtBeforDays.Text));

                try
                {
                    using (SqlDataAdapter DT = new SqlDataAdapter(txtSQL.Text, LCN))
                    {

                        DT.Fill(TB);
                        dgLocal.DataSource = TB;
                    }
                }catch (Exception err)
                {
                    MessageBox.Show("خطای اجرای Query : \r\n"+ err.Message );
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
                    foreach(DataColumn col in TB.Columns)
                    {
                      //  MessageBox.Show(col.ColumnName);
                        Copy.ColumnMappings.Add(col.ColumnName, col.ColumnName);
                    }

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

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (txtUser.Text=="supervisor" && txtPass.Text == "676ineshom")
            {
                panel8.Enabled = true;
            }
            else
            {
                MessageBox.Show("نام کاربری یا پسورد اشتباه است");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel8.Enabled = false;
            txtUser.Text = "";
            txtPass.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.timer = Convert.ToInt32(txtTimer.Text) * 60000;
            Properties.Settings.Default.Save();
        }
    }
}
