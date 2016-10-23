using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Finnkino : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            InitTheatres();
        }
    }

    protected void InitTheatres()
    {
        XmlDocument doc = new XmlDocument();
        doc.Load("http://www.finnkino.fi/xml/TheatreAreas/");
        XmlNodeList nodes = doc.SelectNodes("/TheatreAreas/TheatreArea");
        foreach (XmlNode node in nodes)
        {
            lbTeatterit.Items.Add(new ListItem(node["Name"].InnerText, node["ID"].InnerText));
        }
    }

    protected void lbTeatterit_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("MovieName", typeof(string));
        dt.Columns.Add("MovieStartTime", typeof(DateTime));
        dt.Columns.Add("MovieEndTime", typeof(DateTime));
        dt.Columns.Add("MovieLength", typeof(string));
        dt.Columns.Add("MovieGenres", typeof(string));
        dt.Columns.Add("MovieImage", typeof(string));
        XmlDocument doc = new XmlDocument();
        doc.Load("http://www.finnkino.fi/xml/Schedule/?area=" + lbTeatterit.SelectedValue.ToString());
        XmlNodeList nodes = doc.SelectNodes("/Schedule/Shows/Show");
        foreach (XmlNode node in nodes)
        {
            string imgUrl = node.SelectSingleNode("Images/EventSmallImagePortrait").InnerText;
            dt.Rows.Add(node["Title"].InnerText, node["dttmShowStart"].InnerText, node["dttmShowEnd"].InnerText, node["LengthInMinutes"].InnerText, node["Genres"].InnerText, imgUrl);
        }
        gvLeffat.DataSource = dt;
        gvLeffat.DataBind();
    }
}