using System;
using AudioStream.Areas.Identity.Data;
using AudioStream.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(AudioStream.Areas.Identity.IdentityHostingStartup))]
namespace AudioStream.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AudioStream2Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AudioStream2ContextConnection")));

                services.AddDefaultIdentity<AudioStreamUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<AudioStream2Context>();
            });
        }
    }
}