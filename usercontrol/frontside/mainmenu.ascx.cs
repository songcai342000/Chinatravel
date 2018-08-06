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

public partial class usercontrol_mainmenu : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["choose"] == null)
        {
            Session["choose"] = "start";
        }
    }

    protected void start_Click(object sender, EventArgs e)
    {
        Session["choose"] = "start";

    }
    protected void Beijing_Click(object sender, EventArgs e)
    {
        Session["choose"] = "start";

    }
    protected void Xian_Click(object sender, EventArgs e)
    {
        Session["choose"] = "xian";

    }
    protected void Guizhou_Click(object sender, EventArgs e)
    {
        Session["choose"] = "guizhou";

    }
    protected void Shanghai_Click(object sender, EventArgs e)
    {
        Session["choose"] = "shanghai";

    }
    protected void Packages_Click(object sender, EventArgs e)
    {
        Session["choose"] = "package";

    }
    protected void Guilin_Click(object sender, EventArgs e)
    {
        Session["choose"] = "Guilin";

    }
}
