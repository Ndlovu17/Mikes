using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MvcApp.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/styles")
               .Include("~/content/styles/bootstrap.css")
               .Include("~/content/styles/site.css"));


            bundles.Add(new ScriptBundle("~/scripts")
            .Include("~/scripts/jquery-3.2.1.js")
            .Include("~/scripts/jquery.validate.js")
            .Include("~/scripts/jquery.unobtrusive-ajax.js")
            .Include("~/scripts/bootstrap.js"));
        }
    }
}