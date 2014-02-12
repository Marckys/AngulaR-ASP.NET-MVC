using System.Web;
using System.Web.Optimization;

namespace WebClient
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                        "~/Scripts/libs/angular/angular.js",
                         "~/Content/bootstrap/js/bootstrap.min.js",
                           "~/Content/bootstrap/js/angular-bootstrap.min.js",
                         "~/Scripts/libs/angular/ui-bootstrap-0.6.0.js",
                          "~/Scripts/libs/angular/ui-bootstrap-tpls-0.6.0.min.js",
                        "~/Scripts/app/main.js",
                        "~/Scripts/app/services/dataContextService.js",
                        "~/Scripts/app/directives/autoComplete.js",
                        "~/Scripts/app/Controllers/ListaCtrl.js",
                        "~/Scripts/app/Controllers/DetalleCtrl.js",
                        "~/Scripts/app/Controllers/EditCtrl.js",
                        "~/Scripts/app/Filters/upper.js"
                       ));



            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/libs/jquery/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/libs/jquery/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/libs/jquery/jquery.unobtrusive*",
                        "~/Scripts/libs/jquery/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/libs/modernizr/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/site.css",
                "~/Content/bootstrap/css/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}