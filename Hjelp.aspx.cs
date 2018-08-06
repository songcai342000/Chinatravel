using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

public partial class Hjelp : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["contact"] != null)
        {
            Page.Title = "Uforglemmelig Kina Tur - Kontakt informasjon";
            Control cl = LoadControl("~/usercontrol/frontside/contact.ascx");
            contentpan.Controls.Add(cl);
        }
        if (Request.QueryString["aboutus"] != null)
        {
            Page.Title = "Uforglemmelig Kina Tur - Om oss";
            Control cl = LoadControl("~/usercontrol/frontside/omoss.ascx");
            contentpan.Controls.Add(cl);
        }
        if (Request.QueryString["receipt"] != null)
        {
            Page.Title = "Uforglemmelig Kina Tur - Takk for bestilling";
            Control cl = LoadControl("~/usercontrol/frontside/receipt.ascx");
            contentpan.Controls.Add(cl);
        }
        if (Request.QueryString["avnewsletter"] != null)
        {
            Page.Title = "Uforglemmelig Kina Tur - Avregistere";
            Control cl = LoadControl("~/usercontrol/frontside/avreceipt.ascx");
            contentpan.Controls.Add(cl);
        }
        if (Request.QueryString["feilreport"] != null)
        {
            Page.Title = "Uforglemmelig Kina Tur - Feilmelding";
            Control cl = LoadControl("~/usercontrol/frontside/feilreport.ascx");
            contentpan.Controls.Add(cl);
            try
            {
                sendfeilmeldning();
            }
            catch
            { 
            
            }
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
        if (Request.QueryString["content"] != null)
        {
            Page.Title = "Skreddersydde reiser - Reise til Kina";
            Control cl = LoadControl("~/usercontrol/frontside/skreddersyddereiser.ascx");
            contentpan.Controls.Add(cl);
        }
    }

    protected void start_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx?package=start");

    }
    protected void Beijing_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx?package=beijing");

    }
    protected void Xian_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx?package=xian");

    }
    protected void Guizhou_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx?package=guizhou");

    }
    protected void Shanghai_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx?package=shanghai");

    }
    protected void Packages_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Packages.aspx?package=package");

    }
    protected void Guilin_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx?package=guilin");

    }
    protected void Tibet_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx?package=tibet");

    }
    protected void Hotel_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Extrahjelp.aspx?hotel=hotel");

    }
    protected void blogg_Click(object sender, EventArgs e)
    {
        Response.Redirect("http://www.kina-reise.blogspot.com");

    }

    protected void sendfeilmeldning()
    {
        string mailcont = "feil med newsletter registrering eller bestilling";
        mailcont = mailcont.Replace(Environment.NewLine, "<br/>");
        //oppretterer en mail obsjekt
        MailMessage message = new MailMessage(
       //"nyhetsbrev@kinaturer.com",
       "songcai342000@gmail.com",
       "songcai342000@yahoo.com",
       "feil medlning newsletter", mailcont);
        SmtpClient client = new SmtpClient("smtp.bluecom.no");
        // client.Credentials = new System.Net.NetworkCredential("order@kinaturer.com", "orderpassword12");


        message.IsBodyHtml = true;

        //SmtpClient client = new SmtpClient("smtp.bluecom.no");
        client.UseDefaultCredentials = false;

        client.Send(message);
    }

}
