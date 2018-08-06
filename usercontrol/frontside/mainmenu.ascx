<%@ Control EnableViewState="false" Language="C#" AutoEventWireup="true" CodeFile="mainmenu.ascx.cs" Inherits="usercontrol_mainmenu" %>
<link href="../../App_Themes/vennskaper/vennskaper.css" rel="stylesheet" type="text/css" />
 <table id="menutable" style="border-bottom-color:Silver;">
    <tr>
        <td style="width:100%; padding-left:5px">
        <asp:LinkButton id="start" runat="server" PostbackUr="" 
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
                onclick="Shanghai_Click" ToolTip="Les våre nyheter her"></asp:LinkButton>&nbsp; | &nbsp;
        <asp:LinkButton id="Packages" runat="server" Text="Packages" ForeColor="#00b000"
                ></asp:LinkButton>&nbsp; | &nbsp;
        </td>
    </tr>
</table>