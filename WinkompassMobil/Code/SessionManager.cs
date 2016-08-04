using System.Collections.Generic;
using System.Web;

namespace Winkompass_Mobil.Code
{
    public class SessionManager
    {
        public const string Backstack = "backstacklist";
        public const string MANAGER = "Session Manager";
        public const string StackCount = "back stack count";
        public const string Stacktracker = "stack tracker";
        public const string RESPONSIVE = "responsive html";
        public const string IgnoreThisAction = "ignore current action";

        private SessionManager()
        {
            HttpContext.Current.Session.Add(Backstack, new List<string>());
            ResetStakcCounter();
            HttpContext.Current.Session[Stacktracker] = new StackTracker();
            HttpContext.Current.Session[IgnoreThisAction] = false;
        }

        public List<string> BackStackList => HttpContext.Current.Session[Backstack] as List<string>;

        public bool IgnoreAction
        {
            get { return (bool) HttpContext.Current.Session[IgnoreThisAction]; }
            set { HttpContext.Current.Session[IgnoreThisAction] = value; }
        }

        /// <summary>
        ///     Returnerer et tal der fortæller hvor langt inde i fortrydelses listen brugeren er
        ///     som standard er den 1 da der altid vil være mindst en i listen.
        /// </summary>
        public int BackStackDepth
        {
            get { return (int) HttpContext.Current.Session[StackCount]; }
            set
            {
                if (value < 1)
                    HttpContext.Current.Session[StackCount] = 1;
                else
                    HttpContext.Current.Session[StackCount] = value;
            }
        }

        public StackTracker BStackTracker => HttpContext.Current.Session[Stacktracker] as StackTracker;

        public static SessionManager Manager
        {
            get
            {
                if (HttpContext.Current.Session[MANAGER] == null)
                {
                    HttpContext.Current.Session[MANAGER] = new SessionManager();
                }
                return HttpContext.Current.Session[MANAGER] as SessionManager;
            }
        }

        public Responsive Responsive
        {
            get
            {
                if (HttpContext.Current.Session[RESPONSIVE] != null)
                    return (Responsive) HttpContext.Current.Session[RESPONSIVE];
                if (HttpContext.Current.Request.UserAgent == Responsive.DELFI_AGENT)
                {
                    HttpContext.Current.Session[RESPONSIVE] = new html4();
                }
                else
                {
                    HttpContext.Current.Session[RESPONSIVE] = new html5();
                }
                return (Responsive) HttpContext.Current.Session[RESPONSIVE];
            }
        }

        public void ResetStakcCounter()
        {
            BackStackDepth = 1;
        }
    }
}