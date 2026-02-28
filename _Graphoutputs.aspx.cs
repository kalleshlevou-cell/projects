using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.DataVisualization.Charting;

namespace patternPrediction.VDoctor
{
    public partial class _Graphoutputs : System.Web.UI.Page
    {
        Dictionary<string, double> testData = new Dictionary<string, double>();

        protected override void OnLoad(EventArgs e)
        {
            try
            {                
                base.OnLoad(e);

                if (!IsPostBack)
                {
                    // bind chart type names to ddl
                    ddlChartType.DataSource = Enum.GetNames(typeof(SeriesChartType));
                    ddlChartType.DataBind();

                    //cbUse3D.Checked = true;
                }

                DataBind();

            }
            catch
            {

            }
        }

        protected override void OnDataBinding(EventArgs e)
        {
            base.OnDataBinding(e);
            testData.Clear();


            testData.Add("Eclat", double.Parse(Session["Eclat_Time"].ToString()));
           
            cTestChart.Series["Testing"].Points.DataBind(testData, "Key", "Value", string.Empty);
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            // update chart rendering           
            cTestChart.Series["Testing"].ChartTypeName = "Column";

            cTestChart.ChartAreas[0].Area3DStyle.Enable3D = cbUse3D.Checked;
            cTestChart.ChartAreas[0].Area3DStyle.Inclination = Convert.ToInt32(rblInclinationAngle.SelectedValue);

            cTestChart.Visible = true;
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            cTestChart.Visible = true;

            OnDataBinding(e);
            OnPreRender(e);
        }
    }
}