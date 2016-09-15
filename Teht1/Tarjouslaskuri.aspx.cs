using System;
using System.Configuration; //Web.Configin lukemista varten
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

public partial class Tarjouslaskuri : System.Web.UI.Page
{
    float ikkunaLeveys;
    float ikkunaKorkeus;
    float karmiLeveys;

    float ala;
    float piiri;
    float hinta;

    float kate;
    float lasinNelioHinta;
    float alumiiniKarminJuoksumetriHinta;
    float tyoMenekki;

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            kate = float.Parse(ConfigurationManager.AppSettings["kate"]);
            lasinNelioHinta = float.Parse(ConfigurationManager.AppSettings["lasinNelioHinta"]);
            alumiiniKarminJuoksumetriHinta = float.Parse(ConfigurationManager.AppSettings["alumiiniKarminJuoksumetriHinta"]);
            tyoMenekki = float.Parse(ConfigurationManager.AppSettings["tyoMenekki"]);
        }
        catch (Exception ex)
        {
            lblAla.Text = ex.Message;
            lblKarmi.Text = ex.Message;
            lblHinta.Text = ex.Message;
        }
    }

    protected void btnLaske_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtIkkunaLeveys.Text.Length * txtIkkunaKorkeus.Text.Length * txtKarmiLeveys.Text.Length > 0)
            {
                ikkunaLeveys = float.Parse(txtIkkunaLeveys.Text);
                ikkunaKorkeus = float.Parse(txtIkkunaKorkeus.Text);
                karmiLeveys = float.Parse(txtKarmiLeveys.Text);

                lblAla.Text = LaskeAla();
                lblKarmi.Text = LaskePiiri();
                lblHinta.Text = LaskeHinta();
            }
            else
            {
                lblAla.Text = "Jokin kenttä tyhjä.";
                lblKarmi.Text = "Jokin kenttä tyhjä.";
                lblHinta.Text = "Jokin kenttä tyhjä.";
            }
        }
        catch (Exception ex)
        {
            lblAla.Text = ex.Message;
            lblKarmi.Text = ex.Message;
            lblHinta.Text = ex.Message;
        }
    }

    private string LaskeAla()
    {
        ala = (ikkunaLeveys / 1000) * (ikkunaKorkeus / 1000);
        return ala.ToString();
    }

    private string LaskePiiri()
    {
        piiri = 2 * ((ikkunaLeveys / 1000) + (ikkunaKorkeus / 1000));
        return piiri.ToString();
    }

    private string LaskeHinta()
    {
        hinta = (1 + kate) * ((ala * lasinNelioHinta) + (piiri * alumiiniKarminJuoksumetriHinta) + (tyoMenekki));
        return hinta.ToString("C2", CultureInfo.CreateSpecificCulture("fi-Fi"));
    }
}
