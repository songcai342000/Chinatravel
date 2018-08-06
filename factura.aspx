<%@ Page Language="C#" AutoEventWireup="true" CodeFile="factura.aspx.cs" Inherits="factura" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
    <table align="center"  style="width:595px;height:842px;"><tr><td>
    <table align="center" style="width:100%">
     <tr style=" height:160px;">
    <td style="width:50%;">
    <img id="logo" src="images/uforglemmeligkinatur-logo.jpg" />
    </td>
    <td style="width:50%; font-weight:bold; font-size:14px; vertical-align:bottom;" align="center">
    Faktura
    </td>
    </tr>
    <tr style=" height:25px">
    <td style="width:50%">
    Kunde:
        Arild Maberg</td>
    <td style="width:50%">
    Leverandør:
        Sellereite Translation
        <br />
        and Web Professional</td>
    </tr>
    <tr style=" height:25px">
    <td style="width:50%">
    Address:
        Skibberheia 32, 4870 FEVIK</td>
    <td style="width:50%">
    Vår ordne:
    </td>
    </tr>
     <tr style=" height:25px">
    <td style="width:50%">
        Postnr: 4870</td>
    <td style="width:50%">
    Vår ref:
        Song Cai Sellereite</td>
    </tr>
     <tr style=" height:25px">
    <td style="width:50%">
        </td>
    <td style="width:50%">
    Fakturanr:
        220090006002402</td>
    </tr>
     <tr style=" height:25px">
    <td style="width:50%">
        Kommune: FEVIK</td>
    <td style="width:50%">
    UtskriftsDato:
        27.06.2012</td>
    </tr>
     <tr style=" height:25px">
    <td style="width:50%">
    </td>
    <td style="width:50%">
    Forfallsdato: 15.07.2012
    </td>
    </tr>
      <tr style=" height:25px">
    <td style="width:50%">
    Produkt:
        </td>
    <td style="width:50%">
    Leverandør:
    </td>
    </tr>
    </table>
    <br/><br/><br/><br/>
    <table align="center" style="width:100%">
     <tr style=" height:25px">
    <td style="width:25%">
    MVA:
        </td>
         <td style="width:25%">
    MVA-kode:
        </td>
         <td style="width:25%">
    Beløpsgrunnlag:
        </td>
         <td style="width:25%">
    Mva-beløp:
        </td>
  
    </tr>
     <tr style=" height:25px">
    <td style="width:25%">
    Netto:
        </td>
         <td style="width:25%">
    MVA:
        </td>
         <td style="width:25%">
    Valuta:
        </td>
         <td style="width:25%">
    Sum:
        </td>
  
    </tr>
    </table>
     <br/><br/><br/><br/>
   
    <table style="width:100%;font-size:8px">
     <tr style=" height:35px">
    <td style="width:25%">
    Org.nr: 
        <br />
        888557032</td>
         <td style="width:25%">
    Address:
             <br />
             Furusethveien 100</td>
         <td style="width:25%">
    Tlf:
             (+47)92 66 19 79</td>
     
   
    </tr>
     <tr style=" height:35px">
    <td style="width:33%">
    Epost:
        <br />
        kontakt@kinaturer.com</td>
         <td style="width:33%">
         Post nr:
             <br />
             100, Askim</td>
         <td style="width:33%">
             Faks: (+47)69 88 66 98</td>
        
   
    </tr>
    <tr style=" height:35px">
    <td style="width:33%">
    Bankkonto:
        </td>
         <td style="width:33%">
    SWIFT:
        </td>
         <td style="width:33%">
     IBAN:
        </td>
       
   
    </tr>
    </table>
   
     <br/><br/><br/><br/>
    <table style="width:100%; background-color:Yellow; height:35px">
    <tr>
    <td>
    </td>
    </tr>
    </table>
    <table style="width:100%;font-size:8px">
     
      <tr style=" height:50px">
    <td>
    Betalingsinformasjon 
        </td>
         <td style="width:50%">
    <b style="font-size:large">Giro 
             </b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
             Betalingsfrist<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
             30.11.2011</td>
     
    </tr>
    <tr style=" height:50px">
    <td>
        </td>
         <td style="width:50%">
             Underskrift ved girering<br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
     
    </tr>
     <tr style=" height:150px">
    <td class="style1">
    Betalt av <br/><br/>
    Jon Oddvar Sellereite<br/>
    Furusethveien 100<br/>
    1811 Askim
        </td>
         <td style="width:50%">
    Betalt til<br/><br/>
    Sellereite Translation and Web Professional<br/>
    Furusethveien 100<br/>
    1811 Askim
             </td>
     
    </tr>
     <tr style=" height:25px; background-color:Yellow" align="right">
    <td >
        Belast konto <table><tr><td style="background-color:White"></td><td style="background-color:White"></td><td style="background-color:White"></td><td style="background-color:White"></td><td style="background-color:White"></td><td style="background-color:White"></td><td style="background-color:White"></td><td style="background-color:White"></td><td style="background-color:White"></td><td style="background-color:White"></td><td style="background-color:White"></td><td style="background-color:White"></td></tr></table></td>
         <td style="width:50%">
         Kvittering tilbake<table><tr><td style="background-color:White"></td></tr></table>
         </td>
    </tr>
    
    </table>
    <table style="width:100%">
    <tr style=" height:35px"> 
    <td style="width:33%">
        Kundeidentifikasjon (KID)
        </td>
         <td style="width:33%">
             Kroner&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
             Øre         </td>
         <td style="width:33%">
             Til konto
        </td>
    </tr>
      <tr style=" height:35px">
    <td style="width:33%">
        100000000000000
        </td>
         <td style="width:33%">
             22999&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
             00         </td>
         <td style="width:33%">
             
        </td>
    </tr>
    </table>
    <table style="width:100%; background-color:Yellow; height:35px">
    <tr>
    <td>
    </td>
    </tr>
    </table>
    
    </form>
</body>
</html>
