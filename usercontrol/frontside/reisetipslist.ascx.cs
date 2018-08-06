using System;
using System.Collections;
using System.Collections.Generic;
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
using System.Drawing.Printing;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

public partial class usercontrol_frontside_reisetipslist : System.Web.UI.UserControl
{
    //global
    int i;
    XmlNodeList elemList;
    List<string> namelist;
    protected void Page_Load(object sender, EventArgs e)
    {
        string foldpath = Request.PhysicalPath.ToString();
        //Create the XmlDocument.
        XmlDocument doc = new XmlDocument();
        string sub = foldpath.Substring(0, foldpath.Length - 15);
        doc.Load(sub + "reisetips.xml");
        elemList = doc.GetElementsByTagName("title");
        namelist = new List<string>();
        for (int j = 0; j < elemList.Count; j++)
        {
            namelist.Add(elemList[j].InnerText);
        }
        GridView1.DataSource = namelist;
        GridView1.DataBind();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string name = "";
        i = GridView1.SelectedIndex + (GridView1.PageIndex)*10;
        string foldpath = Request.PhysicalPath.ToString();
        //Create the XmlDocument.
        XmlDocument doc = new XmlDocument();
        string sub = foldpath.Substring(0, foldpath.Length - 15);
        doc.Load(sub + "reisetips.xml");
        elemList = doc.GetElementsByTagName("name");
        name = elemList[i].InnerText.ToString();
        Response.Redirect("~/Reise-Kina/" + name + ".htm");
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        string foldpath = Request.PhysicalPath.ToString();
        //Create the XmlDocument.
        XmlDocument doc = new XmlDocument();
        string sub = foldpath.Substring(0, foldpath.Length - 15);
        doc.Load(sub + "reisetips.xml");
        elemList = doc.GetElementsByTagName("title");
        namelist = new List<string>();
        for (int j = 0; j < elemList.Count; j++)
        {
            namelist.Add(elemList[j].InnerText);
        }
        GridView1.DataSource = namelist;
        GridView1.DataBind();
    }
}
