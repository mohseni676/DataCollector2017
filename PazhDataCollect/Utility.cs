using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;
using System.Linq;
using System.Globalization;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;
using System.Configuration;

namespace PazhDataCollect
{
    class Utility
    {
        public List<string> FN_GetDBList(string ServerAddress,string DBUser,string DBPassword)
        {
            List<String> databases = new List<String>();

            SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
            
            connection.DataSource = ServerAddress;
            
            
            // enter credentials if you want
            connection.UserID = DBUser;
            connection.Password = DBPassword;
            //connection.IntegratedSecurity = true;

            String strConn = connection.ToString();

            //create connection
            SqlConnection sqlConn = new SqlConnection(strConn);
            try
            {
                //open connection
                sqlConn.Open();

                //get databases
                DataTable tblDatabases = sqlConn.GetSchema("Databases");


                //close connection
                sqlConn.Close();

                //add to list
                foreach (DataRow row in tblDatabases.Rows)
                {
                    String strDatabaseName = row["database_name"].ToString();

                    databases.Add(strDatabaseName);


                }
                return databases;
            }catch (Exception er)
            {

                throw (er);
            }
        }

        public bool CheckServerAvailablity(string serverIPAddress)
        {
            try
            {
                IPHostEntry ipHostEntry = Dns.Resolve(serverIPAddress);
                IPAddress ipAddress = ipHostEntry.AddressList[0];

                TcpClient TcpClient = new TcpClient();
                TcpClient.Connect(ipAddress, 1433);
                TcpClient.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public List<string> FN_GetDBTableList(SqlConnection CN)
        {
            List<string> TbList = new List<string>();
            using (CN)
            {
                SqlCommand CMD = new SqlCommand("select name from sys.tables union select name from sys.views", CN);
                CN.Open();
                SqlDataReader Reader = CMD.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {

                        TbList.Add(Reader.GetString(0));
                            
                    }
                }
                return TbList;
                CN.Close();
            }
        }

        public DataTable FN_GetTbColumnList(SqlConnection CN,String TbName)
        {
            DataTable TbList = new DataTable();
            using (CN)
            {
                try
                {
                    CN.Open();
                    using (SqlDataAdapter DA = new SqlDataAdapter("select * from (select t1.name AS FieldName,t3.name as FieldType ,t1.max_length AS Length, t2.name AS TBName from sys.all_columns t1 inner join sys.all_objects t2 on t1.object_id=t2.object_id inner join sys.types t3 on t1.system_type_id= t3.system_type_id where (t2.object_id>0 and  t2.type_desc='USER_TABLE'  and t3.name<>'sysname' ) OR (t2.object_id>0 and  t2.type_desc='VIEW'  and t3.name<>'sysname')) tt where tt.tbname = '" + TbName+"'", CN))
                    {
                        DA.Fill(TbList);

                    }
                    return TbList;
                    
                }
                catch (Exception er)
                {
                   throw (er);
                }
            }
        }
        public string FN_FormatDate(DateTime date,bool IsMiladi,int DigitNumber)
        {
            string Cdate = "";
            PersianCalendar CLD = new PersianCalendar();
            
            if (IsMiladi == true)
            {
                Cdate +=date.Year + "/" + date.Month.ToString().PadLeft(2,'0')+"/"+date.Day.ToString().PadLeft(2,'0');
            }else
            {
                Cdate += CLD.GetYear(date) + "/" + CLD.GetMonth(date).ToString().PadLeft(2, '0') + "/" + CLD.GetDayOfMonth(date).ToString().PadLeft(2, '0');
            }
            if (DigitNumber < 10)
            {
                Cdate = Cdate.Remove(0, 2);
            }
            if (DigitNumber < 8)
            {
                Cdate = Cdate.Remove(5, 1);
                Cdate = Cdate.Remove(2, 1);
            }
            return Cdate;
        }
        public string FN_GetQueryString(int DaysBefore)
        {
             
            string ShopName = Properties.Settings.Default.ShopName;
            string ShopID = Properties.Settings.Default.ShopID;
            string DateField = Properties.Settings.Default.DateField;
            bool isMialdi = Properties.Settings.Default.TarikhMiladi;
            int is8Digit = Properties.Settings.Default.Digitz8;
            string Cdate = FN_FormatDate(DateTime.Now.AddDays(DaysBefore * -1), isMialdi, is8Digit);
            string DBtable = Properties.Settings.Default.LocalDB;
            string SQL = Properties.Settings.Default.LocalSQL;
            //SQL += ",N'" + ShopName + "' AS 'ShopName' , N'" + ShopID + "' AS 'ShopID' ";
            //SQL += " FROM " + DBtable;
            SQL += " WHERE " + DateField + ">'" + Cdate + "'";
            return SQL;

        }
        public void FN_SendDataToServer()
        {
            //definitions

            string LocalCNStr = Properties.Settings.Default.LocalCN;
            string RemoteCNStr = Properties.Settings.Default.RemoteCN;
            int DaysBefore = Properties.Settings.Default.DaysBefore;
            string SQLtxt = FN_GetQueryString(DaysBefore);
            DataTable TbToTransfer = new DataTable();
            //check connection to local server
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                using (SqlConnection LocalCon = new SqlConnection(LocalCNStr))
            {
                try
                {
                    LocalCon.Open();
                        Log("info:Local Server Accessable", w);

                }
                catch (Exception Err)
                {
                        Log("Error: Local Server Not Accessable:"+Err.Message, w);
                        return;
                }
            }
            //check connection to remote server
            using (SqlConnection LocalCon = new SqlConnection(RemoteCNStr))
            {
                try
                {
                    LocalCon.Open();
                        Log("Info:Remote Server Accessable", w);
                    }
                catch (Exception Err)
                {
                        Log("Error: Remote Server Not Accessable:" + Err.Message, w);
                        return;
                }
            }
            //Fill Datatable for transfering ...
            using (SqlConnection LCN = new SqlConnection(LocalCNStr))
            {
                LCN.Open();
                try
                {
                    using (SqlDataAdapter DT = new SqlDataAdapter(SQLtxt, LCN))
                    {
                        DT.Fill(TbToTransfer);
                            Log("Info:Table Filled", w);
                        }
                    }
                catch (Exception err)
                {
                        Log("Error: Error in filling table:" + err.Message, w);

                        return;
                }
            }
                //Bulk copy data to remote server
                using (SqlConnection LCN = new SqlConnection(RemoteCNStr))
                {
                    LCN.Open();
                    using (SqlBulkCopy Copy = new SqlBulkCopy(LCN))
                    {
                        Copy.DestinationTableName = Properties.Settings.Default.RemoteDB;
                        foreach (DataColumn col in TbToTransfer.Columns)
                        {
                            Copy.ColumnMappings.Add(col.ColumnName, col.ColumnName);
                        }
                        try
                        {
                            Copy.WriteToServer(TbToTransfer);
                            Log("Info:Data Transfered Successfuly", w);

                        }
                        catch (Exception er)
                        {
                            Log("Error: Cannot Copy Data to Destination:" + er.Message, w);

                            return;
                        }

                    }
                }
            }


            //----------------------------------
        }
        public static void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString());
            //w.WriteLine("  :");
            w.WriteLine("  :{0}", logMessage);
            w.WriteLine("-------------------------------");
        }
        public void FN_WriteToRegistery()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Pazh");
            foreach (SettingsProperty p in Properties.Settings.Default.Properties)
            {
                key.SetValue(p.Name, Properties.Settings.Default[p.Name].ToString());
            }
        }


    }
}
