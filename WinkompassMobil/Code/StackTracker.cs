using System;

namespace Winkompass_Mobil.Code
{
    public class StackTracker
    {
        public const string BackbText = "agoback";
        public const string BackbValue = "1";
        public const int BacktrackSize = 20;

        public string GetBackUrl => GetRawNextBackUrl();

        private static string GetRawNextBackUrl()
        {
            var url =
                SessionManager.Manager.BackStackList[
                    Math.Max(SessionManager.Manager.BackStackList.Count - (SessionManager.Manager.BackStackDepth + 1), 0)
                    ];
            return url;
        }
    }
}