﻿using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for rewriteurl
/// </summary>
public class rewriteurl: IHttpModule
{
    public void Init(HttpApplication app)
    {
        // register for pipeline events
        app.BeginRequest += new EventHandler(this.OnBeginRequest);
    }

    public void Dispose() { }

    public void OnBeginRequest(object o, EventArgs args)
    {
        // get access to app and context

        HttpApplication app = (HttpApplication)o;

        HttpContext ctx = app.Context;
        string fullOrigionalpath = app.Context.Request.Url.ToString();
        //articles under reisetips-til-kina catelog
        if (fullOrigionalpath.Contains("/reisetips-"))
        {
            string[] phrase = fullOrigionalpath.Split('/');
            app.Context.RewritePath("~/Extrahjelp.aspx?reisetips=" + phrase[4].Substring(0, phrase[4].Length - 4));
        }
        if (fullOrigionalpath.Contains("/annonser-"))
        {
            string[] phrase = fullOrigionalpath.Split('/');
            //temperarly resolution, waiting for search engine updates
            app.Context.RewritePath("~/Extrahjelp.aspx?annonser=" + phrase[4].Substring(0, phrase[4].Length - 4));
        }
        //articles under Kina catelog
        if (fullOrigionalpath.Contains("/Kina/"))
        {
            string[] phrase = fullOrigionalpath.Split('/');
            app.Context.RewritePath("~/Extrahjelp.aspx?kina=" + phrase[4].Substring(0, phrase[4].Length - 4));
        }
        //articles under Reisetilkina-blogg catelog
        if (fullOrigionalpath.Contains("/Blogg-Reiseikina/"))
        {
            string[] phrase = fullOrigionalpath.Split('/');
            app.Context.RewritePath("~/Extrahjelp.aspx?blogg=" + phrase[4].Substring(0, phrase[4].Length - 4));
        }
        //articles under our travel agent
        if (fullOrigionalpath.Contains("/Reisebyrå/om-oss.htm"))
        {
            string[] phrase = fullOrigionalpath.Split('/');
            app.Context.RewritePath("~/Extrahjelp.aspx?aboutus=" + phrase[4].Substring(0, phrase[4].Length - 4));
        }
        //articles under our travel agent
        if (fullOrigionalpath.Contains("/Reisebyrå/kontaktinfo.htm"))
        {
            string[] phrase = fullOrigionalpath.Split('/');
            app.Context.RewritePath("~/Extrahjelp.aspx?contact=" + phrase[4].Substring(0, phrase[4].Length - 4));
        }
        //articles vi over 60
        if (fullOrigionalpath.Contains("/Pensjonister/"))
        {
            string[] phrase = fullOrigionalpath.Split('/');
            app.Context.RewritePath("~/Extrahjelp.aspx?pensjonistreiser=" + phrase[4].Substring(0, phrase[4].Length - 4));
        }
        //articles under our travel agent
        /* if (fullOrigionalpath.Contains("/Kina-Reiser/"))
         {
             string[] phrase = fullOrigionalpath.Split('/');
             app.Context.RewritePath("~/" + phrase[4].ToString());
         }*/
    }
}
