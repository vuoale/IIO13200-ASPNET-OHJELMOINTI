using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Lotto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnArvo_Click(object sender, EventArgs e)
    {
        int lkmRivit = 0;
        try
        {
            lkmRivit = Int32.Parse(txtLkmRivit.Text);
        }
        catch (Exception)
        {
            // do nothing...
        }

        if (lkmRivit > 0)
        {
            divRivit.InnerHtml = "";
            if (ddTyyppi.SelectedValue == "suomi")
            {
                for (int i = 0; i < lkmRivit; i++)
                {
                    var numerot = BLLotto.arvoSuomi();
                    var rivit = string.Join(", ", numerot);
                    divRivit.InnerHtml += rivit;
                    divRivit.InnerHtml += "<br />";
                }
            }
            else if (ddTyyppi.SelectedValue == "viking")
            {
                for (int i = 0; i < lkmRivit; i++)
                {
                    var numerot = BLLotto.arvoViking();
                    var rivit = string.Join(", ", numerot);
                    divRivit.InnerHtml += rivit;
                    divRivit.InnerHtml += "<br />";
                }
            }
        }
        else
        {
            divRivit.InnerHtml = "Rivien lkm -kenttään kelpaa vain positiiviset numerot.";
        }
    }
}