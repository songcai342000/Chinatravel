<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Packages.aspx.cs" Inherits="Packages" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Reference Control="~/usercontrol/frontside/packages.ascx" %>
<%@ Reference Control="~/usercontrol/frontside/router1description.ascx" %>
<%@ Reference Control="~/usercontrol/frontside/router2description.ascx" %>
<%@ Reference Control="~/usercontrol/frontside/agreement.ascx" %>
<%@ Reference Control="~/usercontrol/frontside/packages.ascx" %>
<%@ Reference Control="~/usercontrol/frontside/hvorfoross.ascx" %>
<%@ Reference Control="~/usercontrol/frontside/kinaelementer1.ascx" %>
<%@ Reference Control="~/usercontrol/frontside/kinaelementer2.ascx" %>
<%@ Reference Control="~/usercontrol/frontside/kinaelementer3.ascx" %>
<%@ Reference Control="~/usercontrol/frontside/router3description.ascx" %>
<%@ Reference Control="~/usercontrol/frontside/router3Bdescription.ascx" %>
<%@ Reference Control="~/usercontrol/frontside/router4description.ascx" %>
<%@ Reference Control="~/usercontrol/frontside/router5description.ascx" %>
<%@ Reference Control="~/usercontrol/frontside/router6description.ascx" %>


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
     <title>Kina Reise - våre pakkereiser - reis billig til Kina</title>
		<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
        <meta name="expires" content="never" />
        <meta name="language" content="nor" />
        <meta name="charset" content="UTF-8" />
         <meta http-equiv="content-language" content="no" />
        <meta name="distribution" content="Global" />
        <meta name="email" content="kontakt@kinaturer.com" />
        <meta name="copyright" content="kinaturer.com" />
        <meta name="author" content="kinaturer.com" />
     <style type="text/css">
         .style3
         {
             width: 626px;
         }
         </style>
</head>
<body bgcolor="#e1e1e1">
    <form id="form1" runat="server">
     <table align="center" style="background:white;-moz-opacity:70%;border: solid 1px #00b000;-moz-box-shadow: 10px 10px 5px #949494;
 -webkit-box-shadow: 10px 10px 5px #949494; box-shadow: 10px 10px 5px #949494; background-image: url('images/feiji-red-jus-3.jpg'); background-repeat:no-repeat;"><tr><td>
    <table border="0" style=" width:   950px; height:140px;" 
    align="center" >
    <tr style="width: 100%;" align="center">
        <td style="vertical-align:middle; font-size: xx-large; color: #00b000; 
            font-family: 'Trebuchet MS'; font-weight: lighter; font-style: italic; 
            font-variant: normal; "  
            align="center" >
            Kina Tur<table cellpadding="3" border="0"><tr align="center"><td style="font-size:large; font-family: 'Trebuchet MS'; color:#00b000; border-left-color:#00b000;">
               Være med oss på en eventyrreise</td></tr>
            </table></td></tr>
    </table>
  
    <table id="menutable" style="border: solid 1px #00b000;width:950px;font-weight:bold;" align="center">
    <tr>
        <td align="left">
        <asp:LinkButton id="start" runat="server" PostbackUrl="Default.aspx" BackColor=
                Text="Kina" ForeColor="#00b000" onclick="start_Click"></asp:LinkButton>&nbsp; | &nbsp;
        <asp:LinkButton id="Beijing" runat="server" 
                Text="Beijing" 
                ForeColor="#00b000"
                onclick="Beijing_Click"></asp:LinkButton>&nbsp; | &nbsp;
        <asp:LinkButton id="Xian" runat="server"  
                Text="Xian" onclick="Xian_Click" ForeColor="#00b000"></asp:LinkButton>&nbsp; | &nbsp;
        <asp:LinkButton id="Guizhou" runat="server" 
                Text="Guizhou" 
                ForeColor="#00b000" 
                onclick="Guizhou_Click"></asp:LinkButton>&nbsp; | &nbsp;   
        <asp:LinkButton id="Guilin" runat="server" 
                Text="Guilin" 
                ForeColor="#00b000" 
                onclick="Guilin_Click"></asp:LinkButton>&nbsp; | &nbsp;     
        <asp:LinkButton id="Shanghai" runat="server" 
                Text="Shanghai" 
                ForeColor="#00b000"
                onclick="Shanghai_Click" ></asp:LinkButton>&nbsp; | 
            &nbsp;
             <asp:LinkButton id="LinkButton3" runat="server" 
                Text="Tibet" 
                ForeColor="#00b000"
                onclick="Tibet_Click"></asp:LinkButton>&nbsp; | 
            &nbsp;
        <asp:LinkButton id="Packageshandle" runat="server" Text="Kina reiser" ForeColor="#00b000" Baconclick="Packageshandle_Click" ToolTip="Klikk knappen 'Blogg' og les 'En spennende påsketur'"></asp:LinkButton>
            &nbsp; | &nbsp;
                    <asp:LinkButton id="flyhotel" runat="server" Text="Visum" ForeColor="#00b000" onclick="Hotel_Click" 
                ></asp:LinkButton>&nbsp; | &nbsp;                
                      <asp:LinkButton id="blogg" runat="server" Text="Blogg" ForeColor="#00b000" onclick="blogg_Click" ToolTip="Klikk knappen 'Blogg' og les 'En spennende påsketur'"
                ></asp:LinkButton>&nbsp; | &nbsp;       
        </td>
    </tr>
</table>
        <table style="font-size:x-small;width:950px;font-family:Arial" 
            cellpadding="0px" cellspacing="0px" ><tr style="width:100%">
           <td style="width:70%; ">
           <table cellpadding="0px" cellspacing="0px">
           <tr>
           
             <td style="padding-top: 20px;padding-bottom: 20px; padding-left:40px;border-right:solid 1px #00b000; " class="style3"  
                   > 
                   <table style="width:585px; background-color:#ccd9ff; "><tr><td>
                       <a id="12dager" style="color:black;font-weight:bold;font-size: 11px;text-decoration:none;" 
                     href="Packages.aspx?description={1c}">Rundreise i den mangfoldige Kina (12 dager). 
                       </a><br/>
                     <br />
                     
                 <a id="goldencities" style="color:black;text-decoration:none;font-size: 11px;font-weight:bold" 
                     href="http://kina-reise.blogspot.no/2015/03/reiser-til-kinas-gyldne-tre-kanter.html" >Kinas gyldne tre-kanter (11 dager). Pris fra: 
                       1292 USD, enkeltromstillegg fra: 322 USD, ukentlig avreise, internasjonal gruppereise.</a> <b style="color:black;text-decoration:none;font-size: 11px;">Kontakt med oss på kontakt@kinaturer.com eller </b><a id="gyldnekanter" href="Orderquery.aspx?reise3t={0}">Bestill reisen</a><br/>   <br/>
                    <a id="hongkong" style="color:black;text-decoration:none;font-size: 11px;font-weight:bold" 
                     href="Packages.aspx?description={7}">Reise til Kinas store byer og tre kløfter (14 dager) Ukentlig avreise 1.april - 4.november
                      . 
                       </a><br/>
                    <br/>
                    <a id="denstore" style="color:black;text-decoration:none;font-size: 11px;font-weight:bold" 
                     href="Packages.aspx?description={8}">Den store kinareisen (18 dager). </a><br/>
                    <br/>
                    <a id="fototibet" style="color:black;text-decoration:none;font-size: 11px;font-weight:bold" 
                     href="Packages.aspx?description={4b}">Foto-tur til Beijing, Tibet og Shanghai (18 dager).  
                 </a><br/>
                    <br/>
                    <a id="A1" style="color:black;text-decoration:none;font-size: 11px;font-weight:bold" 
                     href="Packages.aspx?description={1}">Hello Kina (8 dager). Pris fra: USD 813 avreise hver dag</a><br/>
                    <br/>
                   <a style="color:red; font-size:11px" href="http://kina-reise.blogspot.no/2015/03/disse-kinareiser-er-dessvrre-ikke-for.html"><b>Vi har flere internasjonale gruppereiser</b></a><br/><br/>
                    <a id="skreddersydde" style="color:black;text-decoration:none;font-size: 11px;font-weight:bold" 
                     href="Hjelp.aspx?skreddersydde={4}">Skreddersydde reiser til Kina</a><br/><br/>
                                         <b style="color: Red; font-size: 11px;">Vi har mange muligheter. </b><br/><br/>
                     <b>Vi tar forbehold om endringer i pris og reiserute som ligger utenfor vår kontroll. </b>
                     </td></tr></table><br/>
                     <table style="background-color:#ccd9ff;">
                     <tr>
                     <td style="font-weight:bold;font-size:11px; color:black;">Ikke gå glipp av våre spennende pakkereiser<br/></td>
                     </tr>
                     </table><br/>
                 <asp:Panel ID="content" runat="server"></asp:Panel>
             
            </td>
            <td style="width:30%;padding-top:20px;padding-bottom:20px;padding-left:10px;padding-right:10px;" valign="top" id="rightcln" runat="server">    
                
            </td>
            </tr>
           </table>
           </td>
           </tr>
           
            <tr><td>
             <table style="width:950px;background-color:#00b000"  align="center">
        <tr align="center">
            <td>
                <a href="Packages.aspx?agreement={0}" style="color:White">Reisevilkår</a>  |
                <a href="Packages.aspx?questions={0}" style="color:White">Ofte stilte spørsmål</a>  | 
                <a href="Extrahjelp.aspx?aboutus=om-oss" style="color:White">Om oss</a>  |
                <a href="Extrahjelp.aspx?contact=kontaktinfo" style="color:White">Kontakt</a> |
            </td>
        </tr>
         <tr align="center">
            <td>
                 <p>© 2016 Uforglemmelig Kina Tur.</p>
            </td>
        </tr>
    </table>
    </td>
        </tr>
    </table>
    </td></tr></table>
    </form>
</body>
</html>
