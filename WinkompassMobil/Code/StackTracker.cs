using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Winkompass_Mobil
{
    public class StackTracker
    {
        public const string BACKB_TEXT = "agoback";
        public const string BACKB_VALUE = "1";
        public const int BACKTRACK_SIZE = 20;

        public string GetBackUrl
        {
            get
            {
                return getRawNextBackUrl();
            }
        }

        private string getRawNextBackUrl()
        {
            string url = SessionManager.Manager.BackStackList[Math.Max(SessionManager.Manager.BackStackList.Count - (SessionManager.Manager.BackStackDepth+1),0)];
            return url;
        }
    }
}