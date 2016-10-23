using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class LevynTiedot : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string isbn = Request.QueryString["isbn"];
        XmlDocument doc = new XmlDocument();
        doc.Load(Server.MapPath("~/App_Data/LevykauppaX.xml"));
        XmlNodeList records = doc.SelectNodes("/Records/genre/record[@ISBN='" + isbn + "']");
        foreach (XmlNode r in records)
        {
            levynTiedot.InnerHtml += "<img src='Images/" + isbn + ".jpg' style='width: 200px; height: 200px'/><br>";
            levynTiedot.InnerHtml += "<h3>" + r.Attributes["Artist"].Value + " : " + r.Attributes["Title"].Value + "</h3>";
            levynTiedot.InnerHtml += "<b>ISBN:</b> " + isbn + "<br>";
            levynTiedot.InnerHtml += "<b>Hinta:</b> " + r.Attributes["Price"].Value + "<br>";
        }
        XmlNodeList songs = doc.SelectNodes("/Records/genre/record[@ISBN='" + isbn + "']/song");
        foreach (XmlNode s in songs)
        {
            levynBiisit.InnerHtml += s.Attributes["name"].Value + "<br>";
        }
    }
}