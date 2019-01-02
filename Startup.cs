using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasinoWeb.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CasinoWeb
{
	public class Startup
	{
		protected IConfigurationRoot Configuration;

		public Startup()
		{
			var configurationBuilder = new ConfigurationBuilder();
			configurationBuilder.AddXmlFile("appsettings.xml");
			Configuration = configurationBuilder.Build();
		}
		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<CDbContext>(builder =>
			{
				var cs = Configuration["ConnectionStrings:DefaultConnection"];
				builder.UseSqlServer(cs);
			});
			services.AddIdentity<IdentityUser, IdentityRole>()
				.AddEntityFrameworkStores<CDbContext>();
			services.AddMvc();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseAuthentication();
			app.UseStaticFiles();
			app.UseMvcWithDefaultRoute();
		}
	}
}
