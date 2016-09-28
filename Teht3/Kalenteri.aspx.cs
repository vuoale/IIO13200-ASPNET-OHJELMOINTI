using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Kalenteri : System.Web.UI.Page
{
    DateTime date;
    const double ApproxDaysPerMonth = 30.4375;
    const double ApproxDaysPerYear = 365.25;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            kalenteri.VisibleDate = DateTime.Today;
            lblPvm.Text = "Tänään on: " + kalenteri.TodaysDate.ToShortDateString();
        }
    }

    protected void kalenteri_SelectionChanged(object sender, EventArgs e)
    {        
        lblValittu.Text = "Valittu: " + kalenteri.SelectedDate.ToShortDateString();
        int days = (int)kalenteri.SelectedDate.Subtract(kalenteri.TodaysDate).TotalDays;
        int years = (int)(days / ApproxDaysPerYear);
        days -= (int)(years * ApproxDaysPerYear);
        int months = (int)(days / ApproxDaysPerMonth);
        days -= (int)(months * ApproxDaysPerMonth);
        lblErotus.Text = "Valitun päivän ja tämän päivän erotus: <b>" + years + " v, " + months + " kk, " + days + " pv." + "</b>";
    }

    protected void btnEdellinen_Click(object sender, EventArgs e)
    {
        date = kalenteri.VisibleDate;
        date = date.AddYears(-1);
        kalenteri.VisibleDate = date;
    }

    protected void btnSeuraava_Click(object sender, EventArgs e)
    {
        date = kalenteri.VisibleDate;
        date = date.AddYears(1);
        kalenteri.VisibleDate = date;
    }
}