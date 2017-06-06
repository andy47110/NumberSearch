using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {            
            InitializeComponent();
        }
        public string filePath = "C:/Users/adchen0428/Desktop/電話分機表20170601.xlsx";

        private void Form1_Load(object sender, EventArgs e)
        {
            Boolean a = false;
            if (File.Exists(filePath))
            {
                a = true;
            }

            txtExcelPath.Text = filePath;
            //MessageBox.Show("a="+ a + "");
            cbSheet.SelectedIndex = 0;
        }
        private DataTable GetExcelSheetNames(string filePath)
        {
            //Office 2003
            //OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1'");

            //Office 2007
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 12.0 Xml;HDR=YES'");

            DataSet ds = new DataSet();
            conn.Open();
            DataTable dt = conn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, null);
            conn.Close();
            return dt;
        }

        private DataTable GetExcelDataTable(string filePath, string sql)
        {
            //Office 2003
            //OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1;Readonly=0'");

            //Office 2007
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 12.0 Xml;HDR=YES'");

            OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.TableName = "tmp";
            conn.Close();
            return dt;
        }

        /// <summary>
        /// 查詢按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtExcelPath.Text) ==false){
                MessageBox.Show("分機表咧???????????????????");
                return;
            }
            String Sheet = cbSheet.Text;
            String tableName = "[" + Sheet + "$]";//在頁簽名稱後加$，再用中括號[]包起來
            String sql = "select * from " + tableName;//SQL查詢
            DataTable dt = GetExcelDataTable(filePath, sql);

            ShowData(dt);
            gd1.DataSource = dt;
        }

        private void ShowData(DataTable dt)
        {
            lbTEL = dt.;
            lbFAX;
            lbFAXSales;
            lbNO;
                
        }
        /// <summary>
        /// Open File Dialog 取得Excel檔案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcelPath_Click(object sender, EventArgs e)
        {
            ofd1 = new OpenFileDialog();
            ofd1.Title = "SELECT 'xlsx' FILE";
            ofd1.Filter = "xlsx files (*.*)|*.xlsx";

            if (File.Exists(txtExcelPath.Text) == true) { ofd1.FileName = txtExcelPath.Text; }
            else {ofd1.FileName = "";}

            if (ofd1.ShowDialog() == DialogResult.Cancel){return;}

            txtExcelPath.Text = ofd1.FileName;

            //ofd1.FileName = txtPOSDB.Text
            //Else
            //ofd1.FileName = ""
            //End If
            //If ofd1.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
            //txtPOSDB.Text = ofd1.FileName
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            gd1.DataSource = "";
        }
    }
}
