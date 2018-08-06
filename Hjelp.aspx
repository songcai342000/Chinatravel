<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Hjelp.aspx.cs" Inherits="Hjelp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
		<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
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
                 <asp:LinkButton id="Tibet" runat="server" 
                Text="Tibet" 
                ForeColor="#00b000"
                onclick="Tibet_Click"></asp:LinkButton>&nbsp; | 
            &nbsp;
        <asp:LinkButton id="Packages" runat="server" Text="Kina reiser" ForeColor="#00b000" onclick="Packages_Click"
                ></asp:LinkButton>&nbsp; | &nbsp;
                        <asp:LinkButton id="flyhotel" runat="server" Text="Fly,Hotell" ForeColor="#00b000" onclick="Hotel_Click" 
                ></asp:LinkButton>&nbsp; | &nbsp;                
                          <asp:LinkButton id="blogg" runat="server" Text="Blogg" ForeColor="#00b000" onclick="blogg_Click"
                ></asp:LinkButton>&nbsp; | &nbsp;       
        </td>
    </tr>
</table>
<div id="Hjelp">
<a href="http://www.4elive.net/%E3%82%AB%E3%83%AB%E3%83%86%E3%82%A3%E3%82%A8%E3%80%90cartier-%E3%80%91-c-11016/">&#12459;&#12523;&#12486;&#12451;&#12456; &#12522;&#12531;&#12464;</a>, 
<a href="http://www.downundertigermeet.com/%E3%83%B4%E3%82%A3%E3%83%B4%E3%82%A3%E3%82%A2%E3%83%B3%E3%82%A6%E3%82%A7%E3%82%B9%E3%83%88%E3%82%A6%E3%83%83%E3%83%89%E3%80%90viviennewestwood%E3%80%91-c-37007">sh-01e vivienne westwood</a>, 
<a href="http://www.muylujo.net/%E3%82%B3%E3%83%BC%E3%83%81-coach-c-101/">&#12467;&#12540;&#12481; &#36001;&#24067;</a>, 
<a href="http://www.visitstmichaelsmd.org/%E3%82%B3%E3%83%AB%E3%83%9C%E3%80%90corbo%E3%80%91-c-15048/">&#12467;&#12523;&#12508; &#36001;&#24067;</a>, 
<a href="http://www.3av.org/">&#12467;&#12523;&#12508; &#24215;&#33303;</a>, 
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
	<script>document.getElementById("Hjelp").style.display="none"</script>
</body>
</html>
