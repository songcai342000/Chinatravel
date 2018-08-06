<%@ Control Language="C#" AutoEventWireup="true" CodeFile="kina.ascx.cs" Inherits="usercontrol_frontside_kina" %>
<table style="font-size:small; width: 720px; " align="center">
    <tr>
        <td style="padding-top:10px" valign="top" >
            <table id="righttables" style="padding-left:0px;border: solid 1px #e1e1e1;width:720px;">
            <tr style="height:35px; background-color:#f0f8ff; border:solid 1px #00b000">
 	        <td style="font-weight:bold" align="center">
                 <asp:Literal ID="titleLit" runat="server"/></td>
            </tr>
            <tr style="height:30px; width:720px;">
 	        <td valign="middle" style="padding-bottom:15px;">
 	             <asp:Literal ID="contentLit" runat="server"/>
                 <br />
                 <a id="previous" style="font-weight:bold; color: #00b000;" 
                    runat="server" visible="false">Forrige artikkel</a></td>
            </tr>
            <tr style="width:720px;">
 	        <td align="right" valign="middle" style="font-weight:bold;height:35px;">
 	             <asp:LinkButton ID="back" runat="server" ForeColor="#00b000" Text="Tilbake" PostBackUrl="http://www.kinaturer.com/Default.aspx"
                    /></td>
            </tr>
            </table>
        </td>
    </tr>
</table>