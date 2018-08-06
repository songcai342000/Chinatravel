<%@ Control EnableViewState="false" Language="C#" AutoEventWireup="true" CodeFile="advertisment2.ascx.cs" Inherits="usercontrol_frontside_advertisment2" %>
<link href="../../App_Themes/vennskaper/vennskaper.css" rel="stylesheet" type="text/css" />
<table style="font-size:x-small;" cellpadding="0px" cellspacing="0px" align="left">
<tr>
<td>  

<asp:ScriptManager ID="ScriptManager1" runat="server" />
 
<asp:Timer ID="Timer1" Interval="6000" runat="server" />
    <asp:UpdatePanel ID="up1" runat="server">
 
        <Triggers>
 
            <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
 
        </Triggers>
 
        <ContentTemplate>
 
            <asp:AdRotator
 
            id="AdRotator1"
 
            AdvertisementFile="~/rotatepic.xml"
 
            KeywordFilter="small"
 
            Runat="server" />
 
        </ContentTemplate>
 
    </asp:UpdatePanel>    
    </td>
</tr>
</table>
