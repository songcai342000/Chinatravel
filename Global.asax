<%@ Application Language="C#" %>
<%@ Import Namespace = "System.Diagnostics" %>
<%@ Import Namespace = "System.Net.Mail" %>

<script runat="server">

    int i;
    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup
        //i = application state;
    }

   
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs
       /* string mailcont = "\n\nURL:\n " + Request.QueryString.ToString()
       + "\n\nMESSAGE:\n " + Server.GetLastError().Message
       + "\n\nSTACK TRACE:\n" + Server.GetLastError().StackTrace;
        //oppretterer en mail obsjekt
        MailMessage message = new MailMessage(
       "teknikk@kinaturer.com",
       "teknikk@kinaturer.com",
       "Feil report", mailcont);
        SmtpClient client = new SmtpClient("filter.fastname.no", 25);
        message.IsBodyHtml = true;

        //SmtpClient client = new SmtpClient("smtp.bluecom.no");
        client.UseDefaultCredentials = false;*/

       // client.Send(message);
    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
       
</script>
