using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Winkompass_Mobil
{
    public class SessionManager
    {
        public const string BACKSTACK = "backstacklist";
        public const string MANAGER = "Session Manager";
        public const string STACK_COUNT = "back stack count";
        public const string STACKTRACKER = "stack tracker";
        public const string RESPONSIVE = "responsive html";
        public const string IGNORE_THIS_ACTION = "ignore current action";

        public List<string> BackStackList
        {
            get { return HttpContext.Current.Session[BACKSTACK] as List<string>; }
        }

        public Boolean IgnoreAction
        {
            get { return (Boolean)HttpContext.Current.Session[IGNORE_THIS_ACTION]; }
            set { HttpContext.Current.Session[IGNORE_THIS_ACTION] = value; }
        }

        /// <summary>
        /// Returnerer et tal der fortæller hvor langt inde i fortrydelses listen brugeren er
        /// som standard er den 1 da der altid vil være mindst en i listen.
        /// </summary>
        public int BackStackDepth
        {
            get { return (int)HttpContext.Current.Session[STACK_COUNT]; }
            set
            {
                if (value < 1)
                    HttpContext.Current.Session[STACK_COUNT] = 1;
                else
                    HttpContext.Current.Session[STACK_COUNT] = value;
            }
        }

        public StackTracker BStackTracker
        {
            get { return HttpContext.Current.Session[STACKTRACKER] as StackTracker; }
        }
        public void ResetStakcCounter()
        {
            BackStackDepth = 1;
        }
        private SessionManager()
        {
            HttpContext.Current.Session.Add(SessionManager.BACKSTACK, new List<string>());
            ResetStakcCounter();
            HttpContext.Current.Session[STACKTRACKER] = new StackTracker();
            HttpContext.Current.Session[IGNORE_THIS_ACTION] = false;
        }
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
                if(HttpContext.Current.Session[RESPONSIVE] == null)
                {
                    if(HttpContext.Current.Request.UserAgent == Responsive.DELFI_AGENT)
                    {
                        HttpContext.Current.Session[RESPONSIVE] = new html4();
                    }
                    else
                    {
                        HttpContext.Current.Session[RESPONSIVE] = new html5();
                    }
                }
                return (Responsive)HttpContext.Current.Session[RESPONSIVE];
            }
        }
    }


}