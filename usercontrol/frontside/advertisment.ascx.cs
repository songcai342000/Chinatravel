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
using System.Xml;
using System.IO;
using System.Timers;


public partial class usercontrol_frontside_advertisment : System.Web.UI.UserControl
{
    XmlNodeList elemList1;
    string content = "";
   
    protected void Page_Load(object sender, EventArgs e)
    {
       
        int daynumber = 0;
        if (DateTime.Now.Date != null)
        {
            string foldpath = Server.MapPath("reisetips.xml");
            //Create the XmlDocument.
            XmlDocument doc = new XmlDocument();
            //string sub = foldpath.Substring(0, foldpath.Length - 12);
            //doc.Load(sub + "reisetips.xml");
            doc.Load(foldpath);
            //Display End_TIME
            //elemList = doc.GetElementsByTagName("id");
            elemList1 = doc.GetElementsByTagName("content");
            daynumber = int.Parse(DateTime.Now.Date.ToString().Substring(0, 2));
            /*if (elemList1.Count > 97 + daynumber)
            {
                //int daynumber = int.Parse(("01").ToString());
                indexValue = 97 + daynumber;
                //indexValue = 70+1;
                gettipsnow();
                //getitem();
            }
            else
            {
                daynumber = int.Parse(DateTime.Now.Date.ToString().Substring(0, 2));
                indexValue = daynumber;
                //indexValue = 70+1;
                gettipsnow();
            }*/
            indexValue = elemList1.Count - 32 + daynumber;
            //indexValue = 70+1;
            gettipsnow();

            //XmlNodeList elemList2 = doc.GetElementsByTagName("name");
            //string hosturl = Request.Url.ToString().Substring(0, 35);
            //string hosturl = Request.Url.ToString().Substring(0, 32);
            //qi.HRef = hosturl + "Reise-Kina/" + elemList2[elemList1.Count - 1].InnerText + ".htm";
        }
    }

  

    protected void gettipsnow()
    {
        content = elemList1[IndexValue].InnerText.ToString();
        content = content.Replace(Environment.NewLine, "<br/>");
        contentLit.Text = content;

    }

    //use control state to choose article id 
    protected void gettips()
    {
        string foldpath = Server.MapPath("reisetips.xml");
        //Create the XmlDocument.
        XmlDocument doc = new XmlDocument();
        //string sub = foldpath.Substring(0, foldpath.Length - 12);
        //doc.Load(sub + "reisetips.xml");
        doc.Load(foldpath);
        //Display End_TIME
        //elemList = doc.GetElementsByTagName("id");
        elemList1 = doc.GetElementsByTagName("content");
        content = elemList1[IndexValue].InnerText.ToString();
        //content = content.Replace(Environment.NewLine, "<br/>");
        contentLit.Text = content;
    }

    //control state function
    int indexValue;
    public int IndexValue
    {
        get
        {
            return indexValue;
        }
        set
        {
            indexValue = value;
        }
    }
   /* protected override void OnInit(EventArgs e)
    {
        base.OnInit(e);
        Page.RegisterRequiresControlState(this);
    }

    protected override object SaveControlState()
    {
        // Invoke the base class's method and
        // get the contribution to control state
        // from the base class.
        // If the indexValue field is not zero
        // and the base class's control state is not null,
        // use Pair as a convenient data structure
        // to efficiently save 
        // (and restore in LoadControlState)
        // the two-part control state
        // and restore it in LoadControlState.

        Object obj = base.SaveControlState();

        if (indexValue != 0)
        {
            if (obj != null)
            {
                return new Pair(obj, indexValue);
            }
            else
            {
                return (indexValue);
            }
        }
        else
        {
            return obj;
        }
    }

    protected override void LoadControlState(object state)
    {
        if (state != null)
        {
            Pair p = state as Pair;
            if (p != null)
            {
                base.LoadControlState(p.First);
                indexValue = (int)p.Second;
            }
            else
            {
                if (state is int)
                {
                    indexValue = (int)state;
                }
                else
                {
                    base.LoadControlState(state);
                }
            }
        }
    }*/
}
