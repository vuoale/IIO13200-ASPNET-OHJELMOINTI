using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LuoAsiakas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCreateCustomer_Click(object sender, EventArgs e)
    {
        using (DemoxOyEntities db = new DemoxOyEntities())
        {
            asiakas a = new asiakas();
            a.asnimi = txtNimi.Text;
            a.astunnus = txtTunnus.Text;
            a.asvuosi = short.Parse(txtVuosi.Text);
            a.maa = txtMaa.Text;
            a.ostot = double.Parse(txtOstot.Text);
            a.postinro = txtPostinro.Text;
            a.postitmp = txtPostitmp.Text;
            a.yhteyshlo = txtYhtHlo.Text;
            db.asiakas.Add(a);
            db.SaveChanges();
            lblMessages.Text = "Asiakas " + a.asnimi + " luotu onnistuneesti.";
        }
    }
}