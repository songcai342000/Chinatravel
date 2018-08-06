<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Orderquery.aspx.cs" Inherits="Orderquery" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Reference Control="~/usercontrol/frontside/packages1.ascx" %>
<%@ Register src="usercontrol/frontside/packages1.ascx" tagname="packages1" tagprefix="uc1" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
		<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
        <meta name="keyword" content="kina reiseruter, feire kina, reise kina, bestill reise, reiser på nett" />        
        <meta name="expires" content="never" />
        <meta name="language" content="nor" />
        <meta name="charset" content="UTF-8" />
         <meta http-equiv="content-language" content="no" />
        <meta name="distribution" content="Global" />
        <meta name="email" content="kontakt@kinaturer.com" />
        <meta name="copyright" content="kinaturer.com" />
        <meta name="author" content="kinaturer.com" />
        <style type="text/css">
            .style1
            {
                width: 615px;
            }
            .style2
            {
                width: 584px;
            }
        </style>
</head>
<body bgcolor="#e1e1e1">
    <form id="form1" runat="server" >
    <table align="center" style="background:white;-moz-opacity:70%;border: solid 1px #00b000;-moz-box-shadow: 10px 10px 5px #949494;
 -webkit-box-shadow: 10px 10px 5px #949494; box-shadow: 10px 10px 5px #949494; background-image: url('images/feiji-red-jus-3.jpg'); background-repeat:no-repeat;"><tr><td>
    <table border="0" style="width:   950px; height:140px;" 
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
  
    <table id="menutable" style="width:950px;border: solid 1px #00b000;font-weight:bold" align="center">
    <tr>
        <td align="left">
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
                onclick="Shanghai_Click" ToolTip="Les våre nyheter her"></asp:LinkButton>&nbsp; | 
            &nbsp;
             <asp:LinkButton id="Tibet" runat="server" 
                Text="Tibet" 
                ForeColor="#00b000"
                onclick="Tibet_Click"></asp:LinkButton>&nbsp; | 
            &nbsp;
        <asp:LinkButton id="Packageshandle" runat="server" Text="Kina reiser" ForeColor="#00b000" onclick="Packageshandle_Click"></asp:LinkButton>
            &nbsp; | &nbsp;
                    <asp:LinkButton id="flyhotel" runat="server" Text="Visum" ForeColor="#00b000" onclick="Hotel_Click" 
                ></asp:LinkButton>&nbsp; | &nbsp;                
                  <asp:LinkButton id="blogg" runat="server" Text="Blogg" ForeColor="#00b000" onclick="blogg_Click"
                ></asp:LinkButton>&nbsp; | &nbsp;       
        </td>
    </tr>
</table>
        <table style="font-size:x-small;width:950px;" cellpadding="0px" cellspacing="0px" align="center"><tr style="width:100%">
            <td style="padding-left:20px;">
         <table ><tr>
             <td style="border-right:solid 1px #00b000; padding-top:20px; padding-left:40px;  width:70%" 
                 valign="top" class="style2" >
               <table style="width:400px;border-width:0px" cellpadding="0px" cellspacing="0px" >
                <tr style="height:50px" valign="middle">
                       <td>
                           </td>
                       <td>
                       <asp:Literal runat="server" ID="trips" /><br/>
                                </td>
                   </tr>
                    
                   <tr>
                       <td>
                           Kontaktpersons navn:</td>
                       <td>
                           <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox><asp:RequiredFieldValidator
                               ID="nameValidator" runat="server" ErrorMessage="Feltet kan ikke være tomt" Text="*" ValidationGroup="myValidationgroup" ControlToValidate="nameTxt" ></asp:RequiredFieldValidator></td>
                   </tr>
                   <tr>
                       <td>
                           Mobil:<br />
                           (Skriv nummeret uten mellomrom i dataformatet: <br/> (+landsnummer)lokalnummer)</td>
                       <td>
                           <asp:TextBox ID="teleTxt" runat="server" Text="(+47)"></asp:TextBox><asp:RequiredFieldValidator
                               ID="teleValidator1" runat="server" ErrorMessage="Feltet kan ikke være tomt" Text="*" ValidationGroup="myValidationgroup" ControlToValidate="teleTxt" ></asp:RequiredFieldValidator><asp:RegularExpressionValidator
                                   ID="teleValidator2" runat="server" ErrorMessage="uriktig mobilnummer" Text="*" ValidationGroup="myValidationgroup" ControlToValidate="teleTxt" ValidationExpression="^(\()(\+)(\d{2})(\))(([0-9-]+){7,})$"></asp:RegularExpressionValidator>
  
                                   </td>
                   </tr>
                   <tr>
                       <td>
                           Epost:</td>
                       <td>
                           <asp:TextBox ID="epostTxt" runat="server" ></asp:TextBox><asp:RequiredFieldValidator
                               ID="epostValidator1" runat="server" ErrorMessage="Feltet kan ikke være tomt" Text="*" ValidationGroup="myValidationgroup" ControlToValidate="epostTxt"></asp:RequiredFieldValidator><asp:RegularExpressionValidator
                                   ID="epostValidator2" runat="server" ErrorMessage="uriktig dataformat" Text="*" ValidationGroup="myValidationgroup" ControlToValidate="epostTxt" ValidationExpression="^((([a-zA-Z0-9._-]+)\@)(([a-zA-Z0-9._-]+)\.)([a-zA-Z]+))$"></asp:RegularExpressionValidator>
                       </td>
                   </tr>
                   <tr>
                       <td>
                           Adresse:</td>
                       <td>
                           <asp:TextBox ID="adresseTxt" runat="server" ></asp:TextBox><asp:RequiredFieldValidator
                               ID="adressevaliation" runat="server" ErrorMessage="Feltet kan ikke være tomt" Text="*" ValidationGroup="myValidationgroup" ControlToValidate="adresseTxt"></asp:RequiredFieldValidator>
                       </td>
                   </tr>
                   <tr>
                       <td>
                           Antall voksne:</td>
                       <td>
                           <asp:DropdownList ID="vokseTxt" runat="server" AutoPostBack="True" >
                               <asp:ListItem>1</asp:ListItem>
                               <asp:ListItem>2</asp:ListItem>
                               <asp:ListItem>3</asp:ListItem>
                               <asp:ListItem>4</asp:ListItem>
                               <asp:ListItem>5</asp:ListItem>
                               <asp:ListItem>6</asp:ListItem>
                               <asp:ListItem>7</asp:ListItem>
                               <asp:ListItem>8</asp:ListItem>
                               <asp:ListItem></asp:ListItem>
                           
                           </asp:DropdownList></td>
                   </tr>
                  
                   <tr>
                       <td>
                           Antall barn(2-11år):</td>
                       <td>
                          <asp:DropdownList ID="barnTxt" runat="server" AutoPostBack="True" >
                              <asp:ListItem>0</asp:ListItem>
                              <asp:ListItem>1</asp:ListItem>
                              <asp:ListItem>2</asp:ListItem>
                              <asp:ListItem>3</asp:ListItem>
                              <asp:ListItem>4</asp:ListItem>
                              <asp:ListItem>5</asp:ListItem>
                              <asp:ListItem>6</asp:ListItem>
                              <asp:ListItem>7</asp:ListItem>
                              <asp:ListItem>8</asp:ListItem>
                              <asp:ListItem></asp:ListItem>
                          
                          </asp:DropdownList> </td>
                   </tr>
                  
                   <tr>
                       <td>
                           Antall baby(under 2 år):</td>
                       <td>
                       <asp:DropdownList ID="babiTxt" runat="server" AutoPostBack="True" >
                           <asp:ListItem>0</asp:ListItem>
                           <asp:ListItem>1</asp:ListItem>
                           <asp:ListItem>2</asp:ListItem>
                           <asp:ListItem>3</asp:ListItem>
                           <asp:ListItem>4</asp:ListItem>
                           <asp:ListItem>5</asp:ListItem>
                           <asp:ListItem>6</asp:ListItem>
                           <asp:ListItem>7</asp:ListItem>
                           <asp:ListItem>8</asp:ListItem>
                       
                       </asp:DropdownList></td>
                   </tr>
                   
                    <tr>
                       <td valign="top">
                           Reisetid:
                           </td>
                       <td id="postbacktd" style="width:200px" runat="server" onclick="DoPostBack()">
                           <input id="departuredate" runat="server" style="width:200px" onclick="Hiddenvalue()" />
                           <asp:Label runat="server" id="datelable" Text="Du må velge avreisesdato" ForeColor="red" Visible="false"></asp:Label>
                           
                           <asp:ScriptManager ID="ScriptManager1" 
                               runat="server" />
                        <asp:UpdatePanel runat="server" ID="UpdatePanel1" onload="UpdatePanel1_Load"
                            UpdateMode="Conditional" >
                            <ContentTemplate>
                            <input id="Hidden1" type="hidden" runat="server" value=""/>    
                                <asp:PlaceHolder runat="server" ID="PlaceHolder1"
                                    EnableViewState="false" >
 
                                    </asp:PlaceHolder>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                       </td>
                   </tr>
                  
                    <tr>
                       <td>
                       
                           </td>
                       <td>
                         
                       </td>
                   </tr>
                   <tr>
                       <td>
                           </td>
                       <td>
                           <asp:Button ID="send" runat="server" Enabled="false" Text="Bestill" Width="90px" onclick="send_Click" ValidationGroup="myValidationgroup">
                             
                           </asp:Button>&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="cancel" runat="server" Text="Kansell" Width="90px" onclick="cancel_Click">
                             
                           </asp:Button>
                           <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="myValidationgroup" DisplayMode="BulletList" />
                       </td>
                   </tr>
                   <tr>
                       <td align="right">
                       <asp:CheckBox id="agreeChk" runat="server" AutoPostBack="true"></asp:CheckBox>
                           </td>
                       <td>Jeg bekrefter jeg har lest 
                           <a id="agreement" href="Packages.aspx?agreement={0}" target="_blank">
                             Reisevilkår
                           </a>
                       </td>
                   </tr>
               </table>
          </td>
            <td style="width:30%;padding-top:20px;padding-bottom:40px; padding-right:10px; padding-left:15px;" valign="top" >    
                <uc1:packages1 ID="packages11" runat="server" />
            </td>
            </tr></table>
           </td>
          
           </tr>
            <tr><td>
             <table style="width:950px;background-color:#00b000" align="center" cellpadding="0px" cellspacing="0px" >
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
                 <p>© 2015 Uforglemmelig Kina Tur.</p>
            </td>
        </tr>
    </table>
    </td>
        </tr>
    </table>
     </td></tr></table>
     <script language="javascript" type="text/javascript">

    function DoPostBack() {
        __doPostBack('UpdatePanel1', '');
        if (document.getElementById('<%=Hidden1.ClientID%>').value != '1')
        {
        document.getElementById('<%=departuredate.ClientID%>').value = document.getElementById('<%=Hidden1.ClientID%>').value;
        }
  }
 
  function Hiddenvalue() {
      document.getElementById('<%=Hidden1.ClientID%>').value = "1";
  }
</script>
    </form>
 

</body>
</html>




