﻿using Owin;

namespace MyProducts.Hosting
{
    public class SelfHostStartup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseFileServer(opts =>
            {
                opts.WithRequestPath("");
                opts.WithPhysicalPath("client");
                opts.WithDefaultFileNames("index.html");
            });
            app.UseFileServer(opts =>
            {
                opts.WithRequestPath("/images");
                opts.WithPhysicalPath("images");
            });

            var startup = new Startup();
            startup.Configuration(app);
        }
    }
}