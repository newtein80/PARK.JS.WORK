using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PARK.JS.WORK.Data;
using PARK.JS.WORK.Models.ApplicationModel;

[assembly: HostingStartup(typeof(PARK.JS.WORK.Areas.Identity.IdentityHostingStartup))]
namespace PARK.JS.WORK.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}