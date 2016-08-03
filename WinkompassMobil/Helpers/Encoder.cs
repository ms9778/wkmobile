using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Winkompass_Mobil.Helpers
{
    public class Encoder   
    {public static HtmlString Encode(string url)
        {
            string result = url.Replace("/", "%252F");
            HtmlString hResult = new HtmlString(result);
            return  hResult;
        }
    }
}