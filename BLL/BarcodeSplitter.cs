using System;
using BE;

namespace BLL
{
    public class BarcodeSplitter
    {
        public static string[] SplitItem(string code)
        {
            return code.Split(new[] {"/D"}, StringSplitOptions.None);
        }

        public static void ExtractParameters(ScanItem item)
        {
            if (item.BarCode.Contains("£"))
            {
                item.BarCode = item.BarCode.Replace("£", "/D");
            }
            var bararray = SplitItem(item.BarCode);
            if (bararray.Length > 1)
            {
                item.BarCode = bararray[0];
                item.Par1 = bararray[1];
                if (bararray.Length > 2)
                {
                    item.Par2 = bararray[2];
                }
            }
        }
    }
}