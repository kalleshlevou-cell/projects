using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace patternPrediction.VDoctor
{
    public partial class AddHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["ICId"] == null)
                {
                    Session.Abandon();
                    Response.Redirect("~/Visitor/frmLogin.aspx");
                }
                else
                {
                    GetHistory();
                }
            }
            catch
            {

            }
        }
             
        //function to get all history
        private void GetHistory()
        {
            int serialNo = 1;

            DataTable tab = new DataTable();
            Class1 obj = new Class1();

            tab = obj.GetAllHistory();

            if (tab.Rows.Count > 0)
            {
                tblHistory.Rows.Clear();

                tblHistory.BorderStyle = BorderStyle.Double;
                tblHistory.GridLines = GridLines.Both;
                tblHistory.BorderColor = System.Drawing.Color.Black;

                TableRow headerrow = new TableRow();
                headerrow.Height = 30;
                headerrow.ForeColor = System.Drawing.Color.Black;
                headerrow.BackColor = System.Drawing.Color.Goldenrod;

                TableCell cell1 = new TableCell();
                cell1.Text = "<b>SLNo</b>";
                headerrow.Controls.Add(cell1);

                TableCell cell2 = new TableCell();
                cell2.Text = "<b>FarmerId</b>";
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

                TableCell cell51 = new TableCell();
                cell51.Text = "<b>Treatments</b>";
                headerrow.Controls.Add(cell51);

                TableCell cell512 = new TableCell();
                cell512.Text = "<b>Date</b>";
                headerrow.Controls.Add(cell512);

                TableCell cell6 = new TableCell();
                cell6.Text = "<b>Edit</b>";
                headerrow.Controls.Add(cell6);

                TableCell cell7 = new TableCell();
                cell7.Text = "<b>Delete</b>";
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
                                        
                    TableCell cellIAId = new TableCell();
                    cellIAId.Width = 150;
                    cellIAId.Text = tab.Rows[cnt]["FarmerId"].ToString();
                    row.Controls.Add(cellIAId);

                    TableCell cellPwd = new TableCell();
                    cellPwd.Width = 250;
                    cellPwd.Text = tab.Rows[cnt]["Description"].ToString();
                    row.Controls.Add(cellPwd);

                    TableCell cellMobile = new TableCell();
                    cellMobile.Width = 250;
                    cellMobile.Text = tab.Rows[cnt]["Symptoms"].ToString();
                    row.Controls.Add(cellMobile);

                    TableCell celldisease = new TableCell();
                    celldisease.Width = 150;
                    celldisease.Text = tab.Rows[cnt]["Disease"].ToString();
                    row.Controls.Add(celldisease);

                    TableCell cellTreatments = new TableCell();
                    cellTreatments.Width = 300;
                    cellTreatments.Text = tab.Rows[cnt]["Treatment"].ToString();
                    row.Controls.Add(cellTreatments);


                    TableCell cellDate = new TableCell();
                    cellDate.Width = 100;
                    string[] s = tab.Rows[cnt]["RegisteredDate"].ToString().Split(' ');
                    cellDate.Text = s[0];
                    row.Controls.Add(cellDate);


                    TableCell cellEdit = new TableCell();

                    ImageButton btnEdit = new ImageButton();
                    btnEdit.Width = 15;
                    btnEdit.Height = 15;
                    btnEdit.ImageUrl = "~/images/edit-10-xxl.png";
                    btnEdit.ToolTip = "Click here to Edit the IA";
                    btnEdit.ID = "Edit~" + tab.Rows[cnt]["HistoryId"].ToString();

                    btnEdit.Click += new ImageClickEventHandler(btnEdit_Click);

                    cellEdit.Controls.Add(btnEdit);
                    row.Controls.Add(cellEdit);

                    TableCell cellDelete = new TableCell();

                    ImageButton btnDelete = new ImageButton();
                    btnDelete.Width = 15;
                    btnDelete.Height = 15;
                    btnDelete.ImageUrl = "~/images/deletebtn.jpg";
                    btnDelete.ToolTip = "Click here to Delete the IA";
                    btnDelete.ID = "Del~" + tab.Rows[cnt]["HistoryId"].ToString();
                    btnDelete.OnClientClick = "return confirm('Are you sure do you want to Delete')";
                    btnDelete.Click += new ImageClickEventHandler(btnDelete_Click);

                    cellDelete.Controls.Add(btnDelete);
                    row.Controls.Add(cellDelete);


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

        void btnEdit_Click(object sender, ImageClickEventArgs e)
        {
            Class1 obj = new Class1();
            ImageButton btn = (ImageButton)sender;
            string[] s = btn.ID.ToString().Split('~');

            Session["IC"] = null;
            Session["IC"] = s[1];

            DataTable tab = new DataTable();
            tab = obj.GetICById(s[1]);

            if (tab.Rows.Count > 0)
            {
                txtName.Text = tab.Rows[0]["FarmerId"].ToString();
                txtDesc.Text = tab.Rows[0]["Description"].ToString();
                txtSymptoms.Text = tab.Rows[0]["Symptoms"].ToString();
                txtDisease.Text = tab.Rows[0]["Disease"].ToString();
                txtTreatment.Text = tab.Rows[0]["Treatment"].ToString();                              
            }

            btnIC.Text = "Update";
        }

        //function to clear textboxes
        private void ClearTexts()
        {
            txtName.Text = txtDesc.Text = txtSymptoms.Text = txtDisease.Text = txtName.Text = txtTreatment.Text = string.Empty;            
        }

        void btnDelete_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                ImageButton btn = (ImageButton)sender;

                Class1 obj = new Class1();
                string[] s = btn.ID.Split('~');
                obj.DeleteHistory(int.Parse(s[1]));
                ClearTexts();
                ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Record Deleted Successfully!!!')</script>");
                GetHistory();
            }
            catch
            {
                ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Deletion Error!!!')</script>");
            }
        }

        protected void btnIC_Click(object sender, EventArgs e)
        {
            try
            {
                Class1 obj = new Class1();


                if (btnIC.Text == "Add")
                {

                    obj.InsertHistory(txtName.Text, txtDesc.Text, txtSymptoms.Text, txtDisease.Text, txtTreatment.Text, DateTime.Parse(DateTime.Now.ToShortDateString()));
                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Record Added Successfully!!')</script>");
                    ClearTexts();
                    GetHistory();

                }
                else if (btnIC.Text == "Update")
                {

                    obj.UpdateHistory(txtName.Text, txtDesc.Text, txtSymptoms.Text, txtDisease.Text, txtTreatment.Text, DateTime.Parse(DateTime.Now.ToShortDateString()), int.Parse(Session["IC"].ToString()));
                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Record Details Updated Successfully!!!')</script>");
                    ClearTexts();
                    GetHistory();
                    btnIC.Text = "Add";


                }


            }
            catch
            {

            }

        }

    }
}