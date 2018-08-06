using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;
using System.Web.UI.HtmlControls;

public partial class usercontrol_frontside_kina : System.Web.UI.UserControl
{
    int i;
    XmlNodeList elemList;
    protected void Page_Load(object sender, EventArgs e)
    {
        string content = "";
        string title = "";
        string keywords = "";
        string description = "";
        string foldpath = Server.MapPath("kina.xml");
        //Create the XmlDocument.
        XmlDocument doc = new XmlDocument();
        doc.Load(foldpath);
        //Display End_TIME
        elemList = doc.GetElementsByTagName("name");
        for (i = 0; i< elemList.Count; i++)
        {
            string querystringvalue = Request.QueryString["kina"].ToString();
            if (elemList[i].InnerText.ToString() == querystringvalue)
            {
                //test ng = querystringvalue;
                XmlNodeList elemList0 = doc.GetElementsByTagName("title");
                title = elemList0[i].InnerText.ToString();
                XmlNodeList elemList1 = doc.GetElementsByTagName("content");
                content = elemList1[i].InnerText.ToString();
                XmlNodeList elemList2 = doc.GetElementsByTagName("keywords");
                keywords = elemList2[i].InnerText.ToString();
                XmlNodeList elemList3 = doc.GetElementsByTagName("description");
                description = elemList3[i].InnerText.ToString();
                titleLit.Text = title;
                content = content.Replace(Environment.NewLine, "<br/>");
                //contentLit.Text = querystringvalue;
                contentLit.Text = content;
                //test ng = querystringvalue;
                HtmlHead head = Page.Header;
                HtmlMeta meta = new HtmlMeta();
                meta.Name = "keyword";
                meta.Content = keywords;
                head.Controls.Add(meta);
                HtmlMeta meta1 = new HtmlMeta();
                meta1.Name = "description";
                meta1.Content = description;
                head.Controls.Add(meta1);
                break;
            }
        }
        if (i == 0)
        {
            previous.Visible = false;
        }
        Page.Title = title + " - Våre reiser - Reiser til Kina";
        if (i > 0)
        {
            //string hosturl = Request.Url.ToString().Substring(0, 35);
             string hosturl = Request.Url.ToString().Substring(0, 25);
            //previous.HRef = hosturl + "Kina/" + elemList[i - 1].InnerText + ".htm";  
             previous.HRef = "";
        }
    }

}
