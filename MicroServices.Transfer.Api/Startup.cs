using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MicroServices.Domain.Core.Bus;
using MicroServices.Infra.IoC;
using MicroServices.Transfer.Data.Context;
using MicroServices.Transfer.Domain.EventHandler;
using MicroServices.Transfer.Domain.Events;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace MicroServices.Transfer.Api
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
			services.AddDbContext<TransferDbContext>(options => {
				options.UseSqlServer(Configuration.GetConnectionString("TransferDbConnection"));
			});

			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new Info { Title = "Transfer MicroService", Version = "v1" });
			});

			services.AddMediatR(typeof(Startup));

			RegisterServices(services);
		}

		private void RegisterServices(IServiceCollection services)
		{
			DependencyContainer.RegisterServices(services);
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseHsts();
			}

			app.UseHttpsRedirection();

			app.UseSwagger();

			app.UseSwaggerUI(options =>
			{
				options.SwaggerEndpoint("/swagger/v1/swagger.json", "Transfer MicroService V1");
			});

			app.UseMvc();
			ConfigureEventBus(app);
		}

		private  void ConfigureEventBus(IApplicationBuilder app)
		{
			var eventBus = app.ApplicationServices.GetRequiredService<IEventBus>();
			eventBus.Subscribe<TransferCreatedEvent, TransferEventHandler>();
		}
	}
}
