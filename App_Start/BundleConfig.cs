using System.Web;
using System.Web.Optimization;

namespace Vidly
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/_layout.css",
                      "~/Content/Home.css",
                      "~/Content/Employee.css",
                      "~/Content/emp_form.css",
                      "~/Content/details.css",
                      "~/Content/bootstrap_default.css"));
        }
    }
}
