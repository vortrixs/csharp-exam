using BusinessLogic.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;

namespace FitnessWebApi
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddEntityFrameworkSqlite().AddDbContext<FitnessApiContext>();

			services.AddControllersWithViews().AddNewtonsoftJson(
				options => options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore
			);

			services.AddSwaggerDocument(config =>
			{
				config.PostProcess = document =>
				{
					document.Info.Version = "v1";
					document.Info.Title = "Fitness Membership API";
					document.Info.Description = "A simple ASP.NET Core web API";
					document.Info.TermsOfService = "None";
					document.Info.Contact = new NSwag.OpenApiContact
					{
						Name = "Hans Erik Jepsen",
						Email = "hanserikjepsen@hotmail.com",
						Url = "http://he-jepsen.dk"
					};
				};
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseOpenApi();
			app.UseSwaggerUi3();

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
