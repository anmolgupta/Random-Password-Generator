using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Page.IsPostBack==false)
        Session["n"]=""+0;
    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        string[] str = { "rand.jpg","designed.jpg",  "hcl.jpg" };
        int n = Convert.ToInt32(""+Session["n"]);
            Image1.ImageUrl = "~/images/" + str[n];
            if (n == 2)
            {
                n = 0;
            }
            else
            {
                n++;
            }
            Session["n"] = "" + n;
    }
}
