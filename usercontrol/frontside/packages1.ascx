<%@ Control EnableViewState="false" Language="C#" AutoEventWireup="true" CodeFile="packages1.ascx.cs" Inherits="usercontrol_frontside_packages1" %>
<link href="../../App_Themes/vennskaper/vennskaper.css" rel="stylesheet" type="text/css" />

<table style="background:#ccd9ff; border: solid 1px #00b000;width:285px">
<tr>
<td style="padding: 6px 6px 6px 6px">
<table style="font-size:x-small; width:265px;border:solid 1px #00b000;height:70px; padding-left:0px; padding-right:0px; background:#ccd9ff" cellpadding="0px" cellspacing="0px">
<tr>
<td> Bestill Pakkereise<br/>
 <asp:DropdownList ID="reisen" runat="server" AutoPostBack="True" Width="225px">
                               <asp:ListItem></asp:ListItem>
                               <asp:ListItem>Rundreise i den mangfoldige Kina (12 dager)</asp:ListItem>
                               <asp:ListItem>Kinas gyldne tre-kanter (11 dager)</asp:ListItem>
                               <asp:ListItem>Reise til Kinas store byer og tre kløfter (14 dager)</asp:ListItem>
                               <asp:ListItem>Den store kinareisen (18 dager)</asp:ListItem>
                               <asp:ListItem>Foto-tur til Beijing, Tibet og Shanghai (18 dager)</asp:ListItem>
                               <asp:ListItem>Hello Kina (8 dager)</asp:ListItem>
                           </asp:DropdownList><asp:RequiredFieldValidator ID="RequiredFieldValidatorReisen" runat="server" ErrorMessage="Feltet kan ikke være tomt" Text="*" ValidationGroup="myValidationgroup3" ControlToValidate="reisen"></asp:RequiredFieldValidator>
                         <asp:ValidationSummary ID="ValidationSummary3" runat="server" ValidationGroup="myValidationgroup3" DisplayMode="BulletList" />
   </td></tr>
   <tr><td><asp:Button runat="server" ID="chose" width="110px" Text="Velg" BackColor="#ccd9ff" onclick="chose_Click" ValidationGroup="myValidationgroup3" ForeColor="#003366"/>
</td>
</tr>
</table>
<br/>

<table style="width:265px;border:solid 1px #00b000;background-color:#ccd9ff;height:110px;padding-left:0px; padding-right:0px;" cellpadding="0px" cellspacing="0px" >
<tr>
<td >
Registrer deg for våre nyhetsbrev<br/>
Epostaddress: <asp:TextBox ID="epost" runat="server" Width="150px" />        
<asp:RequiredFieldValidator ID="epostValidator1" runat="server" ErrorMessage="Feltet kan ikke være tomt" Text="*" ValidationGroup="myValidationgroup2" ControlToValidate="epost"></asp:RequiredFieldValidator>
<asp:RegularExpressionValidator ID="epostValidator2" runat="server" ErrorMessage="uriktig dataformat" Text="*" ValidationGroup="myValidationgroup2" ControlToValidate="epost" ValidationExpression="^((([a-zA-Z0-9._-]+)\@)(([a-zA-Z0-9._-]+)\.)([a-zA-Z]+))$"></asp:RegularExpressionValidator>
<asp:ValidationSummary ID="ValidationSummary2" runat="server" ValidationGroup="myValidationgroup2" DisplayMode="BulletList" />
</td>
</tr>
<tr>
<td >
<asp:CheckBox runat="server" ID="pensjonist" Text="Jeg er pensjonist"/>
</td>
</tr>
<tr>
<td class="style1">
<asp:Button runat="server" ID="regi" width="110px" Text="Registrer" BackColor="#ccd9ff" ForeColor="#003366"
        onclick="regi_Click" ValidationGroup="myValidationgroup2"/>&nbsp;&nbsp;<asp:Button runat="server" ID="avregi" width="110px" Text="Avregistrer" onclick="avregi_Click" ValidationGroup="myValidationgroup2" BackColor="#ccd9ff" ForeColor="#003366"/>
</td>
</tr>
</table>
 <br/>

<table style="width:265px;height:70px;border:solid 1px #00b000;padding-left:0px; padding-right:0px; background-color:#ccd9ff;" cellpadding="0px" cellspacing="0px" >
<tr><td>
<b style="color: #00b000">Kontake oss på:</b>
<br/>kontakt@kinaturer.com<br/>
Alle henvendelser vil bli behandlet fortløpende.
</td></tr></table>
</td>
</tr>
</table>


