using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Winkompass_Mobil
{
    #region Responsive base class
    public abstract class Responsive
    {
        public const string DELFI_AGENT = "Mozilla/4.0 (compatible; MSIE 6.0; Windows CE; IEMobile 8.12; MSIEMobile 6.5)";
        public abstract HtmlString HtmlDoc { get; }
        public abstract HtmlString CssLink { get; }
        public abstract HtmlString ViewPort { get; }
        public abstract HtmlString CustomHeaderVariables { get; }
    }
    #endregion
    #region HTML 4 EXTENDED CLASS FOR DELFI

    public class html4 : Responsive
    {

        public override HtmlString HtmlDoc
        {
            get { return new HtmlString("<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.01//DA\" \"http://www.w3.org/TR/html4/strict.dtd\">"); }
        }

        public override HtmlString CssLink
        {
            get { return new HtmlString("<link type=\"text/css\" rel=\"stylesheet\" href=\"" + UrlHelper.GenerateContentUrl("/Content/Site.css", new HttpContextWrapper(HttpContext.Current)) + "\" />"); }
        }

        public override HtmlString ViewPort
        {
            get { return new HtmlString("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1, maximum-scale=1, minimum-scale=1, user-scalable=no\">"); }
        }

        public override HtmlString CustomHeaderVariables
        {
            get { return new HtmlString(""); }
        }
    }
    #endregion
    #region HTML 5 EXTENDED CLASS FOR HTML 5 APPLICABLE DEVICES
    public class html5 : Responsive
    {

        public override HtmlString HtmlDoc
        {
            get { return new HtmlString("<!DOCTYPE HTML>"); }
        }

        public override HtmlString CssLink
        {
            get { return new HtmlString("<link type=\"text/css\" rel=\"stylesheet\" href=\"" + UrlHelper.GenerateContentUrl("/Content/Site5.css", new HttpContextWrapper(HttpContext.Current)) + "\" />"); }
        }

        public override HtmlString ViewPort
        {
            get { return new HtmlString("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1, maximum-scale=1, minimum-scale=1, user-scalable=no\">"); }
        }
        public override HtmlString CustomHeaderVariables
        {
            get { return new HtmlString("<link type=\"text/css\" rel=\"stylesheet\" href=\"" + UrlHelper.GenerateContentUrl("/Content/bootstrap.min.css", new HttpContextWrapper(HttpContext.Current)) + "\" />\n<link type=\"text/css\" rel=\"stylesheet\" href=\"" + UrlHelper.GenerateContentUrl("~/Content/bootstrap-theme.min.css", new HttpContextWrapper(HttpContext.Current)) + "\" />"); }
        }
    }
    #endregion
}