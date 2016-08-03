using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Winkompass_Mobil.Filters
{
    //public class TrackingFilter : ActionFilterAttribute, IActionFilter
    //{
    //    //currently if the last recorded place the user was, was on the front page, this constant is the url that will pop up
    //    public const string FRONT_PAGE = "~//?agoback=1";
    //    //and this is what the url starts with (more generic and future proof)
    //    public const string FRONT_PAGE_BEGIN = "~//";
    //    //Could not find the string name in t4mvc for Action (MVC.HOME.INDEX().name or something)
    //    public const string INDEX_NAME = "Index";
    //    private string absoluteStartUrl
    //    {
    //        get { return HttpContext.Current.Request.Url.Host + "/"; }
    //    }
    //    void IActionFilter.OnActionExecuted(ActionExecutedContext filterContext)
    //    {
    //        string requestUrl = filterContext.HttpContext.Request.Url.AbsoluteUri;
    //        string controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
    //        string action = filterContext.ActionDescriptor.ActionName;
    //        int currentSessionDepth = Math.Max(0, Math.Min(SessionManager.Manager.BackStackList.Count - SessionManager.Manager.BackStackDepth, SessionManager.Manager.BackStackList.Count - 1));
    //        //makes sure that some urls doesn't get saved in teh backtracking list of urls, the two lines describe the conditions for the url to be ignored
    //        //listen ikke er tom, den nuværende hentede side stemmer overens med den side brugeren requester, special situation when home/index is called
    //        //if it's an ajax request, if it's a request for a partial view
    //        if (SessionManager.Manager.BackStackList.Count > 0
    //        && ((SessionManager.Manager.BackStackList[currentSessionDepth].Contains(controller + "/" + action))
    //        || (
    //            //the url saved in the list does not contain the controller&action name - if the front page is saved in the tracking system the home/index doesn't show up in the url
    //            MVC.Home.Name == controller
    //            && INDEX_NAME == action
    //            && SessionManager.Manager.BackStackList[currentSessionDepth].StartsWith(FRONT_PAGE_BEGIN)
    //        )
    //        || filterContext.HttpContext.Request.IsAjaxRequest()
    //        || filterContext.Result is PartialViewResult
    //        )
    //    )
    //        {//starting if block 
    //            //keep this nested, if it's put into the initial if sentence the counter will reset making it only possible to go back once
    //            if (SessionManager.Manager.BackStackDepth > 1)
    //            {
    //                resetCounterAtCurrent();
    //            }
                
    //        }//manual override
    //        else if (SessionManager.Manager.IgnoreAction)
    //                SessionManager.Manager.IgnoreAction = false;
    //        /*if (SessionManager.Manager.BackStackList[SessionManager.Manager.BackStackList.Count-1].Contains(filterContext.ActionDescriptor.ControllerDescriptor.ControllerName + "/" + filterContext.ActionDescriptor.ActionName))
    //        {
    //            resetCounterAtCurrent();
    //        }*/
    //        else if (filterContext.RequestContext.HttpContext.Request.Params[StackTracker.BACKB_TEXT] != null &&
    //            filterContext.RequestContext.HttpContext.Request.Params[StackTracker.BACKB_TEXT] == StackTracker.BACKB_VALUE &&
    //            StackTracker.BACKTRACK_SIZE + 1 > SessionManager.Manager.BackStackDepth)
    //        {
    //            SessionManager.Manager.BackStackDepth++;
    //        }
    //        else
    //        {
    //            if (SessionManager.Manager.BackStackList.Count > StackTracker.BACKTRACK_SIZE)
    //            {
    //                SessionManager.Manager.BackStackList.RemoveAt(0);
    //            }
    //            if (SessionManager.Manager.BackStackDepth > 1)
    //            {
    //                resetCounterAtCurrent();
    //            }

    //            string reconstructuri = filterContext.HttpContext.Request.RawUrl;

    //            string id = "";
    //            if (filterContext.RouteData.Values["id"] != null && !reconstructuri.Contains(filterContext.RouteData.Values["id"].ToString()))
    //                id += "/" + filterContext.RouteData.Values["id"] + "/";

    //            UrlHelper url = new UrlHelper(filterContext.RequestContext);
    //            reconstructuri = "~" + url.Action(action, controller) + id + (
    //                filterContext.HttpContext.Request.QueryString.Count > 0 ?
    //                "?" + filterContext.HttpContext.Request.QueryString + "&" + StackTracker.BACKB_TEXT + "=" + StackTracker.BACKB_VALUE :
    //                "?" + filterContext.HttpContext.Request.QueryString + StackTracker.BACKB_TEXT + "=" + StackTracker.BACKB_VALUE);
    //            SessionManager.Manager.BackStackList.Add(reconstructuri);
    //        }

    //    }
    //    private void resetCounterAtCurrent()
    //    {
    //        SessionManager.Manager.BackStackList.RemoveRange(SessionManager.Manager.BackStackList.Count - SessionManager.Manager.BackStackDepth + 1, SessionManager.Manager.BackStackDepth - 1);
    //        SessionManager.Manager.ResetStakcCounter();
    //    }


    //}
}