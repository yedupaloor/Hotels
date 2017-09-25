using System.Web.Optimization;

namespace Hotels
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
            "~/Scripts/angular.min.js", 
            "~/Scripts/loading-bar.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/hotels").Include(
            "~/Scripts/custom/app.js",
            "~/Scripts/custom/FromWebApi.js",
            "~/Scripts/custom/HotelsController.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/loading-bar.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/site.css",
                      "~/Content/custom.css"));

        }
    }
}
