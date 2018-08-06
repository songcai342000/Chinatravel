using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

public partial class Adminpage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["package"] != null)
        { 
            
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
    protected void Packageshandle_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Packages.aspx?package=package");

    }
    protected void Guilin_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx?package=guilin");

    }

     protected string Encrypt(string TextToBeEncrypted)    
     {        
         RijndaelManaged RijndaelCipher = new RijndaelManaged();        
         string Password = "CSC";        
         byte[] PlainText = System.Text.Encoding.Unicode.GetBytes(TextToBeEncrypted);        
         byte[] Salt = Encoding.ASCII.GetBytes(Password.Length.ToString());        
         PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(Password, Salt);        
         //Creates a symmetric encryptor object(chahal).         
         ICryptoTransform Encryptor = RijndaelCipher.CreateEncryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));        
         MemoryStream memoryStream = new MemoryStream();        
         //Defines a stream that links data streams to cryptographic transformations        
         CryptoStream cryptoStream = new CryptoStream(memoryStream, Encryptor, CryptoStreamMode.Write);        
         cryptoStream.Write(PlainText, 0, PlainText.Length);        
         //Writes the final state and clears the buffer        
         cryptoStream.FlushFinalBlock();        
         byte[] CipherBytes = memoryStream.ToArray();        
         memoryStream.Close();        
         cryptoStream.Close();        
         string EncryptedData = Convert.ToBase64String(CipherBytes);        
         return EncryptedData;    
     }
     protected void encryp_Click(object sender, EventArgs e)
     {
         encrypturlordernumber.Text = Encrypt(urlordernumber.Text);
     }

    //send newsletter
     protected void newsletter_Click(object sender, EventArgs e)
     {
         getepostlist();
     }

    //get registrert epost list for news letter
     protected void getepostlist()
     {
         string connectionString = "Data Source=desktop-v7h8pou\\sqlexpress2017;Initial Catalog=Chinatravel;Integrated Security=True";
         //string connectionString = "Data Source=mssql03.fastname.no;Database=db165057;Uid=db165057;Password=a547yryf";
         SqlConnection sqlconn = new SqlConnection(connectionString);
         string commandText = "select Epost from Newsletterinfo ";
         SqlCommand sqlcommd = sqlconn.CreateCommand();
         sqlcommd.CommandType = CommandType.Text;
         sqlcommd.CommandText = commandText;
         SqlDataAdapter sqlad = new SqlDataAdapter();
         sqlad.SelectCommand = sqlcommd;
         DataTable table = new DataTable();
         sqlad.Fill(table);
         //sendnewsletter("songhelene@hotmail.com");
         //sendkunde("songhelene@hotmail.com");
         /*foreach (DataRow dr in table.Rows)
         {
             sendnewsletter(dr["Epost"].ToString());
             //sendkunde(dr["Epost"].ToString());
         }*/
         //sendtilbud("1502832566@qq.com");
         //sendtilbud("songcai342000@yahoo.com");
         foreach (DataRow dr in table.Rows)
         {
             sendtilbud(dr["Epost"].ToString());
             //sendkunde(dr["Epost"].ToString());
         }
     }

    //send newsletter
     protected void sendnewsletter(string epostaddress)
     {
         string mailcont = " <table cellpadding='0px' cellspacing='0px'>" +
 "  <tr>" +
           " <td style='width:15%;padding-bottom:40px;padding-top:40px;' valign='top'></td>" +
           "  <td style='padding-right:40px;padding-top:40px;padding-bottom:40px;'" +
                "   class='style1'> Hei, <br/><br/>Sender våre oppdaterte reiseruter og priser. " +
                "</td>" +
                 " <td style='width:30%;padding-top:40px;padding-bottom:40px;padding-left:18px' valign='top'>" +
           " </td>" +
           "</tr>" +
         "  <tr>" +
           " <td style='width:15%;padding-bottom:40px;padding-top:40px;' valign='top'></td>" +
           "  <td style='padding-right:40px;padding-top:40px;padding-bottom:40px;border-right:solid 1px #00b000'" +
                "   class='style1'> " +
                " <a id='LinkButton1' style='color:#00b000;font-weight:bold'" +
                "     href='http://www.kinaturer.com/Packages.aspx?description={1}'>15 dagers eventyrreise. Pris: kr 22999</a><br/>" +
                "     Avreiser: 15-11-2012. Gruppestørrelse: 2 - 15.<br/><br/>" +
              "   <a id='LinkButton2' style='color:#00b000;font-weight:bold' " +
                "     href='http://www.kinaturer.com/Packages.aspx?description={2}'>Rundt i keisebyene (9 dager). Pris: " +
                " 16799  </a><br/>" +
                 "   Avreise: 11-01-2013. Gruppestørrelse: 2 - 15.<br/><br/>" +
                " <a id='goldencities' style='color:#00b000;font-weight:bold' " +
                "     href='http://www.kinaturer.com/Packages.aspx?description={3}'>Vår spesielle tilbud: Kinas gyldne byer " +
                " (9 dager). Pris: fra kr 15699  </a><br/>" +
                "    Avreise: 18-10-2012, 01-12-2012, 20-02-2013. Gruppestørrelse: 2 - 15." +
               "<br/><br/>" +
                "     <a id='cruise' style='color:#00b000;font-weight:bold' " +
               "      href='http://www.kinaturer.com/Packages.aspx?description={5}'>Deluxe cruise på Yangtze (14 dager). Pris: " +
               "  fra kr 20488" +
                "       </a><br/>" +
                "    Avreise: 20-09-2012, 04-10-2012, 01-11-2012. Gruppestørrelse: 2 - 15.<br/><br/>" +

               "      <a id='beijing' style='color:#00b000;font-weight:bold' " +
                "     href='http://www.kinaturer.com/Packages.aspx?description={6}'>Beijing ekspress (8 dager). Pris: kr " +
               "  10299                        </a><br/>" +
                  "  Avreise: 10-12-2012. Gruppestørrelse: 3 - 15.<br/><br/>" +
                   "      <a id='beijing' style='color:#00b000;font-weight:bold' " +
                "     href='http://www.kinaturer.com/Packages.aspx?description={7}'>Beijing, Shanghai, Guilin og Hongkong (10 dager) Pris: kr " +
               "  21850. </a><br/>" +
                  "  Avreise: 26-12-2012, 28-01-2013. Gruppestørrelse: 2 - 15.  <br/><br/>" +
                  "  <a id='skreddersydde' style='color:#00b000;font-weight:bold' " +
                "     href='http://www.kinaturer.com/Hjelp.aspx?skreddersydde={4}'>Skreddersydde reiser til Kina</a><br/><br/>" +
              "   <asp:Panel ID='content' runat='server'></asp:Panel>" +

           " </td>" +
           " <td style='width:30%;padding-top:40px;padding-bottom:40px;padding-left:18px' valign='top' id='rightcln' runat='server'>" +

           " </td>" +
            "</tr>" +
            "  <tr>" +
           " <td style='width:15%;padding-bottom:40px;padding-top:40px;' valign='top'></td>" +
           "  <td style='padding-right:40px;padding-top:40px;padding-bottom:40px;'" +
                "   class='style1'>  " +
                 "<img id='im' src='http://www.kinaturer.com/images/programfot-1.jpg'>" +
                "</td>" +
                 " <td style='width:30%;padding-top:40px;padding-bottom:40px;padding-left:18px' valign='top'>" +
           " </td>" +
           "</tr>" +
           "  <tr>" +
           " <td style='width:15%;padding-bottom:40px;padding-top:40px;' valign='top'></td>" +
           "  <td style='padding-right:40px;padding-top:40px;padding-bottom:40px;'" +
                "   class='style1'>" +
                 "Med vennlig hilsen <br/> <a id='kinaturer' href='http://www.kinaturer.com' style='color:#00b000'> UforglemmeligKinaTur</a>" +
                "</td>" +
                 " <td style='width:30%;padding-top:40px;padding-bottom:40px;padding-left:18px' valign='top'>" +
           " </td>" +
           "</tr>" +
          " </table><br/><br/>";
         mailcont = mailcont.Replace(Environment.NewLine, "<br/>");
         //oppretterer en mail obsjekt
         MailMessage message = new MailMessage(
        "newsletter@kinaturer.com",
        epostaddress,
        "Våre oppdaterte reiseruter og priser", mailcont);
         //SmtpClient client = new SmtpClient("mail.heymyfriends.com", 25);
         message.IsBodyHtml = true;
         //SmtpClient client = new SmtpClient("filter.fastname.no", 25);
         //client.Credentials = new System.Net.NetworkCredential("order@kinaturer.com", "orderpassword12");
         SmtpClient client = new SmtpClient("smtp.bluecom.no");
         client.UseDefaultCredentials = false;
         client.Send(message);
     }

     //send newsletter
     protected void sendtilbud(string epostaddress)
     {
         string mailcont = " <table cellpadding='0px' cellspacing='0px' style='width:600px'>" +
             "  <tr>" +
           "  <td style='padding-right:100px;padding-left:100px;padding-top:40px;padding-bottom:40px;border-right:solid 1px #00b000'" +
                "   class='style1'> <b style='color:#00b000;font-size:20px'>Reiser i påsken 2013 til fantasiske priser!</b> " +
                "</td>" +
           "</tr>" +
 "  <tr>" +
           "  <td style='padding-right:100px;padding-left:100px;padding-top:10px;padding-bottom:10px;border-right:solid 1px #00b000'" +
                "   class='style1'> " +
                "<a id='program' style='color:#00b000; font-weight:bold' href='http://www.kinaturer.com/Packages.aspx?description={3}'>Kinas gylne byer (9 dager)</a>. kr 15990,-" +
           " </td>" +
           "</tr>" +
           "  <tr>" +
           "  <td style='padding-right:100px;padding-left:100px;padding-top:10px;padding-bottom:10px;border-right:solid 1px #00b000'" +
                "   class='style1'> " +
                "<a id='program' style='color:#00b000; font-weight:bold' href='http://www.kinaturer.com/Pakkereiser/cruise-på-yangtze-B.htm'>Deluxe cruise på Yangtze (11 dager)</a>. kr 17990,-" +
           " </td>" +
           "</tr>" +
          "  <tr>" +
           "  <td style='padding-right:100px;padding-left:100px;padding-top:20px;padding-bottom:20px;border-right:solid 1px #00b000'" +
                "   class='style1'>  " +
                 "<img id='im' src='http://www.kinaturer.com/images/beijing-fot-newsletter-little.jpg'>" +
                "</td>" +
           "</tr>" +
           "  <tr>" +
           "  <td style='padding-right:100px;padding-left:100px;padding-top:20px;padding-bottom:40px;border-right:solid 1px #00b000'" +
                "   class='style1'>" +
                 "Med vennlig hilsen <br/> <a id='kinaturer' href='http://www.kinaturer.com' style='color:#00b000'> UforglemmeligKinaTur</a>" +
                "</td>" +
           "</tr>" +
          " </table><br/><br/>";
         mailcont = mailcont.Replace(Environment.NewLine, "<br/>");
         //oppretterer en mail obsjekt
         MailMessage message = new MailMessage(
        "newsletter@kinaturer.com",
        epostaddress,
        "Reiser i påsken 2013 til fantasiske priser", mailcont);
         //SmtpClient client = new SmtpClient("mail.heymyfriends.com", 25);
         message.IsBodyHtml = true;
         //SmtpClient client = new SmtpClient("filter.fastname.no", 25);
         //client.Credentials = new System.Net.NetworkCredential("order@kinaturer.com", "orderpassword12");
         SmtpClient client = new SmtpClient("smtp.bluecom.no");
         client.UseDefaultCredentials = false;
         client.Send(message);
     }
}
