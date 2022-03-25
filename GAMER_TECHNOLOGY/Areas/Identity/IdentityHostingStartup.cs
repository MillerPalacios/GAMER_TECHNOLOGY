﻿using System;
using GAMER_TECHNOLOGY.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(GAMER_TECHNOLOGY.Areas.Identity.IdentityHostingStartup))]
namespace GAMER_TECHNOLOGY.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<GAMER_TECHNOLOGYContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SqlDBContext")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<GAMER_TECHNOLOGYContext>();
            });
        }
    }
}