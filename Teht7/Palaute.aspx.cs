using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using MySql.Data.MySqlClient;
using System.Data;

public partial class Palaute : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtDate.Text = DateTime.Now.ToShortDateString();
        }
    }

    protected void btnSendXML_Click(object sender, EventArgs e)
    {
        string connection_string = ConfigurationManager.AppSettings["XML"];
        lbMessages.Text = "";

        try
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(Server.MapPath(connection_string));

            XmlNode rootNode = xmlDocument.SelectSingleNode("palautteet");
            XmlNode xmlNode = rootNode.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "palaute", ""));

            xmlNode.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "pvm", "")).InnerText = txtDate.Text;
            xmlNode.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "tekija", "")).InnerText = txtName.Text;
            xmlNode.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "kurssi", "")).InnerText = txtCourse.Text;
            xmlNode.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "opittu", "")).InnerText = txtHaveLearned.Text;
            xmlNode.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "haluanoppia", "")).InnerText = txtWantToLearn.Text;
            xmlNode.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "hyvaa", "")).InnerText = txtFeedbackPositive.Text;
            xmlNode.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "parannettavaa", "")).InnerText = txtFeedbackNegative.Text;
            xmlNode.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "muuta", "")).InnerText = txtFeedbackOther.Text;

            xmlDocument.Save(Server.MapPath(connection_string));
            lbMessages.Text = "Kiitos palautteestasi!";
        }
        catch (Exception ex)
        {
            lbMessages.Text = ex.Message;
        }

    }

    protected void btnSendSQL_Click(object sender, EventArgs e)
    {
        string connection_string = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
        lbMessages.Text = "";

        try
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connection_string);
            mySqlConnection.Open();

            MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandText = "INSERT INTO palaute(pvm, tekija, opintojakso, opittu, haluanoppia, hyvaa, parannettavaa, muuta) VALUES(@pvm, @tekija, @opintojakso, @opittu, @haluanoppia, @hyvaa, @parannettavaa, @muuta)";
            mySqlCommand.Parameters.AddWithValue("@pvm", txtDate.Text);
            mySqlCommand.Parameters.AddWithValue("@tekija", txtName.Text);
            mySqlCommand.Parameters.AddWithValue("@opintojakso", txtCourse.Text);
            mySqlCommand.Parameters.AddWithValue("@opittu", txtHaveLearned.Text);
            mySqlCommand.Parameters.AddWithValue("@haluanoppia", txtWantToLearn.Text);
            mySqlCommand.Parameters.AddWithValue("@hyvaa", txtFeedbackPositive.Text);
            mySqlCommand.Parameters.AddWithValue("@parannettavaa", txtFeedbackNegative.Text);
            mySqlCommand.Parameters.AddWithValue("@muuta", txtFeedbackOther.Text);
            mySqlCommand.ExecuteNonQuery();

            mySqlConnection.Close();
            lbMessages.Text = "Kiitos palautteestasi!";
        }
        catch (Exception ex)
        {
            lbMessages.Text = ex.Message;
        }
    }
}