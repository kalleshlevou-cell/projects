using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace patternPrediction.VDoctor
{
    public partial class SendReply : System.Web.UI.Page
    {
        int queryId = 0;
        DataTable tab = new DataTable();
        Class1 obj = new Class1();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                queryId = int.Parse(Request.QueryString["queryId"].ToString());
                GetQuery();
            }
            catch
            {

            }
        }

        public void GetQuery()
        {
            tab.Rows.Clear();
            tab = obj.GetQueryById(queryId);

            if (tab.Rows.Count > 0)
            {
                txt_name.Text = tab.Rows[0]["FarmerId"].ToString();
                TextBox1.Text = tab.Rows[0]["Query"].ToString();
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                obj.SendReply(TextBox2.Text, DateTime.Now, queryId);
                txt_name.Text = string.Empty;
                TextBox1.Text = string.Empty;
                TextBox2.Text = string.Empty;
                ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Replied Successfully')</script>");
                Response.Redirect("Queries.aspx");
            }
            catch
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Key", "<script>alert('Server Error!')</script>");
            }
        }


    }
}