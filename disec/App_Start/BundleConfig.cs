using System.Web;
using System.Web.Optimization;

namespace disec
{
    public class BundleConfig
    {
        // Para obtener más información sobre Bundles, visite http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            //// preparado para la producción y podrá utilizar la herramienta de compilación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));

            //Bootstrap 3.3.7
            bundles.Add(new StyleBundle("~/Content/bootstrapCSS").Include(
                      "~/Content/bootstrap/dist/css/bootstrap.min.css"));

            //Font Awesome
            bundles.Add(new StyleBundle("~/Content/fontawesomeCSS").Include(
                      "~/Content/font-awesome/css/font-awesome.min.css"));

            //Ionicons
            bundles.Add(new StyleBundle("~/Content/ioniconsCSS").Include(
                      "~/Content/Ionicons/css/ionicons.min.css"));

            //Theme style
            bundles.Add(new StyleBundle("~/Content/AdminLTECSS").Include(
                      "~/Content/css/AdminLTE.min.css"));

            //allskinsCSS
            bundles.Add(new StyleBundle("~/Content/allskinsCSS").Include(
                      "~/Content/css/skins/_all-skins.min.css"));

            //morris.css
            bundles.Add(new StyleBundle("~/Content/morrisCSS").Include(
                      "~/Content/morris.js/morris.css"));

            //jquery-jvectormap.css
            bundles.Add(new StyleBundle("~/Content/jqueryjvectormapCSS").Include(
                      "~/Content/jvectormap/jquery-jvectormap.css"));

            //bootstrap-datepicker.css
            bundles.Add(new StyleBundle("~/Content/bootstrapdatepickerCSS").Include(
                      "~/Content/bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css"));

            //daterangepicker.css
            bundles.Add(new StyleBundle("~/Content/daterangepickerCSS").Include(
                      "~/Content/bootstrap-daterangepicker/daterangepicker.css"));

            //bootstrap3-wysihtml5.css
            bundles.Add(new StyleBundle("~/Content/bootstrap3wysihtml5CSS").Include(
                      "~/Content/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css"));

            //blue.css
            bundles.Add(new StyleBundle("~/Content/blueCSS").Include(
                      "~/Content/iCheck/square/blue.css"));

            // DataTables-- >
            bundles.Add(new StyleBundle("~/Content/bootstrapdataTablesCSS").Include(
                      "~/Content/datatables.net-bs/css/dataTables.bootstrap.min.css"));

            /************** PLANTILLA JS ************/

            //jquery.JS
            bundles.Add(new ScriptBundle("~/bundles/jqueryJS").Include(
                      "~/Scripts/jquery/dist/jquery.min.js"));

            //jquery-ui.JS
            bundles.Add(new ScriptBundle("~/bundles/jqueryuiJS").Include(
                      "~/Scripts/jquery-ui/jquery-ui.min.js"));

            //bootstrap.JS
            bundles.Add(new ScriptBundle("~/bundles/bootstrapJS").Include(
                      "~/Content/bootstrap/dist/js/bootstrap.min.js"));

            //raphael.JS
            bundles.Add(new ScriptBundle("~/bundles/raphaelJS").Include(
                      "~/Scripts/raphael/raphael.min.js"));

            //morris.JS
            bundles.Add(new ScriptBundle("~/bundles/morrisJS").Include(
                      "~/Content/morris.js/morris.min.js"));

            //jquery.sparkline.JS
            bundles.Add(new ScriptBundle("~/bundles/jquerysparklineJS").Include(
                      "~/Scripts/jquery-sparkline/dist/jquery.sparkline.min.js"));

            //jquery.sparkline.JS
            bundles.Add(new ScriptBundle("~/bundles/jquerysparklineJS").Include(
                      "~/Scripts/jvectormap/jquery-jvectormap-1.2.2.min.js"));

            //jqueryjvectormapworldmillen.JS
            bundles.Add(new ScriptBundle("~/bundles/jqueryjvectormapworldmillenJS").Include(
                      "~/Scripts/jvectormap/jquery-jvectormap-world-mill-en.js"));

            //jqueryknob.JS
            bundles.Add(new ScriptBundle("~/bundles/jqueryknobJS").Include(
                      "~/Scripts/jquery-knob/dist/jquery.knob.min.js"));

            //jqueryknob.JS
            bundles.Add(new ScriptBundle("~/bundles/jqueryknobJS").Include(
                      "~/Scripts/jquery-knob/dist/jquery.knob.min.js"));

            //moment.JS
            bundles.Add(new ScriptBundle("~/bundles/momentJS").Include(
                      "~/Scripts/moment/min/moment.min.js"));

            //daterangepicker.JS
            bundles.Add(new ScriptBundle("~/bundles/daterangepickerJS").Include(
                      "~/Content/bootstrap-daterangepicker/daterangepicker.js"));

            //bootstrap-datepicker.JS
            bundles.Add(new ScriptBundle("~/bundles/bootstrapdatepickerJS").Include(
                      "~/Content/bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js"));

            //bootstrap3-wysihtml5.all.JS
            bundles.Add(new ScriptBundle("~/bundles/bootstrap3wysihtml5allJS").Include(
                      "~/Content/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js"));

            //jquery.slimscroll.js
            bundles.Add(new ScriptBundle("~/bundles/jqueryslimscrollJS").Include(
                      "~/Scripts/jquery-slimscroll/jquery.slimscroll.min.js"));

            //fastclick.js
            bundles.Add(new ScriptBundle("~/bundles/fastclickJS").Include(
                      "~/Scripts/fastclick/lib/fastclick.js"));

            //adminlte.js
            bundles.Add(new ScriptBundle("~/bundles/adminlteJS").Include(
                      "~/Scripts/js/adminlte.min.js"));

            //dashboard.js
            bundles.Add(new ScriptBundle("~/bundles/dashboardJS").Include(
                      "~/Scripts/js/pages/dashboard.js"));

            //dashboard.js
            bundles.Add(new ScriptBundle("~/bundles/demoJS").Include(
                      "~/Scripts/js/demo.js"));

            //icheck.js
            bundles.Add(new ScriptBundle("~/bundles/icheckJS").Include(
                      "~/Content/iCheck/icheck.min.js"));

            //datatables.net.js
            bundles.Add(new ScriptBundle("~/bundles/jquerydataTablesJS").Include(
                      "~/Scripts/datatables.net/js/jquery.dataTables.min.js",
                      "~/Content/datatables.net-bs/js/dataTables.bootstrap.min.js"));

            //datatables.net-bs.js
            bundles.Add(new ScriptBundle("~/bundles/dataTablesbootstrapJS").Include(
                      "~/Content/datatables.net-bs/js/dataTables.bootstrap.min.js"));
        }
    }
}
