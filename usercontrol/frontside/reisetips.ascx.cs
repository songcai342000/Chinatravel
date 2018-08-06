using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;

public partial class usercontrol_frontside_reisetips : System.Web.UI.UserControl
{
    int i;
    XmlNodeList elemList;
    protected void Page_Load(object sender, EventArgs e)
    {
        string content = "";
        string title = "";
        string foldpath = Request.PhysicalPath.ToString();
        //Create the XmlDocument.
        XmlDocument doc = new XmlDocument();
        string sub = foldpath.Substring(0, foldpath.Length - 15);
        doc.Load( sub + "reisetips.xml");
        //Display End_TIME
        elemList = doc.GetElementsByTagName("name");
        for (i = 0; i < elemList.Count; i++)
        {
            string querystringvalue = Request.QueryString["reisetips"]; 
            if (elemList[i].InnerText.ToString() == querystringvalue)
            {
                XmlNodeList elemList0 = doc.GetElementsByTagName("title");
                title = elemList0[i].InnerText.ToString();
                XmlNodeList elemList1 = doc.GetElementsByTagName("content");
                content = elemList1[i].InnerText.ToString();
                titleLit.Text = title;
                contentLit.Text = content;
                break;
            }
        }
        if (i == 0)
        {
            previous.Visible = false;
        }
        Page.Title = title + " - Praktfulle Kina - Reise med oss til Kina";
        if (i > 1)
        {
            //string hosturl = Request.Url.ToString().Substring(0, 35);
           string hosturl = Request.Url.ToString().Substring(0, 25);
            previous.HRef = hosturl + "Reise-Kina/" + elemList[i - 1].InnerText + ".htm";
        }
    }

}
