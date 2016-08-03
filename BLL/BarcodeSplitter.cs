using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BarcodeSplitter
    {
        public static string[] splitItem(string code)
        {
return code.Split(new string[] { "/D" }, StringSplitOptions.None);
        }

        public static void extractParameters(ScanItem item)
        {
            if (item.barCode.Contains("£"))
            {
                item.barCode = item.barCode.Replace("£", "/D");
            }
            string[] bararray = splitItem(item.barCode);
            if(bararray.Length>1)
            {
                item.barCode = bararray[0];
                item.par1 = bararray[1];
                if(bararray.Length>2)
                {
                    item.par2 = bararray[2];
                }
            }
        }
    }
}
