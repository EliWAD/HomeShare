using System.Web;
using System.Web.Optimization;

namespace HomeShareMVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/css/bootstrap/bootstrap.css",
                        "~/Content/css/owl-carousel/owl.carousel.css",
                        "~/Content/css/owl-carousel/owl.theme.css",
                        "~/Content/css/slitslider/custom.css",
                        "~/Content/css/slitslider/style.css",
                        "~/Content/css/bootstrap.css",
                        "~/Content/css/bootstrap.min.css",
                        "~/Content/css/Site.css",
                        "~/Content/css/style.css"
                ));
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/slitslider/jquery.slitslider.js",
                        "~/Scripts/slitslider/jquery.ba-cond.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*", 
                        "~/Scripts/slitslider/modernizr.custom.79639.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/bootstrap/bootstrap.js", 
                      "~/Scripts/respond.min.js",                                
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Customs").Include(
                        "~/Scripts/owl-carousel/owl.carousel.js",
                        "~/Scripts/script.js"));
        }
    }
}
