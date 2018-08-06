using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Customers;
using System.Threading;
using System.Net.Mail;
using System.Data;
using System.IO;
using System.Text;
using System.Security.Cryptography;

public partial class Order : System.Web.UI.Page
{
    TextBox checkepostTxt;
    int ordernumber;
    DataTable thetable;
    ordercollection orders;
    customer thecustomer;
    customercollection customers;
    customercollection customers1;
    int updateid;
    int id;
    int item;
    string decryptsubstring;
    string feilmessage;
    string fullurl;

    public int IndexValue
    {
        get
        {
            return customerregistration1.IndexValue;
        }
        set
        {
            customerregistration1.IndexValue = value;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Page_UnLoad(object sender, EventArgs e)
    {
        /*try
        {
            getnewregistreringcobling();
            if (thetable.Rows.Count > 0 && IndexValue == 1)
            {
                sendunfinishedregistrering();
                sendunfinishednotice();
            }
        }
        catch
        { 
        }*/
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
    protected void blogg_Click(object sender, EventArgs e)
    {
        Response.Redirect("http://www.kina-reise.blogspot.com");

    }
    protected void UpdatePanel1_Load(object sender, EventArgs e)
    {
        fullurl = Request.Url.ToString();
        //decryp the encrypt part
        if (fullurl.Contains("?") && fullurl.Length > 36)
        {
            string parturl = fullurl.Substring(46);
            //string parturl = fullurl.Substring(36);
            decryptsubstring = Decrypt(parturl);
            if (decryptsubstring.Contains("reisere="))
            {
                if (IndexValue == 0)
                {
                    LiteralControl tablecode0 = new LiteralControl("<table><tr><td>Tast inn epostadressen du brukte ved bestilling</td></tr>");
                    LiteralControl tablecode1 = new LiteralControl("<tr><td>");
                    checkepostTxt = new TextBox();
                    LiteralControl tablecode2 = new LiteralControl("</td></tr>");
                    Button checkepostBtn = new Button();
                    checkepostBtn.Text = "Sjekk";
                    checkepostBtn.Click += new EventHandler(checkepostBtn_Click);
                    LiteralControl tablecode3 = new LiteralControl("</td></tr></table>");
                    epostcheckPan.Controls.Add(tablecode0);
                    epostcheckPan.Controls.Add(tablecode1);
                    epostcheckPan.Controls.Add(checkepostTxt);
                    epostcheckPan.Controls.Add(tablecode2);
                    epostcheckPan.Controls.Add(tablecode1);
                    epostcheckPan.Controls.Add(checkepostBtn);
                    epostcheckPan.Controls.Add(tablecode2);
                    epostcheckPan.Controls.Add(tablecode3);
                }
                //get order number from querystring
                ordernumber = int.Parse(decryptsubstring.Substring(decryptsubstring.Length - 5));
                try
                {
                    //get customer tables
                    getallcustomerscobling();
                }
                catch
                {
                }
                if (IndexValue != 0 && thetable != null && thetable.Rows.Count == 0)
                {
                    headpan.Visible = true;
                    registrerPan.Visible = true;
                    registrerPan.Enabled = true;
                    updateBtn.Visible = true;
                    updateBtn.Enabled = true;
                    nb.Visible = true;
                }
                if (IndexValue != 0 && thetable != null && thetable.Rows.Count > 0)
                {
                    try
                    {
                        //get new customers, check again
                        //getnewregistreringcobling();
                        getpendingcobling();
                    }
                    catch { }
                    if (thetable.Rows.Count > 0)
                    {
                        Repeater1.DataSource = thetable;
                        Repeater1.DataBind();
                        for (int i = 0; i < thetable.Rows.Count; i++)
                        {
                            ((DropDownList)(Repeater1.Items[i].Controls[7])).SelectedValue = thetable.Rows[i]["Gender"].ToString();
                        }
                        headpan.Visible = true;
                        registrerPan.Visible = true;
                        registrerPan.Enabled = true;
                        updateBtn.Visible = true;
                        updateBtn.Enabled = true;
                        nb.Visible = true;
                    }
                }
            }
        }
    }

    protected void checkepostBtn_Click(object sender, EventArgs e)
    {
        try
        {
            //get epost adresse for the order
            getorderepostcobling();
        }
        catch { }
        if (thetable != null && thetable.Rows.Count > 0 && checkepostTxt.Text == thetable.Rows[0]["Epost"].ToString())
        {
            IndexValue = 1;
        }
        else
        {
            IndexValue = 0;
            dontmatch.Text = "Epostadressen stemmer ikke.";
        }
    }

    protected void leggtil_Click(object sender, EventArgs e)
    {
        if (customerregistration1.Name == "" || customerregistration1.Sunname == "" || customerregistration1.Fødelsdato == "" || customerregistration1.Gender == "" || customerregistration1.Address == "")
        {
            feil.Text = "Alle felt må utfyles";
            IndexValue = 2;
        }
        else
        {
            try
            {
                //add new customer
                customers = new customercollection();
                lock (customers)
                {
                    createidcobling();
                    savenewcobling();
                    IndexValue = 3;
                }

                //clean register
                customerregistration1.Name = "";
                customerregistration1.Sunname = "";
                customerregistration1.Fødelsdato = "";
                customerregistration1.Gender = "";
                customerregistration1.Address = "";
                getnewregistreringcobling();
                Repeater1.DataSource = thetable;
                Repeater1.DataBind();
                for (int i = 0; i < thetable.Rows.Count; i++)
                {
                    ((DropDownList)(Repeater1.Items[i].Controls[7])).SelectedValue = thetable.Rows[i]["Gender"].ToString();
                }
                getpendingcobling();
                if (thetable != null && thetable.Rows.Count == 0)
                {
                    updateBtn.Visible = true;
                    updateBtn.Enabled = true;
                    nb.Visible = true;
                }
            }
            catch
            {

            }
        }
    }

    protected void updateBtn_Click(object sender, EventArgs e)
    {
        nb.Visible = true;
        try
        {

            if (!(customerregistration1.Name == "" || customerregistration1.Sunname == "" || customerregistration1.Fødelsdato == "" || customerregistration1.Gender == "" || customerregistration1.Address == ""))
            {
                customers = new customercollection();
                lock (customers)
                {
                    createidcobling();
                    savenewcobling();
                    IndexValue = 3;
                }
                //update the last customer
                updateid = id;
                updatethelastcustomercobling();
                //update customers data
                //getnewregistreringcobling();
                getallcustomerscobling();
                if (thetable != null)
                {
                    for (item = 0; item <= thetable.Rows.Count - 1; item++)
                    {
                        updateid = int.Parse(thetable.Rows[item]["Id"].ToString());
                        updatecustomercobling();
                    }
                    updateordertillegginfocobling();
                    feilmessage = "success";
                }
                Repeater1.DataSource = thetable;
                Repeater1.DataBind();
                getpendingcobling();
                if (thetable != null && thetable.Rows.Count == 0)
                {
                    updateBtn.Visible = true;
                    updateBtn.Enabled = true;
                }
            }
            else if (customerregistration1.Name == "" && customerregistration1.Sunname == "" && customerregistration1.Fødelsdato == "" && customerregistration1.Gender == "" && customerregistration1.Address == "")
            {
                //update customers data
                //getnewregistreringcobling();
                getallcustomerscobling();
                for (item = 0; item < thetable.Rows.Count; item++)
                {
                    updateid = int.Parse(thetable.Rows[item]["Id"].ToString());
                    updatecustomercobling();
                }
                //update orders tillegginformasjon
                updateordertillegginfocobling();
                feilmessage = "success"; 
                //show already registrated informasjon
                getnewregistreringcobling();
                Repeater1.DataSource = thetable;
                Repeater1.DataBind();
            }
            else
            {
                feilmessage = "felttom"; 
                feil.Text = "Alle felt må utfyles";
                IndexValue = 2;
            }
            //get all pending
            //getpendingcobling();
            //get all customer by ordernumber
            getallcustomerscobling();
           sendreceipt();
           sendnotice();
        }
        catch
        {
        }
        finally
        {
            if (feilmessage == "success")
            {
                Response.Redirect("Hjelp.aspx?receipt={0}");
            }
            if (feilmessage == "felttom")
            { 
            
            }
            if (feilmessage == "" || feilmessage == null)
            {
                feil.Text = "En feil oppstår. Vennligst prøv litt senere";
            }
        }
    }

    protected void sendunfinishedregistrering()
    {
        string mailcont = "Hei, " + " <br/><br/>" + "Dette er et advarsel på at du ikke har vært ferdig med dataregistrering. Vennligst registrere alle reiseinformasjon i forhold til din bestilling så fort som mulig. Din lenk til å registere " + fullurl  + 
        "<br/><br/> Med vennlig hilsen <br/> http://www.kinaturer.com";
        mailcont = mailcont.Replace(Environment.NewLine, "<br/>");
        //get epost adresse for the order
        getorderepostcobling();
        //oppretterer en mail obsjekt
        MailMessage message = new MailMessage(
       "order@kinaturer.com",
       thetable.Rows[0]["Epost"].ToString(),
       "Uferdig registrering", mailcont);
        message.IsBodyHtml = true;
        //SmtpClient client = new SmtpClient("filter.fastname.no", 25);
        //client.Credentials = new System.Net.NetworkCredential("order@kinaturer.com", "orderpassword12");
        SmtpClient client = new SmtpClient("smtp.bluecom.no");
        client.UseDefaultCredentials = false;
        client.Send(message);
    }

    protected void sendunfinishednotice()
    {
        string mailcont = fullurl + " ikke registrert ferdig.";
        mailcont = mailcont.Replace(Environment.NewLine, "<br/>");
        //get epost adresse for the order
        getorderepostcobling();
        //oppretterer en mail obsjekt
        MailMessage message = new MailMessage(
       "order@kinaturer.com",
       "yahoo342000@yahoo.com",
       "Uferdig registrering", mailcont);
        message.IsBodyHtml = true;
        SmtpClient client = new SmtpClient("filter.fastname.no", 25);
        //client.Credentials = new System.Net.NetworkCredential("order@kinaturer.com", "orderpassword12");
        //SmtpClient client = new SmtpClient("smtp.bluecom.no");
        client.UseDefaultCredentials = false;
        client.Send(message);
    }

    protected void sendreceipt()
    {
        string customerdata = "";
        int format = 0;
        foreach (DataRow dr in thetable.Rows)
        {
            if (format == 0)
            {
                customerdata = "<tr style='border-up: solid 1px #e1e1e1; border-bottow: solid 1px #e1e1e1'><td style='width:140px'>" + dr["Name"].ToString() + "</td><td style='width:140px'>" + dr["Sunname"].ToString() + "</td><td style='width:140px'>" + dr["Fødelsdato"].ToString() + "</td><td style='width:70px'>" + dr["Gender"].ToString() + "</td><td style='width:140px'>" + dr["Address"].ToString() + "</td></tr>";
            }
            else
            {
                customerdata = customerdata + "<tr style='border-up: solid 1px #e1e1e1; border-bottow: solid 1px #e1e1e1'><td style='width:140px'>" + dr["Name"].ToString() + "</td><td style='width:140px'>" + dr["Sunname"].ToString() + "</td><td style='width:140px'>" + dr["Fødelsdato"].ToString() + "</td><td style='width:70px'>" + dr["Gender"].ToString() + "</td><td style='width:140px'>" + dr["Address"].ToString() + "</td></tr>";
            }
            format++;
        }
        string headstring = "<table style='border: solid 1px #e1e1e1;'><tr style='background-color: #f0f8ff'><td style='width:100px'>Fornaven</td><td style='width:100px'>Etternaven</td><td style='width:100px'>Fødelsdato</td></td><td style='width:100px'>Kjønn</td><td style='width:70px'>Adresse</td></tr>";
        string ordertillinfor = tillegginformasjon.Value;
        ordertillinfor = ordertillinfor.Replace(Environment.NewLine, "<br/>");
        string mailcont = "Hei, " + " <br/><br/>" + "Vi bekrefter du har sendt inn følgde reiseinformasjon. <br/><br/>" +
            headstring + customerdata + "</table>" + "<br/><br/> <p style='width:500px'> Tilleggsinformasjon: " + ordertillinfor + 
        "</p><br/><br/> Med vennlig hilsen <br/> http://www.kinaturer.com";
        mailcont = mailcont.Replace(Environment.NewLine, "<br/>");
        //get epost adresse for the order
        getorderepostcobling();
        //oppretterer en mail obsjekt
        MailMessage message = new MailMessage(
       "order@kinaturer.com",
       thetable.Rows[0]["Epost"].ToString(),
       "Reiseinformasjon på din bestilling", mailcont);
        message.IsBodyHtml = true;
        SmtpClient client = new SmtpClient("filter.fastname.no", 25);
        //client.Credentials = new System.Net.NetworkCredential("order@kinaturer.com", "orderpassword12");
        //SmtpClient client = new SmtpClient("smtp.bluecom.no");
        client.UseDefaultCredentials = false;
        client.Send(message);
    }

    protected void sendnotice()
    {
        string customerdata = "";
        int format = 0;
        foreach (DataRow dr in thetable.Rows)
        {
            if (format == 0)
            {
                customerdata = "<tr><td style='width:140px'>" + dr["Name"].ToString() + "</td><td style='width:140px'>" + dr["Sunname"].ToString() + "</td><td style='width:140px'>" + dr["Fødelsdato"].ToString() + "</td><td style='width:70px'>" + dr["Gender"].ToString() + "</td><td style='width:140px'>" + dr["Address"].ToString() + "</td></tr>";
            }
            else
            {
                customerdata = customerdata + "<tr><td style='width:140px'>" + dr["Name"].ToString() + "</td><td style='width:140px'>" + dr["Sunname"].ToString() + "</td><td style='width:140px'>" + dr["Fødelsdato"].ToString() + "</td><td style='width:70px'>" + dr["Gender"].ToString() + "</td><td style='width:140px'>" + dr["Address"].ToString() + "</td></tr>";
            }
            format++;
        }
        string headstring = "<table><tr><td style='width:100px'>Fornaven</td><td style='width:100px'>Etternaven</td><td style='width:100px'>Fødelsdato</td></td><td style='width:100px'>Kjønn</td><td style='width:70px'>Adresse</td></tr>";
        string mailcont = "Hei, " + " <br/><br/>" + "Vi bekrefter du har sendt inn følgde reiseinformasjon. <br/><br/>" +
            headstring + customerdata + "</table>" + 
        "<br/><br/> Med vennlig hilsen <br/> http://www.kinaturer.com";
        mailcont = mailcont.Replace(Environment.NewLine, "<br/>");
        //get epost adresse for the order
        getorderepostcobling();
        //oppretterer en mail obsjekt
        MailMessage message = new MailMessage(
       "order@kinaturer.com",
       "songhelene@hotmail.com",
       "Nye Reisende data", mailcont);
        message.IsBodyHtml = true;
        SmtpClient client = new SmtpClient("filter.fastname.no", 25);
        //client.Credentials = new System.Net.NetworkCredential("order@kinaturer.com", "orderpassword12");
        //SmtpClient client = new SmtpClient("smtp.bluecom.no");
        client.UseDefaultCredentials = false;
        client.Send(message);
    }
    /// <summary>
    /// check identity, registry and update group members
    /// </summary>
    /// <param name="obj"></param>
    protected void createid(object obj)
    {
        id = ((customercollection)obj).CreateCustomerId();
    }

    protected void createidcobling()
    {
        ThreadPool.QueueUserWorkItem(new WaitCallback(createid), customers);
        Thread.Sleep(150);
    }

    protected void savenewcobling()
    {
        customers1 = new customercollection(1);
        if (id > 0)
        {
            thecustomer = new customer(id, ordernumber, customerregistration1.Name, customerregistration1.Sunname, customerregistration1.Fødelsdato, "", customerregistration1.Gender, customerregistration1.Address, "", "pending");
            customers1.Add(thecustomer);
            ThreadPool.QueueUserWorkItem(new WaitCallback(save), customers1);
        }
    }

  
    protected void save(object obj)
    {
        customers1 = new customercollection(1);
        lock (customers1)
        {
            ((customercollection)obj).Save();
        }
    }
    protected void updatecustomercobling()
    {
        lock (customers)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(updatecustomer), customers);
            Thread.Sleep(150);
        }
    }

    protected void updatecustomer(object obj)
    {
        ((customercollection)obj).Updatenewcustomer(updateid, ((TextBox)(Repeater1.Items[item].Controls[1])).Text, ((TextBox)(Repeater1.Items[item].Controls[3])).Text,((TextBox)(Repeater1.Items[item].Controls[5])).Text, ((DropDownList)(Repeater1.Items[item].Controls[7])).SelectedValue, ((TextBox)(Repeater1.Items[item].Controls[9])).Text);
    }

    protected void updatethelastcustomer(object obj)
    {
        ((customercollection)obj).Updatenewcustomer(updateid, customerregistration1.Name, customerregistration1.Sunname, customerregistration1.Fødelsdato, customerregistration1.Gender, customerregistration1.Address);
    }

    protected void updatethelastcustomercobling()
    {
        lock (customers)
        {

            ThreadPool.QueueUserWorkItem(new WaitCallback(updatethelastcustomer), customers);
            Thread.Sleep(150);
        }
    }

    protected void updateordertillegginfo(object obj)
    {
        ((ordercollection)obj).UpdateTillInforOrderByOrdernumber(tillegginformasjon.Value, ordernumber);
    }

    protected void updateordertillegginfocobling()
    {
        orders = new ordercollection();
        lock (orders)
        {

            ThreadPool.QueueUserWorkItem(new WaitCallback(updateordertillegginfo), orders);
            Thread.Sleep(150);
        }
    }

    protected void getorderepost(object obj)
    {
        thetable = ((ordercollection)obj).GetOrderByOrdernumber(ordernumber);
    }

    protected void getorderepostcobling()
    {
        orders = new ordercollection();
        lock (orders)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(getorderepost), orders);
            Thread.Sleep(150);
            if (thetable == null)
            {
                getorderepostcobling();
            }
        }
    }

    protected void getpending(object obj)
    {
        thetable = ((customercollection)obj).GetPendingCustomersByOrdernumber(ordernumber);
    }

    protected void getpendingcobling()
    {
        lock (customers)
        {

            ThreadPool.QueueUserWorkItem(new WaitCallback(getpending), customers);
            Thread.Sleep(150);
            if (thetable == null)
            {
                getpendingcobling();
            }
        }
    }

    protected void getnewcustomers(object obj)
    {
        thetable = ((customercollection)obj).GetNewCustomersByOrdernumber(ordernumber);
    }

    protected void getnewregistreringcobling()
    {
        customers = new customercollection();
        lock (customers)
        {

            ThreadPool.QueueUserWorkItem(new WaitCallback(getnewcustomers), customers);
            Thread.Sleep(150);
            if (thetable == null)
            {
                getnewregistreringcobling();
            }
        }
    }

    protected void getallcustomers(object obj)
    {
        thetable = ((customercollection)obj).GetAllCustomersByOrdernumber(ordernumber);
    }

    protected void getallcustomerscobling()
    {
        customers = new customercollection();
        lock (customers)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(getallcustomers), customers);
            Thread.Sleep(150);
            if (thetable == null)
            {
                getallcustomerscobling();
            }
        }
    }
  

    public static string Decrypt(string TextToBeDecrypted)    
    {        
        RijndaelManaged RijndaelCipher = new RijndaelManaged();        
        string Password = "CSC";        
        string DecryptedData;        
        try        
        {            
            byte[] EncryptedData = Convert.FromBase64String(TextToBeDecrypted);            
            byte[] Salt = Encoding.ASCII.GetBytes(Password.Length.ToString());            
            //Making of the key for decryption            
            PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(Password, Salt);            
            //Creates a symmetric Rijndael decryptor object(chahal).            
            ICryptoTransform Decryptor = RijndaelCipher.CreateDecryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));            
            MemoryStream memoryStream = new MemoryStream(EncryptedData);            
            //Defines the cryptographics stream for decryption.THe stream contains decrpted data            
            CryptoStream cryptoStream = new CryptoStream(memoryStream, Decryptor, CryptoStreamMode.Read);            
            byte[] PlainText = new byte[EncryptedData.Length];            
            int DecryptedCount = cryptoStream.Read(PlainText, 0, PlainText.Length);            
            memoryStream.Close();            
            cryptoStream.Close();            
            //Converting to string            
            DecryptedData = Encoding.Unicode.GetString(PlainText, 0, DecryptedCount);        
        }        
        catch        
        {             
            DecryptedData = TextToBeDecrypted;        
        }        
        return DecryptedData;    
    }
}
