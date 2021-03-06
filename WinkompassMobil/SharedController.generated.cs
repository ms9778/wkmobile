// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace Winkompass_Mobil.Controllers
{
    public partial class SharedController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public SharedController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected SharedController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ScanWithTarget()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ScanWithTarget);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public SharedController Actions { get { return MVC.Shared; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Shared";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Shared";
        [GeneratedCode("T4MVC", "2.0")]
        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string ScanWithTarget = "ScanWithTarget";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string ScanWithTarget = "ScanWithTarget";
        }


        static readonly ActionParamsClass_ScanWithTarget s_params_ScanWithTarget = new ActionParamsClass_ScanWithTarget();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ScanWithTarget ScanWithTargetParams { get { return s_params_ScanWithTarget; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ScanWithTarget
        {
            public readonly string reg = "reg";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string _Layout = "_Layout";
                public readonly string NormalScan = "NormalScan";
                public readonly string NormalScanJS = "NormalScanJS";
                public readonly string ScanWithTarget = "ScanWithTarget";
            }
            public readonly string _Layout = "~/Views/Shared/_Layout.cshtml";
            public readonly string NormalScan = "~/Views/Shared/NormalScan.cshtml";
            public readonly string NormalScanJS = "~/Views/Shared/NormalScanJS.cshtml";
            public readonly string ScanWithTarget = "~/Views/Shared/ScanWithTarget.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_SharedController : Winkompass_Mobil.Controllers.SharedController
    {
        public T4MVC_SharedController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ScanWithTargetOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Winkompass_Mobil.Models.ScanItemModel reg);

        [NonAction]
        public override System.Web.Mvc.ActionResult ScanWithTarget(Winkompass_Mobil.Models.ScanItemModel reg)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ScanWithTarget);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "reg", reg);
            ScanWithTargetOverride(callInfo, reg);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
