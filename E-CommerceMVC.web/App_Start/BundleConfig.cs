using System.Web;
using System.Web.Optimization;

namespace E_CommerceMVC.web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css").Include(
          "~/Content/templates/fashe/vendor/bootstrap/css/bootstrap.min.css",
          "~/Content/templates/fashe/fonts/font-awesome-4.7.0/css/font-awesome.min.css",
          "~/Content/templates/fashe/fonts/themify/themify-icons.css",
          "~/Content/templates/fashe/fonts/Linearicons-Free-v1.0.0/icon-font.min.css",
          "~/Content/templates/fashe/fonts/elegant-font/html-css/style.css",
          "~/Content/templates/fashe/vendor/animate/animate.css",
          "~/Content/templates/fashe/vendor/css-hamburgers/hamburgers.min.css",
          "~/Content/templates/fashe/vendor/animsition/css/animsition.min.css",
          "~/Content/templates/fashe/vendor/select2/select2.min.css",
          "~/Content/templates/fashe/vendor/daterangepicker/daterangepicker.css",
          "~/Content/templates/fashe/vendor/slick/slick.css",
          "~/Content/templates/fashe/vendor/lightbox2/css/lightbox.min.css",
          "~/Content/templates/fashe/css/util.css",
          "~/Content/templates/fashe/css/main.css"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                      "~/Content/templates/fashe/vendor/jquery/jquery-3.2.1.min.js",
                      "~/Content/templates/fashe/vendor/animsition/js/animsition.min.js",
                      "~/Content/templates/fashe/vendor/bootstrap/js/popper.js",
                      "~/Content/templates/fashe/vendor/bootstrap/js/bootstrap.min.js",
                      "~/Content/templates/fashe/vendor/select2/select2.min.js",
                      "~/Content/templates/fashe/vendor/slick/slick.min.js",
                      "~/Content/templates/fashe/js/slick-custom.js",
                      "~/Content/templates/fashe/vendor/countdowntime/countdowntime.js",
                      "~/Content/templates/fashe/vendor/lightbox2/js/lightbox.min.js",
                      "~/Content/templates/fashe/vendor/sweetalert/sweetalert.min.js",
                      "~/Content/templates/fashe/vendor/parallax100/parallax100.js",
                      "~/Content/templates/fashe/js/main.js"));


        }
    }
}
