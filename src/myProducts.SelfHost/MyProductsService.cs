﻿using Microsoft.Owin.Hosting;
using MyProducts.Hosting;
using MyProducts.SelfHost.Properties;
using System;
using System.ServiceProcess;

namespace MyProducts.SelfHost
{
    partial class MyProductsService : ServiceBase
    {
        private static IDisposable server;

        public MyProductsService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            server = WebApp.Start<SelfHostStartup>(Settings.Default.BaseUrl);
        }

        protected override void OnStop()
        {
            if (server != null)
            {
                server.Dispose();
            }
        }

        public void InteractiveStart(string[] args)
        {
            OnStart(args);
        }

        public void InteractiveStop()
        {
            OnStop();
        }
    }
}
