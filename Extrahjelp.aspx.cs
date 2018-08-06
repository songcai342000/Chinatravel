using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Web.UI.HtmlControls;


public partial class Extrahjelp : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //string hosturl = Request.Url.ToString().Substring(0, 35);
        //string xx = ("http://www.kinaturer.com/Kina/mer-fakta-om-kina.htm").Substring(0, 25);
        string hosturl = Request.Url.ToString().Substring(0, 35);                                                       
        kina.HRef = hosturl + "Default.aspx?package=start";
        beijing.HRef = hosturl + "Default.aspx?package=beijing";
        xian.HRef = hosturl + "Default.aspx?package=xian";
        guizhou.HRef = hosturl + "Default.aspx?package=guizhou";
        guilin.HRef = hosturl + "Default.aspx?package=guilin";
        shanghai.HRef = hosturl + "Default.aspx?package=shanghai";
        tibet.HRef = hosturl + "Default.aspx?package=tibet";
        reiser.HRef = hosturl + "Packages.aspx?package=package";
        hotel.HRef = hosturl + "Extrahjelp.aspx?hotel=hotel";
        blogg.HRef = hosturl + "blogg/spennende-påsketur-i-kina.htm";
        agreement.HRef = hosturl + "Packages.aspx?agreement={0}";
        questions.HRef = hosturl + "Packages.aspx?questions={0}";
        //contact.HRef = "http://www.kinaturer.com/Reisebyrå/kontaktinfo.htm";
        //aboutus.HRef = "http://www.kinaturer.com/Reisebyrå/om-oss.htm";
        contact.HRef = hosturl + "Extrahjelp.aspx?contact=kontaktinfo";
        aboutus.HRef = hosturl + "Extrahjelp.aspx?aboutus=om-oss";
        if (Request.QueryString["contact"] != null)
        {
            Page.Title = "Reisebyrå - Uforglemmelig Kina Tur - Kontakt informasjon";
            Control cl = LoadControl("~/usercontrol/frontside/contact.ascx");
            contentpan.Controls.Add(cl);
        }
        if (Request.QueryString["reiseleder"] != null)
        {
            Page.Title = "Reisebyrå - Uforglemmelig Kina Tur - Ledig stilling";
            Control cl = LoadControl("~/usercontrol/frontside/reiseleder.ascx");
            contentpan.Controls.Add(cl);
        }
        if (Request.QueryString["aboutus"] != null)
        {
            Page.Title = "Reisebyrå - Reisebyrå på nett - Reiser til Kina";
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "billig reisebyrå, kina turer, reisebyrå på nett";
            HtmlMeta meta1 = new HtmlMeta();
            meta1.Name = "description";
            meta1.Content = "Uforglemmelig Kina Tur er et reisebyrå på nett. Vi arrangerer spennende reiser til Kina. Vi tilbyr også mange andre tjenester som er relevante til Kina-reiser. Vi er speialist innen Kina. Velg oss som ditt reisebyrå til Kina.";
            head.Controls.Add(meta1);
            head.Controls.Add(meta);
            Control cl = LoadControl("~/usercontrol/frontside/omoss.ascx");
            contentpan.Controls.Add(cl);
        }
        if (Request.QueryString["skreddersydde"] != null)
        {
            Page.Title = "Skreddersydde reiser - Reise til Kina";
            Control cl = LoadControl("~/usercontrol/frontside/skreddersyddereiser.ascx");
            contentpan.Controls.Add(cl);
        }
        if (Request.QueryString["reisetips"] != null)
        {
            Control cl = LoadControl("~/usercontrol/frontside/reisetips.ascx");
            contentpan.Controls.Add(cl);
        }
        if (Request.QueryString["kina"] != null)
        {
            Control cl = LoadControl("~/usercontrol/frontside/kina.ascx");
            contentpan.Controls.Add(cl);
        }
        if (Request.QueryString["hotel"] != null)
        {
            Page.Title = "Visum til Kina - Vi kan hjelpe deg med å ordne visum til Kina";
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "Visum til Kina, Kinesisk visum, Kina visum";
            head.Controls.Add(meta);
            Control cl = LoadControl("~/usercontrol/frontside/sendforsporsel.ascx");
            contentpan.Controls.Add(cl);
        }
        if (Request.QueryString["blogg"] != null)
        {
            Control cl = LoadControl("~/usercontrol/frontside/blogg.ascx");
            contentpan.Controls.Add(cl);
        }
        if (Request.QueryString["content"] != null)
        {
            Page.Title = "Skreddersydde reiser - Reise til Kina";
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "Skreddersydde reiser til Kina, billige reiser, tema reiser, opplevelses reiser, til Asia, til kina";
            head.Controls.Add(meta);
            Control cl = LoadControl("~/usercontrol/frontside/skreddersyddereiser.ascx");
            contentpan.Controls.Add(cl);
        }
        if (Request.QueryString["pensjonistreiser"] != null)
        {
            Page.Title = "Pensjonist reiser - Gode tilbud på pakkereiser til Kina";
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "pensjonist, pensjonist reisebyrå, pensjonist reiser, pensjonist tur, billige reiser til Kina";
            head.Controls.Add(meta);
            Control cl = LoadControl("~/usercontrol/frontside/pensjonistreiser.ascx");
            contentpan.Controls.Add(cl);
        }
        if (Request.QueryString["annonser"] != null)
        {
            Control cl = LoadControl("~/usercontrol/frontside/annonser.ascx");
            contentpan.Controls.Add(cl);
        }
        if (Request.QueryString["reisetipslist"] != null)
        {
            Page.Title = "Severdigheter i Kina - Vi tilbyr gruppereiser og individuelle reiser til Kina";
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "severdigheter i Kina, kinesiske severdigheter";
            head.Controls.Add(meta);
            Control cl = LoadControl("~/usercontrol/frontside/reisetipslist.ascx");
            contentpan.Controls.Add(cl);
        }
    }

  

}
