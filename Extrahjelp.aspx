<%@ Page Language="C#"  AutoEventWireup="true" CodeFile="Extrahjelp.aspx.cs" Inherits="Extrahjelp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<style type="text/css">
a {color:#00b000;text-decoration:none;}
#a2 {color:White}
</style>
		<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
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
        <td align="left" id="a1">
        <a id="kina" runat="server" >Kina</a>&nbsp; | &nbsp;
        <a id="beijing" runat="server" >Beijing</a>&nbsp; | &nbsp;
        <a id="xian" runat="server" >Xian</a>&nbsp; | &nbsp;
        <a id="guizhou" runat="server" >Guizhou</a>&nbsp; | &nbsp;
        <a id="guilin" runat="server" >Guilin</a>&nbsp; | &nbsp;
        <a id="shanghai" runat="server" >Shanghai</a>&nbsp; | &nbsp;
        <a id="tibet" runat="server" >Tibet</a>&nbsp; | &nbsp;
        <a id="reiser" runat="server" >Kina Reiser</a>&nbsp; | &nbsp;
        <a id="hotel" runat="server" >Visum</a>&nbsp; | &nbsp;
        <a id="blogg" runat="server" >Blogg</a>&nbsp; | &nbsp;
        </td>
    </tr>
</table>
<div id="Extrahjelp">

</div>
        <table style="font-size:x-small;width:950px;" align="center"><tr>
            <td>    
            <table style="font-size:x-small;" align="left"><tr>
            <td>                 
               <asp:Panel id="mainpic" src="" runat="server" />
            </td>
            <td>    
                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            </td>
            </tr>
            </table>
            </td>

            </tr>
            <tr>
            <td style="padding-bottom:40px">    
                <asp:Panel id="contentpan" src="" runat="server" />

            </td>
            </tr>
            </table>
             <table style="width:950px;background-color:#00b000;" align="center">
        <tr align="center">
            <td>
                <a id="agreement" runat="server" style="color:White">Reisevilkår</a>  |  
                <a id="questions" runat="server" style="color:White">Ofte stilte spørsmål</a>  | 
                <a id="aboutus" runat="server" style="color:White">Om oss</a>  |
                <a id="contact" runat="server" style="color:White">Kontakt</a>
            </td>
        </tr>
         <tr align="center">
            <td>
                 <p>Velkommen til å ta kontakt med oss!</p>
            </td>
        </tr>
    </table>
      </td></tr></table>
    </form>
	<script>document.getElementById("Extrahjelp").style.display="none"</script>
</body>
</html>
