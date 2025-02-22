﻿using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore
{
    static class Programm
    {
        [STAThread]
        static void Main(string[] args)
        {
            var app = new App();
            app.InitializeComponent();
            app.Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] agrs) => Host
            .CreateDefaultBuilder(agrs)
            .ConfigureServices(App.ConfigureServices);
    }
}
