using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Asiakkaat : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            DataTable dt = JAMK.IT.DBDemoxOy.GetDataReal();
            gvAsiakkaat2.DataSource = dt;
            gvAsiakkaat2.DataBind();
        }
        catch (Exception ex)
        {
            lblMessages.Text = ex.Message;
        }
    }
}