using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PalauteSelaa : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLoadXML_Click(object sender, EventArgs e)
    {
        string connection_string = ConfigurationManager.AppSettings["XML"];
        gvFeedback.DataSource = null;
        gvFeedback.DataBind();
        lbMessages.Text = "";

        try
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(Server.MapPath(connection_string));

            gvFeedback.DataSource = dataSet;
            gvFeedback.DataBind();
        }
        catch (Exception ex)
        {
            lbMessages.Text = ex.Message;
        }
    }

    protected void btnLoadSQL_Click(object sender, EventArgs e)
    {
        string connection_string = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
        gvFeedback.DataSource = null;
        gvFeedback.DataBind();
        lbMessages.Text = "";

        try
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connection_string);
            mySqlConnection.Open();

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(new MySqlCommand("SELECT * FROM palaute;", mySqlConnection));

            DataSet dataSet = new DataSet();
            mySqlDataAdapter.Fill(dataSet);

            gvFeedback.DataSource = dataSet;
            gvFeedback.DataBind();

            mySqlConnection.Close();
        }
        catch (Exception ex)
        {
            lbMessages.Text = ex.Message;
        }
    }
}