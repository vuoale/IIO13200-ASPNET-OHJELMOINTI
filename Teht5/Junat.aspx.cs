using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.Data;
using System.Text;

public partial class Junat : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            InitStations();
        }
    }

    protected string GetStationsFromAPI()
    {
        string url = "http://rata.digitraffic.fi/api/v1/metadata/stations";
        using (WebClient wc = new WebClient())
        {
            wc.Encoding = Encoding.UTF8;
            var json = wc.DownloadString(url);
            return json;
        }
    }

    protected string GetTrainsFromAPI(string station)
    {
        string url = "http://rata.digitraffic.fi/api/v1/live-trains?station=" + station;
        using (WebClient wc = new WebClient())
        {
            wc.Encoding = Encoding.UTF8;
            var json = wc.DownloadString(url);
            return json;
        }
    }

    protected void InitStations()
    {
        string data = GetStationsFromAPI();
        List<VR.Station> stations = JsonConvert.DeserializeObject<List<VR.Station>>(data);
        foreach (var station in stations)
        {
            lbAsemat.Items.Add(new ListItem(station.stationName, station.stationShortCode));
        }
    }

    protected void btnHae_Click(object sender, EventArgs e)
    {    
        string data = GetTrainsFromAPI(lbAsemat.SelectedValue.ToString());
        List<VR.Train> trains = JsonConvert.DeserializeObject<List<VR.Train>>(data);
        if (trains.Count == 0)
        {
            gvJunat.DataSource = null;
            gvJunat.DataBind();
            lblMessages.Text = "Ei liikennöiviä junia tänään.";
        }          
        else
        {
            lblMessages.Text = "";
            DataTable dt = new DataTable();
            dt.Columns.Add("Junan nro", typeof(string));
            dt.Columns.Add("Peruutettu", typeof(bool));
            dt.Columns.Add("Pvm", typeof(string));
            foreach (var train in trains)
            {
                dt.Rows.Add(train.trainNumber, train.cancelled, train.departureDate);
            }
            gvJunat.DataSource = dt;
            gvJunat.DataBind();
        }
    }
}