using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Customers;
using System.Threading;
using System.Net.Mail;
using System.Web.UI.HtmlControls;


public partial class Orderquery : System.Web.UI.Page
{
    #region
    ordercollection orders;
    ordercollection saveorders;
    int id;
    string ip;
    //string message = "wait";
    string message = "";
    order theOrder;
    Calendar mycalendar;
    Calendar mycalendar1;
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (agreeChk.Checked == true)
        {
            send.Enabled = true;
        }
        if (agreeChk.Checked == false)
        {
            send.Enabled = false;
        }
        if (departuredate.Value == "1" || departuredate.Value == "")
        {
            datelable.Visible = true;
            send.Enabled = false;
        }
        /*if (departuredate.SelectedItem != null && departuredate.SelectedItem.Text == "kommer senere")
        {
            send.Enabled = false;
        }*/
        if (Request.QueryString["reise1c"] != null)
        {
            Page.Title = "Bestill Reise - Rundereise i den mangfoldige Kina";
            trips.Text = "Rundereise i den mangfoldige Kina (12 dager)";
            HtmlHead head = (HtmlHead)this.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "description";
            meta.Content = "Være med oss på en eventyrreise til Kina. Fra store byer til landsbyer, fra det supermoderne til det tradisjonelle. Opplev Kinas historie, fargeriks kultur og vitalitet. En spennende og innholdsrik reise som er arrangert av dyktig guide.";
            head.Controls.Add(meta);
        }
        /*if (Request.QueryString["reise1b"] != null)
        {
            Page.Title = "Bestill Reise - Reise til Beijing, Shanghai og den mystiske sørvest-Kina";
            trips.Text = "Reise til Beijing, Shanghai og den mystiske sørvest-Kina (10 dager)";
            HtmlHead head = (HtmlHead)this.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "description";
            meta.Content = "Være med oss på en eventyrreise til Kina. Fra store byer til landsbyer, fra det supermoderne til det tradisjonelle. Opplev Kinas mangfoldie kulturer.";
            head.Controls.Add(meta);
        }
        if (Request.QueryString["reise9"] != null)
        {
            Page.Title = "Bestill Reise - Rundt i keisebyene (9 dager)";
            HtmlHead head = (HtmlHead)this.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "description";
            meta.Content = "billige reiser til Beijing og Xian. Opplev verdens kulturarv i Kina. En spennende og innholdsrik pakkereise som er arrangert av dyktig guide.";
            head.Controls.Add(meta);
            trips.Text = "Rundt i keisebyene (9 dager)";
        }*/
        /*if (Request.QueryString["reise3d"] != null)
        {
            Page.Title = "Bestill Reise - Kinas gyldne byer (10 dager)";
            HtmlHead head = (HtmlHead)this.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "description";
            meta.Content = "Ferietur til Kinas store byer - Beijing, Xi'an og Shanghai";
            head.Controls.Add(meta);
            trips.Text = "Kinas gyldne byer (10 dager)";
        }*/
        if (Request.QueryString["reise1"] != null)
        {
            Page.Title = "Bestill Reise - Hello Kina (8 dager)";
            HtmlHead head = (HtmlHead)this.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "description";
            meta.Content = "Billig pakketur til Kinas mest kjente byer Beijing og Shanghai. Flott reiseprogram, flinke guider og rimelig pris.";
            head.Controls.Add(meta);
            trips.Text = "Hello Kina (8 dager)";
        }
        /*if (Request.QueryString["reise18"] != null)
        {
            Page.Title = "Bestill Reise - Reise til Beijing, Xi'an, Tibet (med tog) og Shanghai (18 dager)";
            HtmlHead head = (HtmlHead)this.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "description";
            meta.Content = "Pakketur til verdens tak og kinesiske største byer. En spennende og innholdsrik reise til Beijing, Xi'an, Tibet og Shanghai.";
            head.Controls.Add(meta);
            trips.Text = "Reise til Beijing, Xi'an, Tibet (med tog) og Shanghai (18 dager)";
        }
        if (Request.QueryString["reise5b"] != null)
        {
            Page.Title = "Bestill Reise - Deluxe cruise på Yangtze (11 dager)";
            HtmlHead head = (HtmlHead)this.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "description";
            meta.Content = "Feriereise til verdens størrste kreftverk og verdens største byer i Kina. En spennende og innholdsrik reise til Beijing, Xi'an, Chongqing, Shanghai og Cruise på Yangtze-elven.";
            head.Controls.Add(meta);
            trips.Text = "Deluxe cruise på Yangtze (11 dager)";
        }
        */
        if (Request.QueryString["reise7d"] != null)
        {
            Page.Title = "Bestill Reise - Reise til Kinas store byer og tre kløfter (14 dager)";
            HtmlHead head = (HtmlHead)this.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "description";
            meta.Content = "Reis til Beijing, Xi'an, Chongqing, Tre kløfter, Yichang, Suzhou, Shanghai.";
            head.Controls.Add(meta);
            trips.Text = "Reise til Kinas store byer og tre kløfter (14 dager)";
        }
        /*if (Request.QueryString["reise7"] != null)
        {
            Page.Title = "Bestill Reise - En uke i Beijing (7 dager)";
            HtmlHead head = (HtmlHead)this.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "description";
            meta.Content = "Ferietur til Beijing. En spennende og innholdsrik pakkereise som er arrangert av dyktig guide/reiseleder.";
            head.Controls.Add(meta);
            trips.Text = "En uke i Beijing (7 dager)";
        }*/
        if (Request.QueryString["reise3t"] != null)
        {
            Page.Title = "Bestill Reise - Kinas gyldne tre-kanter (11 dager)";
            HtmlHead head = (HtmlHead)this.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "description";
            meta.Content = "Den klassiske rundreise til Kina. Opplev både moderne og tradisjonelle til Kina";
            head.Controls.Add(meta);
            trips.Text = "Reise til Kinas gyldne tre-kanter - Beijing, Xi'an, Shanghai, Suzhou og Shanghai (11 dager)";
        }
        if (Request.QueryString["reise4d"] != null)
        {
            Page.Title = "Bestill Reise - Den store kinareisen (18 dager)";
            HtmlHead head = (HtmlHead)this.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "description";
            meta.Content = "En stor rundreise til Kina. En omfattende eventyrtur arrangert av dyktig guide/reiseleder.";
            head.Controls.Add(meta);
            trips.Text = "Den sotre kinareisen - Beijing, Xi'an, Chengdu, Lijiang, Kunming, Guilin, Suzhou og Shanghai (18 dager)";
        }
        if (Request.QueryString["reise4b"] != null)
        {
            Page.Title = "Bestill Reise - Foto-tur til Tibet (18 dager)";
            HtmlHead head = (HtmlHead)this.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "description";
            meta.Content = "Foto-tur til Tibet, Beijing og Shanghai" ;
            head.Controls.Add(meta);
            trips.Text = "Foto-tur til Beijing, Tibet og Shanghai (18 dager)";
        }
        if (Hidden1.Value != "0")
        {
            mycalendar = new Calendar();
            mycalendar.Width = 50;
            mycalendar.Height = 50;
            //calendarpal.Controls.Add(mycalendar);
            departuredate.Value = Hidden1.Value;
        }
        if (message == "wait")
        {
            send.Enabled = false;
        }
    }

     protected void Page_Init(object sender, EventArgs e)
     {
        
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
    protected void Packageshandle_Click(object sender, EventArgs e)
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
    protected void send_Click(object sender, EventArgs e)
    {
        //save to database
        orders = new ordercollection();
        
        try
        {
            lock (orders)
            {
                createidcobling();
                if (id != null && id != 0)
                {
                   // theOrder = new order(id, 100 + id, departuredate.SelectedValue, nameTxt.Text, epostTxt.Text, teleTxt.Text, adresseTxt.Text, int.Parse(vokseTxt.SelectedValue), int.Parse(barnTxt.SelectedValue), int.Parse(babiTxt.SelectedValue), "", DateTime.Now, ip, "neworder", "");
                    theOrder = new order(id, 100 + id, departuredate.Value, nameTxt.Text, epostTxt.Text, teleTxt.Text, adresseTxt.Text, int.Parse(vokseTxt.SelectedValue), int.Parse(barnTxt.SelectedValue), int.Parse(babiTxt.SelectedValue), "", DateTime.Now, ip, "neworder", "");
                }
            }
            saveorders = new ordercollection(1);
            lock (saveorders)
            {
                savecobling();
            }
            //message = "deaktive";
            //send order info to administrator
            sendorder();
            //send receipt to epost
            sendreceipt();
            //sendnotice();
            message = "mail";
        }
        catch
        {
            
        }
        finally
        {
            if (message == "")
            {
                Response.Redirect("Hjelp.aspx?feilreport={0}");
            }
            else 
            {
                Response.Redirect("Hjelp.aspx?receipt={0}");
            }
        }

    }

    protected void createid(object obj)
    {
        id = ((ordercollection)obj).CreateOrderId();
    }

    protected void createidcobling()
    {
        ThreadPool.QueueUserWorkItem(new WaitCallback(createid), orders);
        Thread.Sleep(150);
        if (id == 0)
        {
            createidcobling();
        }
    }
    
    protected void save(object obj)
    {
        ((ordercollection)obj).Save();
    }

    protected void savecobling()
    {
        saveorders = new ordercollection(1);
        saveorders.Add(theOrder);
        ThreadPool.QueueUserWorkItem(new WaitCallback(save), saveorders);
        Thread.Sleep(150);
    }

    protected void sendreceipt()
    {
        string mailcont = "Hei " + nameTxt.Text + ": <br/><br/>" + "Dette er en automatisk bekreftelse på din bestilling. Vi kommer tilbake til deg så snart som mulig. <br/><br/>" + 
            "Din bestilling: <br/> " + trips.Text + " &nbsp;&nbsp;" + departuredate.Value +
            " <br/> " + vokseTxt.SelectedValue + " voksner <br/> " + barnTxt.SelectedValue + " barn <br/> " + babiTxt.SelectedValue + " babyer <br/> " + 
            "Postadresse: " + adresseTxt.Text + "<br/>" + 
            "Mobil: " + teleTxt.Text +
          "<br/><br/>Takk for bestilling!"
         + "<br/><br/> Med vennlig hilsen <br/> http://www.kinaturer.com";
        mailcont = mailcont.Replace(Environment.NewLine, "<br/>");
        //oppretterer en mail obsjekt
        MailMessage message = new MailMessage(
       "songcai342000@gmail.com",
       epostTxt.Text,
       "Kvittering", mailcont);
        SmtpClient client = new SmtpClient("smtp.bluecom.no");
        //SmtpClient client = new SmtpClient("smpt.gmail.no", 465);     
        //SmtpClient client = new SmtpClient("smpt.kinaturer.no", 587);       
       //client.Credentials = new System.Net.NetworkCredential("order@kinaturer.com", "orderpassword12");
      // client.Credentials = new System.Net.NetworkCredential("songcai342000@gmail.com", "9634441102sC");


        message.IsBodyHtml = true;

        //SmtpClient client = new SmtpClient("smtp.bluecom.no");
        client.UseDefaultCredentials = false;

        client.Send(message);
    }

    protected void sendorder()
    {
        string mailcont = "Hei " + nameTxt.Text + ": <br/><br/>" + "Dette er en automatisk bekreftelse på din bestilling. Vi kommer tilbake til deg så snart som mulig. <br/><br/>" +
            "Din bestilling: <br/> " + trips.Text + " &nbsp;&nbsp;" + departuredate.Value +
            " <br/> " + vokseTxt.SelectedValue + " voksner <br/> " + barnTxt.SelectedValue + " barn <br/> " + babiTxt.SelectedValue + " babyer <br/> " +
            "Mobil: " + teleTxt.Text + "<br/>" +
            "Epost: " + epostTxt.Text + "<br/>" +
            "Postadresse: " + adresseTxt.Text + 
          "<br/><br/>Takk for bestilling!"
         + "<br/><br/> Med vennlig hilsen <br/> http://www.kinaturer.com";
        mailcont = mailcont.Replace(Environment.NewLine, "<br/>");
        //oppretterer en mail obsjekt
        MailMessage message = new MailMessage(
       //"order@kinaturer.com",
       "songcai342000@yahoo.com",
       "songcai342000@gmail.com",
       "Ny bestilling", mailcont);
        //SmtpClient client = new SmtpClient("filter.fastname.com", 25);
        message.IsBodyHtml = true;
        //SmtpClient client = new SmtpClient("smpt.kinaturer.no", 587);
        SmtpClient client = new SmtpClient("smtp.bluecom.no");
        //client.Credentials = new System.Net.NetworkCredential("order@kinaturer.com", "orderpassword12");
        //SmtpClient client = new SmtpClient("smtp.bluecom.no");
        client.UseDefaultCredentials = false;
        client.Send(message);
    }

    protected void sendnotice()
    {
        string mailcont = "Hei " + nameTxt.Text + ": <br/><br/>" + "Dette er en automatisk bekreftelse på din bestilling. Vi kommer tilbake til deg så snart som mulig. <br/><br/>" +
            "Din bestilling: <br/> " + trips.Text + " &nbsp;&nbsp;" + departuredate.Value +
            " <br/> " + vokseTxt.SelectedValue + " voksner <br/> " + barnTxt.SelectedValue + " barn <br/> " + babiTxt.SelectedValue + " babyer <br/> " +
            "Mobil " + teleTxt.Text + "<br/>" +
            "Epost " + epostTxt.Text + "<br/>" +
            "Adresse: " + adresseTxt.Text + 
          "<br/><br/>Takk for bestilling!"
         + "<br/><br/> Med vennlig hilsen <br/> http://www.kinaturer.com";
        mailcont = mailcont.Replace(Environment.NewLine, "<br/>");
        //oppretterer en mail obsjekt
        MailMessage message = new MailMessage(
       //"order@kinaturer.com",
       "songcai342000@yahoo.com",
       "songcai342000@gmail.com",
       "Ny bestilling", mailcont);
        SmtpClient client = new SmtpClient("smtp.bluecom.no");
        //client.Credentials = new System.Net.NetworkCredential("order@kinaturer.com", "orderpassword12");

        message.IsBodyHtml = true;

        // SmtpClient client = new SmtpClient("smtp.bluecom.no");
        client.UseDefaultCredentials = false;

        client.Send(message);
    }

    protected void cancel_Click(object sender, EventArgs e)
    {
          //clear datas
        nameTxt.Text = "";
        teleTxt.Text = "(+47)";
        epostTxt.Text = "";
        vokseTxt.Text = "";
        barnTxt.Text = "";
        babiTxt.Text = "";
        adresseTxt.Text = "";
        vokseTxt.SelectedValue = "1";
        barnTxt.SelectedValue = "0";
        babiTxt.SelectedValue = "0";
       // departuredate.SelectedValue = "";
        agreeChk.Checked = false;
    }

    /*protected void mycalendar_SelectionChanged(object sender, EventArgs e)
    {
        Hidden1.Value = mycalendar.SelectedDate.ToString();
    }*/

    protected void mycalendar1_SelectionChanged(object sender, EventArgs e)
    {
        Hidden1.Value = mycalendar1.SelectedDate.ToString().Substring(0, mycalendar1.SelectedDate.ToString().Length - 9);
        if (Hidden1.Value != "1")
        {
            departuredate.Value = Hidden1.Value;
        }
    }
    protected void UpdatePanel1_Load(object sender, EventArgs e)
    {
        mycalendar1 = new Calendar();
        if (Hidden1.Value != "")
        {
            PlaceHolder1.Controls.Add(mycalendar1);
            mycalendar1.SelectionChanged += new EventHandler(mycalendar1_SelectionChanged);
            if (departuredate.Value != "")
            {
                datelable.Visible = false;
            }
        }
    }
   
}
