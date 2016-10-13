using System;
using System.Collections.Generic;
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
        XmlDataSource xds = new XmlDataSource();
        xds.DataFile = @"http://www.finnkino.fi/xml/TheatreAreas/";
        XmlDocument doc = new XmlDocument();
        doc = xds.GetXmlDocument();
        XmlNodeList nodes = doc.SelectNodes("/TheatreAreas/TheatreArea");
        string theatreID = "";
        string theatreName = "";
        foreach (XmlNode node in nodes)
        {
            theatreID = node["ID"].InnerText;
            theatreName = node["Name"].InnerText;
            lbTeatterit.Items.Add(new ListItem(theatreName, theatreID));
        }
    }
}