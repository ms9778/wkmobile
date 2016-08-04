using System.Web;

namespace Winkompass_Mobil.Helpers
{
    public class Encoder
    {
        public static HtmlString Encode(string url)
        {
            var result = url.Replace("/", "%252F");
            var hResult = new HtmlString(result);
            return hResult;
        }
    }
}