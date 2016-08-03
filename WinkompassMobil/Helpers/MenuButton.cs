using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Winkompass_Mobil.Helpers
{
    public class MenuButton
    {
        public static string Create(string link,string text,Boolean removeTilde = false)
        {
            if (removeTilde)
            {
                link = link.Substring(1);
                link = UrlHelper.GenerateContentUrl(link, new HttpContextWrapper(HttpContext.Current)); 
            }
            return "<form action=\""+link+"\"><input class=\"menuButton element tinyBotSpace\" type=\"submit\" value=\""+text+"\"></form>";
        }

        public static HtmlString HCreate(string link,string text)
        {
            return new HtmlString(Create(link, text));
        }
    }
}