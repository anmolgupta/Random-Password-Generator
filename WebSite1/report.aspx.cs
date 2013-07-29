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

public partial class report : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int ch = DropDownList1.SelectedIndex;
        switch (ch)
        {
            case 1: Response.Redirect("name.aspx");
                break;
            case 2: Response.Redirect("date.aspx");
                break;
            case 3: Response.Redirect("show_all.aspx");
                break;
        }
    }
 
}
