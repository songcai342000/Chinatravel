<%@ Control Language="C#" AutoEventWireup="true" CodeFile="customerregistration.ascx.cs" Inherits="usercontrol_frontside_customerregistration" %>
<table style="padding-left: 140px">
  <tr bgcolor="#e8e8e8" align="center">
    <td style="width:140px"><asp:TextBox ID="name" runat="server" Width="140px"/></td><td style="width:140px"><asp:TextBox ID="sunname" runat="server" Width="140px"/></td><td style="width:140px"><asp:TextBox ID="fødelsdato" runat="server" Width="140px"/></td><td style="width:70px">
    <asp:DropDownList ID="gender" runat="server" Width="70px" AutoPostBack="true">
    <asp:ListItem></asp:ListItem>
     <asp:ListItem>Kvinne</asp:ListItem>
                   <asp:ListItem>Mann</asp:ListItem>
                   <asp:ListItem>Jente</asp:ListItem>
                   <asp:ListItem>Gutt</asp:ListItem>
    </asp:DropDownList></td><td style="width:140px"><asp:TextBox ID="address" runat="server" Width="140px"/></td></tr>
          </table>