using System.Web;
using System.Web.Optimization;

namespace Disclosure
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Custom Style
            bundles.Add(new StyleBundle("~/Content/custom").Include(
                 "~/Content/assets/css/main.css",
                 "~/Content/assets/css/font-awesome.css",
                "~/Content/assets/css/fonts.css"
            ));
        }
    }
}
