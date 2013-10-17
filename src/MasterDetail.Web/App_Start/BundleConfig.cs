﻿using System.Web.Optimization;

namespace MasterDetail.Web.App_Start
{
    public static class BundleConfig
    {
        public static void Register(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/app/js-lib")
                 .Include("~/app/js/lib/script.js")
                .Include("~/app/js/lib/jquery-2.0.1.js")
                .Include("~/app/js/lib/toastr.js")
                .Include("~/app/js/lib/spin.js")
                .Include("~/app/js/lib/kendo.all.js")
                .Include("~/app/js/lib/bootstrap*")
                .Include("~/app/js/lib/angular*")
                .Include("~/app/js/lib/ui-bootstrap-tpls-0.5.0.js")
                .Include("~/app/js/lib/jquery.signalR*")
                .Include("~/app/js/lib/lawnchair-0.6.1.js")
                .Include("~/app/js/lib/log4javascript.js")
                .Include("~/app/js/lib/iscroll.js")
                .Include("~/app/js/lib/ng-scrollable.js")
                .Include("~/app/js/lib/ngStorage.js")
                .Include("~/app/js/lib/imageupload.js")
                .Include("~/app/js/lib/fastclick.js")
                );

            bundles.Add(new StyleBundle("~/app/css/common")
                .Include("~/app/css/bootstrap*")
                .Include("~/app/css/toastr.css")
                );
            bundles.Add(new StyleBundle("~/app/css/kendo/css")
                .Include("~/app/css/kendo/kendo.*")
                );
            bundles.Add(new StyleBundle("~/app/css/others")
                .Include("~/app/css/font-awesome.css")
                .Include("~/app/css/angular-carousel.css")
                );
            bundles.Add(new StyleBundle("~/app/css/app")
                .Include("~/app/css/app.css")
                );
        }
    }
}