<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Order.aspx.cs" Inherits="Order" EnableViewState="false" %>
<%@ Register src="~/usercontrol/frontside/customerregistration.ascx" tagname="customerregistration" tagprefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
		<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
        <meta name="description" content="Uforglemmelige turer til Kina. Fra store byer til landsbyer, fra det supermoderne til det tradisjonelle. Være med oss på en spennende ferie reise til Kina" />
        <meta name="keyword" content="kina tur, tur til kina" />        
        <meta name="expires" content="never" />
        <meta name="language" content="nor" />
        <meta name="charset" content="UTF-8" />
         <meta http-equiv="content-language" content="no" />
        <meta name="distribution" content="Global" />
        <meta name="email" content="kontakt@kinaturer.com" />
        <meta name="copyright" content="kinaturer.com" />
        <meta name="author" content="kinaturer.com" />
        
        </head>
<body bgcolor="#e1e1e1">
    <form id="form1" runat="server">
    <table align="center" style="background:white;-moz-opacity:70%;border: solid 1px #00b000;-moz-box-shadow: 10px 10px 5px #949494;
 -webkit-box-shadow: 10px 10px 5px #949494; box-shadow: 10px 10px 5px #949494; background-image: url('images/feiji-red-jus-3.jpg'); background-repeat:no-repeat;"><tr><td>
    <table border="0" style="width:   950px; height:140px; " 
    align="center" >
    <tr style="width: 100%;" align="center">
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
                onclick="Shanghai_Click" ToolTip="Les våre nyheter her"></asp:LinkButton>&nbsp; | &nbsp;
        <asp:LinkButton id="Packages" runat="server" Text="Kina reiser" ForeColor="#00b000" onclick="Packages_Click"
                ></asp:LinkButton>&nbsp; | &nbsp;
                          <asp:LinkButton id="blogg" runat="server" Text="Blogg" ForeColor="#00b000" onclick="blogg_Click"
                ></asp:LinkButton>&nbsp; | &nbsp;       
        </td>
    </tr>
</table>
<div id="Order">

</div>
        <table style="font-size:x-small;width:950px;" align="center">
        <tr><td>
        <br/>
        <asp:Panel id="epostcheckPan" runat="server" >
           
           </asp:Panel>
   <br/>
                <asp:Literal id="dontmatch" runat="server"></asp:Literal>          
          
                </td></tr>
            <tr>
            <td>    
                <asp:Panel id="headpan" runat="server" Visible="false">
                <table style="padding-left:140px"><tr style="width:100%"><td style="width:140px;">Fornavn</td><td style="width:140px; padding-left:6px">Etternavn</td>
                    <td style="width:140px; padding-left:6px">Fødelsdato (dd.mm.åååå)</td><td style="width:70px; padding-left:6px">Kjønn</td>
                    <td style="width:140px; padding-left:6px">Adresse</td></tr></table>
                </asp:Panel>
                

            </td>
            </tr>             <tr>
            <td style="padding-bottom:40px">    
  <asp:ScriptManager ID="ScriptManager1" 
                               runat="server" />
                               
                        <asp:UpdatePanel runat="server" ID="UpdatePanel1" 
                            UpdateMode="Conditional" onload="UpdatePanel1_Load">
                            <ContentTemplate>
                      <asp:PlaceHolder runat="server" ID="PlaceHolder1"
                                    EnableViewState="false" >     
                          
                 <asp:repeater id="Repeater1"       
                    runat="server">
                    <headertemplate>
                       <table style="padding-left:140px">
                    </headertemplate>
                    <itemtemplate>
                      <tr bgcolor="#e8e8e8">
                <td style="width:140px;"><asp:TextBox ID="name" runat="server" Width="140px" Text='<%# Eval("Name")%>'/></td><td style="width:140px;"><asp:TextBox ID="sunname" runat="server" Width="140px" Text='<%# Eval("Sunname")%>'/></td><td style="width:140px;"><asp:TextBox ID="fødelsdato" runat="server" Width="140px" Text='<%# Eval("Fødelsdato")%>'/></td><td style="width:70px;">
                <asp:DropDownList ID="gender" runat="server" Width="70px" AutoPostBack="true">
                <asp:ListItem></asp:ListItem>
                 <asp:ListItem>Kvinne</asp:ListItem>
                               <asp:ListItem>Mann</asp:ListItem>
                               <asp:ListItem>Jente</asp:ListItem>
                               <asp:ListItem>Gutt</asp:ListItem>
                </asp:DropDownList></td><td style="width:140px;"><asp:TextBox ID="adresse" runat="server" Width="140px" Text='<%# Eval("Address")%>'/></td>
                      </tr>
                    </itemtemplate>
                    <footertemplate>
                      </table>
                    </footertemplate>
                </asp:repeater>
                                          <asp:Panel runat="server" ID="registrerPan" Visible="false" Enabled="false">  <uc1:customerregistration ID="customerregistration1" runat="server" />
                            <br/>
                            <div style="font-weight:bold; padding-right:130px" align="right">
                                <asp:LinkButton ID="leggtil" runat="server" ForeColor="#00b000" OnClick="leggtil_Click">Legg til reisende</asp:LinkButton></div>
                            <div style="font-weight:bold; padding-right:130px; color: red" align="right">
                                <asp:Literal ID="feil" runat="server"></asp:Literal></div>
                                <div style="padding-left:140px; font-weight:bold">Tillegg informasjon</div>
                                <div style="padding-left:140px"><textarea id="tillegginformasjon" cols="25" rows="5" runat="server"></textarea></div>
                                
                                </asp:Panel>

                </asp:PlaceHolder>
                               
                            </ContentTemplate>
                           
                        </asp:UpdatePanel>
            </td>
            </tr>
            <tr><td valign="middle" style="padding-bottom:40px; padding-left:140px; padding-right:130px">
                <asp:Button ID="updateBtn" runat="server" Text="Bekreft" Visible="false" Enabled="false"
                    onclick="updateBtn_Click" /> <asp:Literal ID="nb" runat="server" Visible="false">
                                <b style="color:red">NB!</b> Korriger og send inn din registrering med &quot;Bekreft&quot; 
                                knappen. Vi gjør oppmerksomhet på at du ikke kan hente ut data igjen etter at du 
                                har bekrefet. Har du spørsmål kan du ta kontakt med oss for hjelp.</asp:Literal>
            &nbsp;</td></tr>
            </table>
             <table style="width:950px;background-color:#00b000;" align="center">
        <tr align="center">
            <td>
                <a href="Packages.aspx?agreement={0}" style="color:White">Reisevilkår</a>  |  
                <a href="Packages.aspx?questions={0}" style="color:White">Ofte stilte spørsmål</a>  | 
                <a href="Reisebyrå/om-oss.htm" style="color:White">Om oss</a>  |
                <a href="Reisebyrå/kontaktinfo.htm" style="color:White">Kontakt</a>
            </td>
        </tr>
         <tr align="center">
            <td>
                 <p>© 2014 Uforglemmelig Kina Tur.</p>
            </td>
        </tr>
    </table>
      </td></tr></table>
    </form>
	<script>document.getElementById("Order").style.display="none"</script>
</body>
</html>
