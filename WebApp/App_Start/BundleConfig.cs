﻿using System.Data.Entity.Infrastructure;
using System.Web;
using System.Web.Optimization;

namespace WebApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-{version}.js",
                    "~/Scripts/jquery.dataTables.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/dataTables.bootstrap.min.css"));

            bundles.Add(new ScriptBundle("~/current_rates_js").Include(
                "~/Scripts/CurrentRates/js/Rates.js"));

            bundles.Add(new ScriptBundle("~/user_rates_js").Include(
                "~/Scripts/UserRates/js/UserRates.js"));

            bundles.Add(new ScriptBundle("~/calculator_js").Include(
                "~/Scripts/Calculator/js/Calculator.js"));
        }
    }
}
