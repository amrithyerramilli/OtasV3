﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(OtasV3.Startup))]
namespace OtasV3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
