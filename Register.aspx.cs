using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace patternPrediction.Visitor
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtLoginId.Focus();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Class1 obj = new Class1();
                
                if (obj.CheckFarmerId(txtLoginId.Text))
                {
                    obj.RegisterFarmer(txtLoginId.Text, txtPassword.Text, txtName.Text, txtContactNo.Text, txtAddress.Text);
                    ClientScript.RegisterStartupScript(GetType(), "key", "<script>alert('Farmer Registered Successfully')</script>");
                    txtLoginId.Text = txtPassword.Text = txtName.Text = txtContactNo.Text = txtAddress.Text = string.Empty;
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "key", "<script>alert('FarmerId Already Exists')</script>");
                }
            }
            catch
            {
                ClientScript.RegisterStartupScript(GetType(), "key", "<script>alert('Server Error - Check the Database Connectivity!!!')</script>");
            }
        }
    }
}