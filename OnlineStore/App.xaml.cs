﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OnlineStore.Data;
using OnlineStore.Services;
using OnlineStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace OnlineStore
{
    public partial class App : Application
    {
        private static IHost _Host;
        public static IHost Host => _Host 
            ??= Programm.CreateHostBuilder(Environment.GetCommandLineArgs())
            .Build();
        public static IServiceProvider Service => Host.Services;
        internal static void ConfigureServices(HostBuilderContext host, IServiceCollection services) => services
            .AddDatabase(host.Configuration.GetSection("Database"))
            .AddServices()
            .AddViewModels()
            
            ;
        protected override async void OnStartup(StartupEventArgs e)
        {
            var host = Host;


            base.OnStartup(e);
            await host.StartAsync();
        }
        protected override async void OnExit(ExitEventArgs e)
        {
            using var host = Host;
            base.OnExit(e);
            await host.StopAsync();
        }
    }
}
