<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Adminpage.aspx.cs" Inherits="Adminpage" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
     <title>Finn vennskap og dating gratis på nett</title>
		<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
        <meta name="description" content="Vennskap, gratis dating for damer og menn" />
        <meta name="expires" content="never" />
        <meta name="language" content="nor" />
        <meta name="charset" content="UTF-8" />
         <meta http-equiv="content-language" content="no" />
        <meta name="distribution" content="Global" />
        <meta name="email" content="kundeservice@heymyfriends.com" />
        <meta name="copyright" content="heymyfriends.com" />
        <meta name="author" content="heymyfriends.com" />
</head>
<body bgcolor="#e1e1e1">
    <form id="form1" runat="server">
    <div>
    <table border="0" style="border: 0px none #00b000; width:   950px; height:140px;" 
    align="center" >
    <tr style="width: 100%;" align="center">
        <td style="vertical-align:middle; font-size: xx-large; color: #00b000; 
            font-family: 'Trebuchet MS'; font-weight: lighter; font-style: italic; 
            font-variant: normal; border-right-color:#00b000;"  
            align="center" >
            China Travel<table cellpadding="3" border="0"><tr align="center"><td style="font-size:large; font-family: 'Trebuchet MS'; color:#00b000; border-left-color:#00b000;">
                The most charmful routes in China</td></tr>
            </table></td></tr>
    </table>
  
    <table id="menutable" style="border-bottom-color:Silver;width:950px;" align="center">
    <tr>
        <td align="left">
        <asp:LinkButton id="start" runat="server" PostbackUrl="~/Login.aspx" 
                Text="Home" ForeColor="#00b000" onclick="start_Click"></asp:LinkButton>&nbsp; | &nbsp;
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
        <asp:LinkButton id="Packageshandle" runat="server" Text="Packages" ForeColor="#00b000" onclick="Packageshandle_Click"></asp:LinkButton>
            &nbsp; | &nbsp;
        </td>
    </tr>
</table>
        <table style="font-size:x-small;width:950px" align="center">
        <tr>
            <td>    
            
                <asp:DropDownList ID="neworder" runat="server">
                </asp:DropDownList>
                &nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" Text="Read" />
               
            </td>

            </tr>
            <tr>
            <td>    
            
                <asp:DropDownList ID="waitlist" runat="server">
                </asp:DropDownList>
                 &nbsp;&nbsp;
                <asp:Button ID="Button7" runat="server" Text="Read" />
                &nbsp;&nbsp;
                <asp:Button ID="Button5" runat="server" Text="Confirm" />
                &nbsp;
                <asp:Button ID="Button2" runat="server" Text="Delete" />
                &nbsp;
                <asp:Button ID="Button8" runat="server" Text="Summary" />

            </td>

            </tr>
            <tr>
            <td>    
                <asp:DropDownList ID="confirmed" runat="server">
                </asp:DropDownList>
                &nbsp;&nbsp;
                <asp:Button ID="Button9" runat="server" Text="Read" />
                 &nbsp;&nbsp;
                <asp:Button ID="Button10" runat="server" Text="Confirm" />
                &nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" Text="Delete" />
                &nbsp;&nbsp;
                <asp:Button ID="Button11" runat="server" Text="Summary" />
            </td>

            </tr>
            <tr>
            <td>    
                <asp:DropDownList ID="DropDownList4" runat="server">
                </asp:DropDownList>
                &nbsp;&nbsp;
                <asp:Button ID="Button4" runat="server" Text="Read" />
                &nbsp;&nbsp;
                <asp:Button ID="Button6" runat="server" Text="Confirm" />
                &nbsp;&nbsp;
                <asp:Button ID="Button12" runat="server" Text="Summary" />
                &nbsp;&nbsp;
                <asp:Button ID="Button13" runat="server" Text="Archive" />
            </td>

            </tr>
            <tr>
            <td>    
                <asp:Literal ID="Literal2" runat="server"></asp:Literal>

            </td>
            </tr>
             <tr>
            <td>    
                <asp:Button ID="encryp" runat="server" onclick="encryp_Click" Text="Encryp" ></asp:Button><asp:TextBox ID="urlordernumber" runat="server"></asp:TextBox>
                <asp:Literal ID="encrypturlordernumber" runat="server"></asp:Literal>
            </td>
            </tr>
             <tr>
            <td>    
                <asp:Button ID="newsletter" runat="server" onclick="newsletter_Click" Text="send newsletter"></asp:Button></td>
            </tr>
            </table>
             <table style="width:950px;background-color:#00b000" align="center">
        <tr align="center">
            <td>
                <a href="general/Hjelp.aspx?Agreement={0}" style="color:White">Reisevilkår  
                |  
                <a href="general/Hjelp.aspx?Contact={0}" style="color:White">Kontakt</a>
            </td>
        </tr>
         <tr align="center">
            <td>
                 <p>© 2010 heymyfriends.com. All Rights Reserved.</p>
            </td>
        </tr>
    </table>
    </div>
    </form>
   
</body>
</html>
