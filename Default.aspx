<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="default.aspx.cs" Inherits="_Default" %>
<%@ Register src="~/usercontrol/frontside/mainmenu.ascx" tagname="mainmenu" tagprefix="uc1" %>
<%@ Register src="~/usercontrol/frontside/headlogonopicture.ascx" tagname="headlogono" tagprefix="uc2" %>
<%@ Register src="~/usercontrol/frontside/copyright.ascx" tagname="copyright" tagprefix="uc4" %>
<%@ Register src="~/usercontrol/frontside/advertisment.ascx" tagname="advertisment" tagprefix="uc5" %>

<%@ Register src="~/usercontrol/frontside/advertisment2.ascx" tagname="advertisment2" tagprefix="uc3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<link href="../../App_Themes/vennskaper/vennskaper.css" rel="stylesheet" type="text/css" />

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Kina Tur - Reisebyrå til Kina - Vi tilbyr gode og billige kinareiser</title>
		<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
        <meta name="expires" content="never" />
        <meta name="language" content="nor" />
        <meta name="charset" content="UTF-8" />
         <meta http-equiv="content-language" content="no" />
        <meta name="distribution" content="Global" />
        <meta name="email" content="kontakt@kinaturer.com" />
        <meta name="copyright" content="kinaturer.com" />
        <meta name="author" content="kinaturer.com" />
        <meta name="distribution" content="Global" />
      
        
     <style type="text/css">
         .style1
         {
             width: 50%;
         }
     </style>
</head>
<body bgcolor="#e1e1e1">
    <form id="form1" runat="server" >
  
    <table align="center" style="background: white;-moz-opacity:70%; border: solid 1px #00b000;-moz-box-shadow: 10px 10px 5px #949494;
 -webkit-box-shadow: 10px 10px 5px #949494; box-shadow: 10px 10px 5px #949494; background-image: url('images/feiji-red-jus-3.jpg'); background-repeat:no-repeat;"><tr><td>
    <table border="0" style="width:   950px; height:140px; "  
    align="center" >
    <tr style="width: 100%; " align="center">
        <td style="vertical-align:middle; font-size: xx-large; color: #00b000; 
            font-family: 'Trebuchet MS'; font-weight: lighter; font-style: italic; 
            font-variant: normal; "  
            align="center" >
            Kina Tur<table cellpadding="3" border="0"><tr align="center"><td style="font-size:large; font-family: 'Trebuchet MS'; color:#00b000; border-left-color:#00b000;">
                En uforglemmelig reise</td></tr>
            </table></td></tr>
           
    </table>
  
    <table id="menutable" style="width:950px;border: solid 1px #00b000;font-weight:bold" align="center">
    <tr>
        <td align="left" >
        <asp:LinkButton id="start" runat="server" 
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
                onclick="Shanghai_Click"></asp:LinkButton>&nbsp; | &nbsp;
            <asp:LinkButton id="Tibet" runat="server" 
                Text="Tibet" 
                ForeColor="#00b000"
                onclick="Tibet_Click"></asp:LinkButton>&nbsp; | &nbsp;
        <asp:LinkButton id="Packages" runat="server" Text="Kina reiser" ForeColor="#00b000" onclick="Packages_Click" ToolTip="Klikk knappen 'Blogg' og les 'En spennende påsketur'"
                ></asp:LinkButton>&nbsp; | &nbsp;
        <asp:LinkButton id="flyhotel" runat="server" Text="Visum" ForeColor="#00b000" onclick="Hotel_Click" 
                ></asp:LinkButton>&nbsp; | &nbsp;                
                      <asp:LinkButton id="blogg" runat="server" Text="Blogg" ForeColor="#00b000" onclick="blogg_Click" ToolTip="Klikk knappen 'Blogg' og les 'En spennende påsketur'"
                ></asp:LinkButton>&nbsp; | &nbsp;       
        </td>
    </tr>
</table>
<div id="kinaturer">
</div>
        <table style="font-size:x-small;width:950px;" align="center"><tr>
            <td style="width:70%;padding-top:20px;padding-bottom:20px;border-right:solid 1px #00b000" valign="top">
                <asp:Panel id="contentpan" runat="server" width="550px"/>
                <asp:Panel id="weatherpan" runat="server" width="550px"/>
            </td>
              <td style="width:30%;padding-top:20px;padding-bottom:20px;padding-left:10px;padding-right:10px;" valign="top" >   
                <table style="border:solid 1px #00b000;background-color:#d5ffd5;width:291px">
<tr><td class="style1">
    Folktall:
</td><td>
 <asp:Label ID="Literal2" runat="server"></asp:Label>
</td></tr>

<tr><td class="style1">
    befolkningstetthet:
</td><td>
 <asp:Label ID="Literal3" runat="server"></asp:Label>
</td></tr><tr><td class="style1">
                        Areal:
</td><td>
 <asp:Label ID="Literal4" runat="server"></asp:Label>
</td></tr>
<tr><td class="style1">
    Gjennømsnitthøyde:
</td><td>
 <asp:Label ID="Literal5" runat="server"></asp:Label>
</td></tr>
<tr><td class="style1">
    Gjennømsnitt årlig temperatur:
</td><td>
 <asp:Label ID="Literal7" runat="server"></asp:Label>
</td></tr>
<tr><td class="style1">
<asp:Label ID="Label3" runat="server"></asp:Label>
</td><td>
 <asp:Label ID="Label1" runat="server"></asp:Label>
</td></tr>
</table>
<table cellpadding="0px" cellspacing="0px"><tr><td>
<br/>
<asp:Panel runat="server" id="advertisment"/>
</td></tr>
</table>
<table>
<tr>
<td style="height: 185px" valign="bottom">
     <uc3:advertisment2 ID="advertisment1" runat="server" />
</td>
</tr>
</table>
<table style="width:100%;"><tr><td style="height:100px" valign="bottom" align="center">
<img id="logo" src="uforglemmeligkinatur-logo.jpg" />
</td></tr></table><br/>
   </td>
            </tr>
            </table>
             <table style="width:950px;background-color:#00b000;" align="center">
        <tr align="center">
            <td>
                <a href="Packages.aspx?agreement={0}" style="color:White">Reisevilkår</a>  |  
                <a href="Packages.aspx?questions={0}" style="color:White">Ofte stilte spørsmål</a>  
                | 
                <a href="Extrahjelp.aspx?aboutus=om-oss" style="color:White">
                Om oss</a>  |
                <a href="Extrahjelp.aspx?contact=kontaktinfo" style="color:White">
                Kontakt</a> |
                <a href="Extrahjelp.aspx?reiseleder=reiseleder" style="color:White">
                Ledig stilling</a>
            </td>
        </tr>
         <tr align="center">
            <td>
                 <p>© 2016 kinaturer.com All Rights Reserved.</p>
            </td>
        </tr>
    </table>
    </td></tr></table>
  
    </form>
	<script>document.getElementById("kinaturer").style.display="none"</script>
</body>
</html>
