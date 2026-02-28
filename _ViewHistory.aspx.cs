using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace patternPrediction.Farmer
{
    public partial class _ViewHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetHistory();
        }

        private void GetHistory()
        {
            int serialNo = 1;

            DataTable tab = new DataTable();
            Class1 obj = new Class1();

            tab = obj.GetHistoryByFarmerId(Session["FarmerId"].ToString());

            if (tab.Rows.Count > 0)
            {
                tblHistory.Rows.Clear();

                tblHistory.BorderStyle = BorderStyle.Double;
                tblHistory.GridLines = GridLines.Both;
                tblHistory.BorderColor = System.Drawing.Color.Black;

                TableRow headerrow = new TableRow();
                headerrow.Height = 30;
                headerrow.ForeColor = System.Drawing.Color.White;
                headerrow.BackColor = System.Drawing.Color.DarkGreen;

                TableCell cell1 = new TableCell();
                cell1.Text = "<b>SLNo</b>";
                headerrow.Controls.Add(cell1);

                TableCell cell2 = new TableCell();
                cell2.Text = "<b>Farmer Id</b>";
                headerrow.Controls.Add(cell2);

                TableCell cell3 = new TableCell();
                cell3.Text = "<b>Description</b>";
                headerrow.Controls.Add(cell3);

                TableCell cell4 = new TableCell();
                cell4.Text = "<b>Symptoms</b>";
                headerrow.Controls.Add(cell4);

                TableCell cell5 = new TableCell();
                cell5.Text = "<b>Disease</b>";
                headerrow.Controls.Add(cell5);

                TableCell cell6 = new TableCell();
                cell6.Text = "<b>Treatments</b>";
                headerrow.Controls.Add(cell6);

                TableCell cell7 = new TableCell();
                cell7.Text = "<b>Date</b>";
                headerrow.Controls.Add(cell7);

                tblHistory.Controls.Add(headerrow);

                for (int cnt = 0; cnt < tab.Rows.Count; cnt++)
                {
                    TableRow row = new TableRow();

                    TableCell cellSerialNo = new TableCell();
                    cellSerialNo.Width = 10;
                    cellSerialNo.Font.Size = 10;
                    cellSerialNo.Text = serialNo + cnt + ".";
                    row.Controls.Add(cellSerialNo);

                    TableCell cellCity = new TableCell();
                    cellCity.Width = 150;

                    cellCity.Text = tab.Rows[0]["FarmerId"].ToString();
                    row.Controls.Add(cellCity);

                    TableCell cellIAId = new TableCell();
                    cellIAId.Width = 150;
                    cellIAId.Text = tab.Rows[cnt]["Description"].ToString();
                    row.Controls.Add(cellIAId);

                    TableCell cellPwd = new TableCell();
                    cellPwd.Width = 150;
                    cellPwd.Text = tab.Rows[cnt]["Symptoms"].ToString();
                    row.Controls.Add(cellPwd);

                    TableCell cellMobile = new TableCell();
                    cellMobile.Width = 150;
                    cellMobile.Text = tab.Rows[cnt]["Disease"].ToString();
                    row.Controls.Add(cellMobile);

                    TableCell cellTreatments = new TableCell();
                    cellTreatments.Width = 150;
                    cellTreatments.Text = tab.Rows[cnt]["Treatment"].ToString();
                    row.Controls.Add(cellTreatments);


                    TableCell cellDate = new TableCell();
                    string[] s = tab.Rows[cnt]["RegisteredDate"].ToString().Split(' ');
                    cellDate.Width = 150;
                    cellDate.Text = s[0];
                    row.Controls.Add(cellDate);


                    tblHistory.Controls.Add(row);

                }

            }
            else
            {
                tblHistory.Rows.Clear();
                tblHistory.GridLines = GridLines.None;
                tblHistory.BorderStyle = BorderStyle.None;

                TableHeaderRow row = new TableHeaderRow();
                TableHeaderCell cell = new TableHeaderCell();
                cell.ColumnSpan = 5;
                cell.Font.Bold = true;
                cell.ForeColor = System.Drawing.Color.Red;

                cell.Text = "No Records Found!!!";


                row.Controls.Add(cell);
                tblHistory.Controls.Add(row);

            }

        }
    }
}