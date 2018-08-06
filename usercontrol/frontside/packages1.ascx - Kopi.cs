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
using Customers;
using System.Threading;
using System.Net.Mail;


public partial class usercontrol_frontside_packages1 : System.Web.UI.UserControl
{
    int id;
    newsletter regiter;
    newslettercollection letters;
    string message = "";
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }


    protected void regi_Click(object sender, EventArgs e)
    {
        //save to database
        regiter = new newsletter();
        letters = new newslettercollection(1);
        try
        {
            lock (regiter)
            {
                createidcobling();
                if (id != null && id != 0)
                {
                    regiter = new newsletter(id, epost.Text, pensjonist.Checked.ToString());
                }
            }
            letters = new newslettercollection(1);
            lock (letters)
            {
                savecobling();
            }
            //send receipt to epost
           // sendreceipt();
        }
        catch
        {
            message = "feil";
        }
        finally
        {
            if (message == "")
            {

                Response.Redirect("Hjelp.aspx?receipt={0}");
            }
            else
            {
                
                Response.Redirect("Hjelp.aspx?feilreport={0}");
            }
        }
    }
    protected void avregi_Click(object sender, EventArgs e)
    {
        letters = new newslettercollection();
        try
        {
            lock (letters)
            {
                subscriptioncobling();
            }
        }
        catch
        {
            message = "feil";
        }
        finally
        {
            if (message == "")
            {

                Response.Redirect("Hjelp.aspx?avnewsletter={0}");
            }
            else
            {
                Response.Redirect("Hjelp.aspx?feilreport={0}");
            }
        }
    }

    protected void sendreceipt()
    {
        string mailcont = "Takk for registering! For å sikre at du kan motta alle nyhetersbrev fra oss, bør du legge oss i din kontaktlist <br/>" +
        "Dersom du ikke vil motta flere nyheterbrev, kan du avregistere deg på http://www.kinaturer.com."
         + "<br/><br/> Med vennlig hilsen <br/> http://www.kinaturer.com";
        mailcont = mailcont.Replace(Environment.NewLine, "<br/>");
        //oppretterer en mail obsjekt
        MailMessage message = new MailMessage(
       "nyhetsbrev@kinaturer.com",
       epost.Text,
       "Kvittering", mailcont);
        SmtpClient client = new SmtpClient("filter.fastname.no", 25);
        // client.Credentials = new System.Net.NetworkCredential("order@kinaturer.com", "orderpassword12");
        message.IsBodyHtml = true;

        //SmtpClient client = new SmtpClient("smtp.bluecom.no");
        client.UseDefaultCredentials = false;

        client.Send(message);
    }

    protected void createid(object obj)
    {
        id = ((newslettercollection)obj).CreateLetterId();
    }

    protected void createidcobling()
    {
        ThreadPool.QueueUserWorkItem(new WaitCallback(createid), letters);
        Thread.Sleep(150);
        if (id == 0)
        {
            createidcobling();
        }
    }

    protected void subscriptioncobling()
    {
        ThreadPool.QueueUserWorkItem(new WaitCallback(subscription), letters);
        Thread.Sleep(150);
    }

    protected void subscription(object obj)
    {
        ((newslettercollection)obj).DeleteByEpost(epost.Text);
    }


    protected void save(object obj)
    {
        ((newslettercollection)obj).Save();
    }

    protected void savecobling()
    {
        letters = new newslettercollection(1);
        letters.Add(regiter);
        ThreadPool.QueueUserWorkItem(new WaitCallback(save), letters);
        Thread.Sleep(150);
    }

    protected void chose_Click(object sender, EventArgs e)
    {
        if (reisen.SelectedIndex == 1)
        {
            Response.Redirect("~/Orderquery.aspx?reise1b={0}");
        }
        else if (reisen.SelectedIndex == 2)
        {
            Response.Redirect("~/Orderquery.aspx?reise1c={0}");
        }
        else if (reisen.SelectedIndex == 3)
        {
            Response.Redirect("~/Orderquery.aspx?reise9b={0}");
        }
        else if (reisen.SelectedIndex == 4)
        {
            Response.Redirect("~/Orderquery.aspx?reise18={0}");
        }
        else if (reisen.SelectedIndex == 5)
        {
            Response.Redirect("~/Orderquery.aspx?reise5b={0}");
        }
        /*else if (reisen.SelectedIndex == 6)
        {
            Response.Redirect("~/Orderquery.aspx?reise8={0}");
        }*/
        else if (reisen.SelectedIndex == 6)
        {
            Response.Redirect("~/Orderquery.aspx?reise10={0}");
        }
        else if (reisen.SelectedIndex == 7)
        {
            Response.Redirect("~/Orderquery.aspx?reise7={0}");
        }
 
        else if (reisen.SelectedIndex == 8)
        {
            Response.Redirect("~/Orderquery.aspx?reise11={0}");
        }
        else if (reisen.SelectedIndex == 9)
        {
            Response.Redirect("~/Orderquery.aspx?reise8={0}");
        }
    }
}
