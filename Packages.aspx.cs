using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class Packages : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["package"] != null)
        {
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "billige feriereiser, billige pakketurer";
            head.Controls.Add(meta);
            HtmlMeta meta1 = new HtmlMeta();
            meta1.Name = "description";
            meta1.Content = "Vi tilbyr billige pakketurer til Kina. Sjekk våre innholdsrike og høystandard pakketurer på billige priser. Våre tilbud er ekte rimelige luksus.";
            head.Controls.Add(meta1);
            Control c2 = LoadControl("~/usercontrol/frontside/packages.ascx");
            rightcln.Controls.Add(c2);
        }
        if (Request.QueryString["description"] != null && Request.QueryString["description"].ToString() == "{1}")
        {
            Page.Title = "Billig pakketur - Billig pakketur til Kina - Hello Kina";
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "billig pakketur til Kina, billig pakketur";
            head.Controls.Add(meta);
            HtmlMeta meta1 = new HtmlMeta();
            meta1.Name = "description";
            meta1.Content = "Reise til Kinas mest kjente byer Beijing og Shanghia. Delta i vår billig pakketur Hello Kina.";
            head.Controls.Add(meta1);
            Control cl = LoadControl("~/usercontrol/frontside/router1description.ascx");
            content.Controls.Add(cl);
            Control c2 = LoadControl("~/usercontrol/frontside/packages1.ascx");
            rightcln.Controls.Add(c2);
        }
        if (Request.QueryString["description"] != null && Request.QueryString["description"].ToString() == "{1b}")
        {
            Page.Title = "Pakkereise til Kina - Magiske landsbyer i sørvest-Kina";
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "Tur til Kina, pakkereise til Kina, den kinesiske mur, opplevelsesreise, tur til Guizhou, Kinesisk folkkultur";
            head.Controls.Add(meta);
            HtmlMeta meta1 = new HtmlMeta();
            meta1.Name = "description";
            meta1.Content = "Spennende reiser til Kina. Oppleve de storeste byenen i Kina, urørte landsbyer, sceniske attraksjoner og minoritetskulturer i Kina. Oppleve det mangfoldige Kina";
            head.Controls.Add(meta1);
            Control cl = LoadControl("~/usercontrol/frontside/router1Bdescription.ascx");
            content.Controls.Add(cl);
            Control c2 = LoadControl("~/usercontrol/frontside/packages1.ascx");
            rightcln.Controls.Add(c2);
            //Control c4 = LoadControl("~/usercontrol/frontside/advertisment15dager.ascx");
            //rightcln.Controls.Add(c4);
        }
        if (Request.QueryString["description"] != null && Request.QueryString["description"].ToString() == "{1c}")
        {
            Page.Title = "Pakkereise til Kina - Mangfoldige kulturopplevelser i Kina";
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "mangfoldig Kina, kulturreise i Kina, tur til Guizhou, Kinesisk folkkultur";
            head.Controls.Add(meta);
            HtmlMeta meta1 = new HtmlMeta();
            meta1.Name = "description";
            meta1.Content = "Spennende reiser til Kina. Oppleve de storeste byenen i Kina, urørte landsbyer, sceniske attraksjoner og minoritetskulturer i Kina. Oppleve det mangfoldige Kina";
            head.Controls.Add(meta1);
            Control cl = LoadControl("~/usercontrol/frontside/router1Cdescription.ascx");
            content.Controls.Add(cl);
            Control c2 = LoadControl("~/usercontrol/frontside/packages1.ascx");
            rightcln.Controls.Add(c2);
            //Control c4 = LoadControl("~/usercontrol/frontside/advertisment15dager.ascx");
            //rightcln.Controls.Add(c4);
        }
       /* if (Request.QueryString["description"] != null && Request.QueryString["description"].ToString() == "{2}")
        {
            Page.Title = "Billig pakkereise - Billig pakkereise til Kina - Rundt i keisebyene";
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "billig tur, reise til beijing, den kinesiske mur, billige pakkereise til Kina, billig pakkereise";
            head.Controls.Add(meta);
            HtmlMeta meta1 = new HtmlMeta();
            meta1.Name = "description";
            meta1.Content = "Reiser til Kinas meste kjente keiserbyer Beijing og Xi'an. Besøke keiseres palasse, keiseres villa, himmelens tempelet og mye mer.";
            head.Controls.Add(meta1);
            Control cl = LoadControl("~/usercontrol/frontside/router2description.ascx");
            content.Controls.Add(cl);
            Control c2 = LoadControl("~/usercontrol/frontside/packages1.ascx");
            rightcln.Controls.Add(c2);

        }*/
        /*if (Request.QueryString["description"] == null && Request.QueryString["description"].ToString() == "{3}")
        {
            Page.Title = "Billig pakkereise - Billig pakkereise til Kina påsken 2016";
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "billig pakketur, billig pakkereise, billig påsketur";
            head.Controls.Add(meta);
            HtmlMeta meta1 = new HtmlMeta();
            meta1.Name = "description";
            meta1.Content = "Billig pakkereise til Kina. Reis billig til verdens fremstående reisemål Beijing, Xi'an og Shanghai.";
            head.Controls.Add(meta1);
            Control cl = LoadControl("~/usercontrol/frontside/router3description.ascx");
            content.Controls.Add(cl);
            Control c2 = LoadControl("~/usercontrol/frontside/packages1.ascx");
            rightcln.Controls.Add(c2);
        }*/
        if (Request.QueryString["description"] != null && Request.QueryString["description"].ToString() == "{3b}")
        {
            Page.Title = "Billig reise - Billig pakkereise til Kina - Den klassiske rundreisen til Kina";
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "billig reiser, pakkereise, billig pakkereise, pakkereiser til kina, pakketurer til kina, reise til beijing";
            head.Controls.Add(meta);
            HtmlMeta meta1 = new HtmlMeta();
            meta1.Name = "description";
            meta1.Content = "Billig rundreise til Kina. Reis billig til verdens fremstående reisemål Beijing, Xi'an, Shanghai og Guilin. Bestill den innholdsrike og spennende reisen nå!";
            head.Controls.Add(meta1);
            Control cl = LoadControl("~/usercontrol/frontside/router3Bdescription.ascx");
            content.Controls.Add(cl);
            Control c2 = LoadControl("~/usercontrol/frontside/packages1.ascx");
            rightcln.Controls.Add(c2);
        }
        if (Request.QueryString["description"] != null && Request.QueryString["description"].ToString() == "{4b}")
        {
            Page.Title = "Billig reise - Foto-tur til Tibet - Billig pakkereise til Beijing, Tibet og Shanghai";
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "Foto-tur til Tibet, Reise til Beijing, Reise til Tibet,";
            head.Controls.Add(meta);
            HtmlMeta meta1 = new HtmlMeta();
            meta1.Name = "description";
            meta1.Content = "Foto-tur til Tibet. Reise til Beijing, verdens tak Tibet og Shanghai. En Visual Feast for fotografering.";
            head.Controls.Add(meta1);
            Control cl = LoadControl("~/usercontrol/frontside/router4bdescription.ascx");
            content.Controls.Add(cl);
            Control c2 = LoadControl("~/usercontrol/frontside/packages1.ascx");
            rightcln.Controls.Add(c2);

        }
        /*if (Request.QueryString["description"] != null && Request.QueryString["description"].ToString() == "{4}")
        {
            Page.Title = "Billig reise - Billig pakkereise til Kina - Billig pakkereise til Beijing, Shanghai, Tibet (med tog) og Shanghai";
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "reise til shanghai, billige pakkereise til Kina, billige reiser til Kina, billig feriereise, reise til tibet, tibet med tog";
            head.Controls.Add(meta);
            HtmlMeta meta1 = new HtmlMeta();
            meta1.Name = "description";
            meta1.Content = "Reiser til Shanghai, Beijing, Xi'an og verdens tak Tibet. Reise til Tibet med tog og oppleve den unike naturskjønheten langs Qinghai-Tibet-linjen.";
            head.Controls.Add(meta1);
            Control cl = LoadControl("~/usercontrol/frontside/router4description.ascx");
            content.Controls.Add(cl);
            Control c2 = LoadControl("~/usercontrol/frontside/packages1.ascx");
            rightcln.Controls.Add(c2);

        }
        if (Request.QueryString["description"] != null && Request.QueryString["description"].ToString() == "{5}")
        {
            Page.Title = "Billig pakkereise - Billig pakkereise til Kina - Yangtze cruise";
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "tur til shanghai, billig cruise, ferie i kina, pakkereiser til kina, pakketurer til kina, Yangtze cruise";
            head.Controls.Add(meta);
            HtmlMeta meta1 = new HtmlMeta();
            meta1.Name = "description";
            
            meta1.Content = "Delux Yangtze cruise til billig pris. Oppleve 5 stjernes New Centry cruise på Yangtze elven og noen av Kinas største byer blant annet Beijing, Xi'an, Shanghai og Chongqing.";
            head.Controls.Add(meta1);
            Control cl = LoadControl("~/usercontrol/frontside/router5description.ascx");
            content.Controls.Add(cl);
            Control c2 = LoadControl("~/usercontrol/frontside/packages1.ascx");
            rightcln.Controls.Add(c2);
        }
        if (Request.QueryString["description"] != null && Request.QueryString["description"].ToString() == "{5b}")
        {
            Page.Title = "Billig pakkereise - Billig pakkereise til Kina - Yangtze cruise (B)";
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "tur til shanghai, billig cruise, ferie i kina, pakkereiser til kina, pakketurer til kina, Yangtze cruise";
            head.Controls.Add(meta);
            HtmlMeta meta1 = new HtmlMeta();
            meta1.Name = "description";

            meta1.Content = "Delux Yangtze cruise til billig pris. Oppleve 5 stjernes cruise på Yangtze elven og noen av Kinas største byer Beijing og Shanghai.";
            head.Controls.Add(meta1);
            Control cl = LoadControl("~/usercontrol/frontside/router5Bdescription.ascx");
            content.Controls.Add(cl);
            Control c2 = LoadControl("~/usercontrol/frontside/packages1.ascx");
            rightcln.Controls.Add(c2);
        }
        if (Request.QueryString["description"] != null && Request.QueryString["description"].ToString() == "{6}")
        {
            Page.Title = "Billig pakkereise - Billig pakkereise til Kina - Beijing Ekspress";
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "billig tur til beijing, shoppingtur, billig pakkereise, shopping i Beijing, reiser til beijing, tur til Beijing";
            head.Controls.Add(meta);
            HtmlMeta meta1 = new HtmlMeta();
            meta1.Name = "description";
            meta1.Content = "Sightseeing og shopping i Beijing. Bli med oss til spennende førjulstur til Beijing.";
            head.Controls.Add(meta1);
            Control cl = LoadControl("~/usercontrol/frontside/router6description.ascx");
            content.Controls.Add(cl);
            Control c2 = LoadControl("~/usercontrol/frontside/packages1.ascx");
            rightcln.Controls.Add(c2);

        }
        if (Request.QueryString["description"] != null && Request.QueryString["description"].ToString() == "{6b}")
        {
            Page.Title = "Billig pakkereise - Billig pakkereise til Kina - Beijing Ekspress (B)";
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "billig tur til beijing, shoppingtur, billig pakkereise, shopping i Beijing, reiser til beijing, tur til Beijing";
            head.Controls.Add(meta);
            HtmlMeta meta1 = new HtmlMeta();
            meta1.Name = "description";
            meta1.Content = "Sightseeing og shopping i Beijing. Bli med oss til en ukes førjulstur til Beijing.";
            head.Controls.Add(meta1);
            Control cl = LoadControl("~/usercontrol/frontside/router6Bdescription.ascx");
            content.Controls.Add(cl);
            Control c2 = LoadControl("~/usercontrol/frontside/packages1.ascx");
            rightcln.Controls.Add(c2);

        }*/

        if (Request.QueryString["description"] != null && Request.QueryString["description"].ToString() == "{7}")
        {
            Page.Title = "Billig pakkereise - Billig pakkereise til Kinas store byer og tre kløfter";
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "billig tur, billig pakkereise";
            head.Controls.Add(meta);
            HtmlMeta meta1 = new HtmlMeta();
            meta1.Name = "description";
            meta1.Content = "Billig pakkereise til Kinas store byer og Cruisetur på tre kløfter";
            head.Controls.Add(meta1);
            Control cl = LoadControl("~/usercontrol/frontside/router7description.ascx");
            content.Controls.Add(cl);
            Control c2 = LoadControl("~/usercontrol/frontside/packages1.ascx");
            rightcln.Controls.Add(c2);
        }
        if (Request.QueryString["description"] != null && Request.QueryString["description"].ToString() == "{8}")
        {
            Page.Title = "Billig pakkereise - Billig pakkereise til Kina - Den store kinareisen";
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "billig tur til beijing, shoppingtur, billig pakkereise, rundreise til Kina";
            head.Controls.Add(meta);
            HtmlMeta meta1 = new HtmlMeta();
            meta1.Name = "description";
            meta1.Content = "Reise til Beijing, X'an, Chengdu, Lijiang, Kunming, Guilin, Shanghai og Suzhou. Bli med på den store rundreisen til Kina.";
            head.Controls.Add(meta1);
            Control cl = LoadControl("~/usercontrol/frontside/router3Cdescription.ascx");
            content.Controls.Add(cl);
            Control c2 = LoadControl("~/usercontrol/frontside/packages1.ascx");
            rightcln.Controls.Add(c2);

        }
        if (Request.QueryString["agreement"] != null)
        {
            Page.Title = "Uforglemmelig Kina Tur - Generelle reisevilkår for pakkereiser";
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "reisevilkår Kinaturer, pakkereise, pakkereiser til Kina, kina visum, pakkereiseloven";
            head.Controls.Add(meta);
            Control cl = LoadControl("~/usercontrol/frontside/agreement.ascx");
            content.Controls.Add(cl);
            Control c2 = LoadControl("~/usercontrol/frontside/packages1.ascx");
            rightcln.Controls.Add(c2);

        }
        if (Request.QueryString["questions"] != null)
        {
            Page.Title = "Uforglemmelig Kina Tur - Ofte stilte spørsmål";
            HtmlHead head = Page.Header;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keyword";
            meta.Content = "flyreise til kina, valuta i kina, vaksine kina, bruke kreditkort i kina";
            head.Controls.Add(meta);
            Control cl = LoadControl("~/usercontrol/frontside/questions.ascx");
            content.Controls.Add(cl);
            Control c2 = LoadControl("~/usercontrol/frontside/packages1.ascx");
            rightcln.Controls.Add(c2);

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
    protected void Packageshandle_Click(object sender, EventArgs e)
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
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Packages.aspx?description={1}");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Packages.aspx?description={2}");
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
