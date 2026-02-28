using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.Collections;
using System.Threading;
using System.Configuration;


namespace patternPrediction.VDoctor
{
    public partial class frmDatasets : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnUpload_Click(object sender, EventArgs e)
        {
            //try
            //{

            if (FileUpload1.HasFile)
            {

                string FileName = Path.GetFileName(FileUpload1.PostedFile.FileName);

                string Extension = Path.GetExtension(FileUpload1.PostedFile.FileName);

                string FolderPath = ConfigurationManager.AppSettings["FolderPath"];

                int index = FileName.LastIndexOf('.');
                string _Location = FileName.Substring(0, index);

                string FilePath = Server.MapPath(FolderPath + FileName);

                FileUpload1.SaveAs(FilePath);

                Import_To_Grid(FilePath, Extension, _Location);
            }
            //}
            //catch
            //{

            //}
        }

        private void Import_To_Grid(string FilePath, string Extension, string _Location)
        {
            string conStr = "";

            switch (Extension)
            {

                case ".xls": //Excel 97-03

                    conStr = ConfigurationManager.ConnectionStrings["Excel03ConString"]

                             .ConnectionString;

                    break;

                case ".xlsx": //Excel 07

                    conStr = ConfigurationManager.ConnectionStrings["Excel07ConString"]

                              .ConnectionString;

                    break;

            }

            conStr = String.Format(conStr, FilePath, _Location);

            OleDbConnection connExcel = new OleDbConnection(conStr);

            OleDbCommand cmdExcel = new OleDbCommand();

            OleDbDataAdapter oda = new OleDbDataAdapter();

            DataTable dt = new DataTable();

            cmdExcel.Connection = connExcel;

            //Get the name of First Sheet

            connExcel.Open();

            DataTable dtExcelSchema;

            dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            string SheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();

            connExcel.Close();

            //Read Data from First Sheet

            connExcel.Open();

            cmdExcel.CommandText = "SELECT * From [" + SheetName + "]";

            oda.SelectCommand = cmdExcel;

            oda.Fill(dt);

            Class1 obj = new Class1();

            if (dt.Rows.Count > 0)
            {
                //Bind Data to GridView

                GridView1.Caption = Path.GetFileName(FilePath);

                GridView1.DataSource = dt;

                GridView1.DataBind();

                ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('Data Imported Successfully!!!')</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('No Data Found in Excelsheet!!!')</script>");
            }

            connExcel.Close();

           

        }
    }
}