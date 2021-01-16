using System.Web;
using System.Web.Optimization;

namespace E_CommerceMVC.web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Admin Dashboard bundles
            bundles.Add(new StyleBundle("~/bundles/dashboard/css").Include(
          //"~/Content/templates/sb-admin2/vendor/fontawesome-free/css/all.min.css",
          "~/Content/templates/sb-admin2/css/sb-admin-2.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/dashboard/js").Include(
                      "~/Content/templates/sb-admin2/vendor/jquery/jquery.min.js",
                      "~/Content/templates/sb-admin2/vendor/bootstrap/js/bootstrap.bundle.min.js",
                      "~/Content/templates/sb-admin2/vendor/jquery-easing/jquery.easing.min.js",
                      "~/Content/templates/sb-admin2/js/sb-admin-2.min.js"
                      //"~/Content/templates/sb-admin2/vendor/chart.js/Chart.min.js",
                      //"~/Content/templates/sb-admin2/js/demo/chart-area-demo.js",
                      //"~/Content/templates/sb-admin2/js/demo/chart-pie-demo.js"
                      ));

            //User Frontend Bundles

            bundles.Add(new StyleBundle("~/bundles/css").Include(
          "~/Content/templates/fashe/vendor/bootstrap/css/bootstrap.min.css",
          //"~/Content/templates/fashe/fonts/font-awesome-4.7.0/css/font-awesome.min.css",
          //"~/Content/templates/fashe/fonts/themify/themify-icons.css",
          //"~/Content/templates/fashe/fonts/Linearicons-Free-v1.0.0/icon-font.min.css",
          //"~/Content/templates/fashe/fonts/elegant-font/html-css/style.css",
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
