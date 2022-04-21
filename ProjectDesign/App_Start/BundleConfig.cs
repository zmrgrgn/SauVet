using System.Web;
using System.Web.Optimization;

namespace ProjectDesign
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            #region Template Design

            bundles.Add(new ScriptBundle("~/template/js").Include(
                "~/Scripts/jquery.js",
                "~/Scripts/popper.js",
                "~/Scripts/bootstrap.js",
                "~/Scripts/perfect-scrollbar.js",
                "~/Scripts/menu.js",
                "~/Scripts/main.js",
                "~/Scripts/dashboards-analytics.js",
                "~/Scripts/config.js",
                "~/Scripts/helpers.js",
                       "~/Scripts/apexcharts.js"));

            bundles.Add(new StyleBundle("~/template/css").Include(
                     "~/Content/css/theme-default.css",
                     "~/fonts/boxicons.css",
                     "~/Content/demo.css",
                     "~/Content/css/perfect-scrollbar.css",
                     "~/Content/css/apex-charts.css",
                     "~/Content/css/core.css"));

            #endregion
        }
    }
}
