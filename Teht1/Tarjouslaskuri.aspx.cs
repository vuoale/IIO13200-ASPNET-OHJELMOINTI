using System;
using System.Configuration; //Web.Configin lukemista varten
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tarjouslaskuri : System.Web.UI.Page
{
    float ikkunaLeveys;
    float ikkunaKorkeus;
    float karmiLeveys;

    float ala;
    float piiri;
    float hinta;

    int kate;
    int lasinNelioHinta;
    int alumiiniKarminJuoksumetriHinta;
    int tyoMenekki;

    protected void Page_Load(object sender, EventArgs e)
    {
        kate = Int32.Parse(ConfigurationManager.AppSettings["kate"]);
        lasinNelioHinta = Int32.Parse(ConfigurationManager.AppSettings["lasinNelioHinta"]);
        alumiiniKarminJuoksumetriHinta = Int32.Parse(ConfigurationManager.AppSettings["alumiiniKarminJuoksumetriHinta"]);
        tyoMenekki = Int32.Parse(ConfigurationManager.AppSettings["tyoMenekki"]);
    }

    protected void btnLaske_Click(object sender, EventArgs e)
    {
        ikkunaLeveys = float.Parse(txtIkkunaLeveys.Text);
        ikkunaKorkeus = float.Parse(txtIkkunaKorkeus.Text);
        karmiLeveys = float.Parse(txtKarmiLeveys.Text);

        lblAla.Text = LaskeAla();
        lblKarmi.Text = LaskePiiri();
        lblHinta.Text = LaskeHinta();
    }

    private string LaskeAla()
    {
        ala = ikkunaLeveys * ikkunaKorkeus;
        return ala.ToString();
    }

    private string LaskePiiri()
    {
        piiri = 2 * ikkunaLeveys + 2 * ikkunaKorkeus;
        return piiri.ToString();
    }

    private string LaskeHinta()
    {
        hinta = (1 + kate) * ((ala * lasinNelioHinta) + (piiri * alumiiniKarminJuoksumetriHinta) + (tyoMenekki));
        return hinta.ToString();
    }
}
