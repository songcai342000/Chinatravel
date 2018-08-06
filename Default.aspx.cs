using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        /*string ipadresse = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
        if (ipadresse=="" || ipadresse == null)
        {
            ipadresse = Request.ServerVariables["REMOTE_ADDR"];
            if (ipadresse == "84.215.47.139")
            //if (ipadresse == "95.34.54.133" || ipadresse == "143.97.2.35")
            //if (ipadresse == "127.0.0.1")
            {
                Response.Redirect("http://www.nrk.no");
            }
        }*/
        Control cl = LoadControl("~/usercontrol/frontside/start.ascx");
        Control c3 = LoadControl("~/usercontrol/frontside/weather.ascx");
        Control c2 = LoadControl("~/usercontrol/frontside/advertisment.ascx");
        contentpan.Controls.Add(cl);
        advertisment.Controls.Add(c2);
        contentpan.Controls.Add(new LiteralControl("<br/><br/>"));
        //weatherpan.Controls.Add(c3);
        Literal2.Text = "1 349 millioner";
        Literal3.Text = "140,5 stykker/km2";
        Literal4.Text = "9,6 millioner km2";
        Literal5.Text = "--";
        Literal7.Text = "--";
        Label3.Text = "Kystlinje:";
        Label1.Text = "32 000km2";
        if (Request.QueryString["package"] == null)
        {
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "reise til kina, kina reiser, Reise Kina, Kina";
            HtmlMeta meta1 = new HtmlMeta();
            meta1.Name = "description";
            meta1.Content = "For mange er en kinareise en drøm som må utfylles i livet. Vi tilbyr gruppereiser, individuelle reiser og skreddersydde reiser til Kina. Sjekk våre gode og innholdsrike kinareiser og bli med oss på en spennende Kina tur!";
            head.Controls.Add(meta);
            head.Controls.Add(meta1);
            cl = LoadControl("~/usercontrol/frontside/start.ascx");
            contentpan.Controls.Clear();
            contentpan.Controls.Add(cl);
            contentpan.Controls.Add(new LiteralControl("<br/><br/>"));
            //weatherpan.Controls.Add(c3);
            //contentpan.Controls.Add(c3);
        }
        else if (Request.QueryString["package"].ToString() == "start")
        {
            Page.Title = "Kina Tur - Om Kina - Reise til Kina";
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "kina reiser, billige reiser til kina, reise til kina, Reise Kina, Kina";
            head.Controls.Add(meta);
            HtmlMeta meta1 = new HtmlMeta();
            meta1.Name = "description";
            meta1.Content = "Kina ligger på den østlige delen av det asiatiske kontinentet og den vestlige kysten av Stillehavet. Kina har en stor kulturarv og fantastisk natur. I tillegg, i Kina kan man kjøpe fine kunstverker, smykker, tekstiler og andre daglige varer på lavere priser. Det å reise til Kina med oss vil bli en spennende og uforglemmelig opplevelse.";
            head.Controls.Add(meta1);
            cl = LoadControl("~/usercontrol/frontside/start.ascx");
            contentpan.Controls.Clear();
            contentpan.Controls.Add(cl);
            contentpan.Controls.Add(new LiteralControl("<br/><br/>"));
            //contentpan.Controls.Add(c3);
            Literal2.Text = "1 349 millioner";
            Literal3.Text = "140,5 stykker/km2";
            Literal4.Text = "9,6 millioner km2";
            Literal5.Text = "--";
            Literal7.Text = "--";
            Label3.Text = "Kystlinje:";
            Label1.Text = "32 000km2";
        }
        else if (Request.QueryString["package"].ToString() == "beijing")
        {
            Page.Title = "Kina Tur - Om Beijing - Reise til Beijing";
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "reise til Beijing, Beijing Reiser, Reise Beijing, Beijing reise";
            head.Controls.Add(meta);
            HtmlMeta meta1 = new HtmlMeta();
            meta1.Name = "description";
            meta1.Content = "Beijing er en av byene i verden som har fleste attraksjoner som står på listen over verdens kulturarv. Mange drømer om å reise til Beijing en gang i livet for å se den berømte og mystiske hovedstaden til landet som har langst historie i verden. Per i dag er det ca 14,7 millioner turister reiser til Beijing hvert år";
            head.Controls.Add(meta1);
            cl = LoadControl("~/usercontrol/frontside/beijing.ascx");
            contentpan.Controls.Clear();
            contentpan.Controls.Add(cl);
            advertisment.Controls.Clear();
            Literal2.Text = "19.61 millioner";
            Literal3.Text = "1341 stykker/km2";
            Literal4.Text = "16 410,54km2";
            Literal5.Text = "43,5 m";
            Literal7.Text = "11,8°C";
            Label3.Text = "";
            Label1.Text = "";

        }
        else if (Request.QueryString["package"].ToString() == "xian")
        {
            Page.Title = "Kina Tur - Om Xi'an - Reise til Xi'an";
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "kina tur, Reise til Kina";
            head.Controls.Add(meta);
            HtmlMeta meta1 = new HtmlMeta();
            meta1.Name = "description";
            meta1.Content = "Xi'an var hovedstad for Kina i 13 dynastier gjennom totalt 1140 år. I Xi'an finnes noen av de mest kjente kinesiske keisersgravene og verdens åttende underverk Terrakotta krigerne. Å reise til Xi'an kan man oppleve den luksøse livstilen av kinesiske keisere og den lange historie av Kina.";
            head.Controls.Add(meta1);
            cl = LoadControl("~/usercontrol/frontside/xian.ascx");
            contentpan.Controls.Clear();
            contentpan.Controls.Add(cl);
            advertisment.Controls.Clear();
            Literal2.Text = "6,18 millioner";
            Literal3.Text = "619 stykker/km2";
            Literal4.Text = "9 977km2";
            Literal5.Text = "400 m";
            Literal7.Text = "13°C";
            Label3.Text = "";
            Label1.Text = "";

        }
        else if (Request.QueryString["package"].ToString() == "guizhou")
        {
            Page.Title = "Kina Tur - Om Guizhou - Reise til Guizhou";
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "kinesiske minoriteter, kinesisk kultur, turister i kina";
            head.Controls.Add(meta);
            HtmlMeta meta1 = new HtmlMeta();
            meta1.Name = "description";
            meta1.Content = "Guizhou har vakre naturer og fargerike minoritetskulturer. I Guizhou kan turister oppleve gamle landsbyer, urørte stammer, kulturelt mangfold og natur-underverk.";
            head.Controls.Add(meta1);
            cl = LoadControl("~/usercontrol/frontside/guizhou.ascx");
            contentpan.Controls.Clear();
            contentpan.Controls.Add(cl);
            advertisment.Controls.Clear();
            Literal2.Text = "36.58 millioner";
            Literal3.Text = "208 stykker/km2";
            Literal4.Text = "176 167km2";
            Literal5.Text = "1107 m";
            Literal7.Text = "14,2°C";
            Label3.Text = "";
            Label1.Text = "";

        }
        else if (Request.QueryString["package"].ToString() == "guilin")
        {
            Page.Title = "Kina Tur - Om Guilin - Reise til Guilin";
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "Kina ferie, Kina Guilin";
            head.Controls.Add(meta);
            HtmlMeta meta1 = new HtmlMeta();
            meta1.Name = "description";
            meta1.Content = "Guilin er kåret som Kinas beste landskap og har et hyggelig klima. Guilin er en veldig populær turistperle.";
            head.Controls.Add(meta1);
            cl = LoadControl("~/usercontrol/frontside/guilin.ascx");
            contentpan.Controls.Clear();
            contentpan.Controls.Add(cl);
            advertisment.Controls.Clear();
            Literal2.Text = "5,6 millioner";
            Literal3.Text = "171 stykker/km2";
            Literal4.Text = "27 809km2";
            Literal5.Text = "150 m";
            Literal7.Text = "19°C";
            Label3.Text = "";
            Label1.Text = "";

        }
        else if (Request.QueryString["package"].ToString() == "shanghai")
        {
            Page.Title = "Kina Tur - Om Shanghai - Reise til Shanghai";
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "reise shanghai, reiser til shanghai, Shanghai reise, Kinas største by";
            head.Controls.Add(meta);
            HtmlMeta meta1 = new HtmlMeta();
            meta1.Name = "description";
            meta1.Content = "Hver dag er det mange fra hele verden reiser til Shanghai. Turister reiser til Shanghai for å oppleve spektakulære bykonstruksjon og tradisjonelle kinesiske kultur. Shanghai er dessuten også en paradise for handel. Det å reise til Shanghai er både opplevelserik og økonomisk.";
            head.Controls.Add(meta1);
            cl = LoadControl("~/usercontrol/frontside/shanghai.ascx");
            contentpan.Controls.Clear();
            contentpan.Controls.Add(cl);
            advertisment.Controls.Clear();
            Literal2.Text = "23 millioner";
            Literal3.Text = "3628 stykker/km2";
            Literal4.Text = "6 340km2";
            Literal5.Text = "4 m";
            Literal7.Text = "16°C";
            Label3.Text = "";
            Label1.Text = "";

        }
        else if (Request.QueryString["package"].ToString() == "tibet")
        {
            Page.Title = "Kina Tur - Om Tibet - Reise til Tibet";
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "reise tibet, kina tibet, reise til tibet";
            head.Controls.Add(meta);
            HtmlMeta meta1 = new HtmlMeta();
            meta1.Name = "description";
            meta1.Content = "Tibet er stort, rent og stille. Høye fjell, tallløse innsjøer, frodige skoger og store sletter i området har skapt en utrolig vakker natur. Tibetanske velbesvarte gamle tradisjoner og sterke religionsatmosfære har i tillegg dekket området med mystiske farger og hevet områdets sjarme. Hvert år reiser mange turister fra hele verden til Tibet for å utforske dets unike skjønnhet.";
            head.Controls.Add(meta1);
            cl = LoadControl("~/usercontrol/frontside/tibet.ascx");
            contentpan.Controls.Clear();
            contentpan.Controls.Add(cl);
            advertisment.Controls.Clear();
            Literal2.Text = "2,81 millioner";
            Literal3.Text = "3628 stykker/km2";
            Literal4.Text = "1,22 millioner km2";
            Literal5.Text = "4260 m";
            Literal7.Text = "8°C";
            Label3.Text = "";
            Label1.Text = "";

        }
       
    }

    protected void start_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx?package=start");

    }
    protected void Beijing_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx?package=beijing");

    }
    protected void Xian_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx?package=xian");

    }
    protected void Guizhou_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx?package=guizhou");

    }
    protected void Shanghai_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx?package=shanghai");

    }
    protected void Packages_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Packages.aspx?package=package");

    }
    protected void Guilin_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx?package=guilin");

    }
    protected void Tibet_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx?package=tibet");

    }
    protected void Hotel_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Extrahjelp.aspx?hotel=hotel");

    }
    protected void blogg_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/blogg/spennende-påsketur-i-kina.htm");

    }

   
  
}
