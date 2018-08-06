<%@ Control EnableViewState="false" Language="C#" AutoEventWireup="true" CodeFile="reisetipslist.ascx.cs" Inherits="usercontrol_frontside_reisetipslist" %>



<link href="../../App_Themes/vennskaper/vennskaper.css" rel="stylesheet" type="text/css" />
<table style="font-size:small; width: 720px;">
    <tr>
        <td style="padding-top:10px; padding-left:110px" valign="top" >
           <asp:GridView ID="GridView1" runat="server" AllowPaging="True" CellPadding="4"  
                ForeColor="#333333" GridLines="None" Width="720px" 
                onselectedindexchanged="GridView1_SelectedIndexChanged" 
                onpageindexchanging="GridView1_PageIndexChanging" BorderColor="#E1E1E1" 
                BorderStyle="Solid" BorderWidth="1px">
               <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
               <Columns>
                   <asp:CommandField ButtonType="Button" ShowSelectButton="True" SelectText="Les" 
                       ItemStyle-Width="100px">
<ItemStyle Width="100px"></ItemStyle>
                   </asp:CommandField>
               </Columns>
               <FooterStyle BackColor="#cce6ff" Font-Bold="True" ForeColor="black" />
               <PagerStyle BackColor="#cce6ff" ForeColor="black" HorizontalAlign="Right" />
              
               <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
               <HeaderStyle BackColor="#cce6ff" Font-Bold="True" ForeColor="#cce6ff" />
               <EditRowStyle BackColor="#999999" />
               <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        </asp:GridView>
           
        </td>
        
    </tr>
</table>