using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Asiakkaat : System.Web.UI.Page
{
    protected static DemoxOyEntities ctx;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ctx = new DemoxOyEntities();
            InitCountries();
        }
    }

    protected void InitCountries()
    {
        ddlCountries.DataSource = (from c in ctx.asiakas orderby c.maa select c.maa).Distinct().ToList();
        ddlCountries.DataBind();
    }

    protected void btnGetCustomers_Click(object sender, EventArgs e)
    {
        gvCustomers.DataSource = ctx.asiakas.ToList();
        gvCustomers.DataBind();
    }

    protected void btnGetCustomersFromCountry_Click(object sender, EventArgs e)
    {
        string selectedCountry = ddlCountries.Text;
        gvCustomers.DataSource = (from c in ctx.asiakas where c.maa == selectedCountry select c).ToList();
        gvCustomers.DataBind();
    }

    protected void btnGetCustomersByCountry_Click(object sender, EventArgs e)
    {
        List<asiakas> customers = (from c in ctx.asiakas orderby c.maa select c).ToList();
        List<string> countries = (from c in ctx.asiakas orderby c.maa select c.maa).Distinct().ToList();
        lblCustomersByCountry.Text = "";
        foreach (var country in countries)
        {
            lblCustomersByCountry.Text += "<h2 style='color:green'>" + country + "</h2>";
            foreach (var customer in customers)
            {
                if (customer.maa == country)
                {
                    lblCustomersByCountry.Text += "<span style='color:blue'>" + customer.asnimi + "</span><br>";
                }
            }
        }
    }
}