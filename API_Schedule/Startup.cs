using API_Schedule.Application.Interface;
using API_Schedule.Application.Receiver;
using API_Schedule.Infrastucture.Interface;
using API_Schedule.Infrastucture.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace API_Schedule
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
            services
               .AddLoggerFactory()
               .AddCustomSwagger(Configuration)
               .AddCustomMvc()
               .AddControllers()
               .AddNewtonsoftJson(options =>
               {
                   options.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
                   options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
               });

            services.AddScoped<MetaReceiver, MetaReceiver>();
            services.AddScoped<MetaRepository, MetaRepository>();
            services.AddScoped<EventoReceiver, EventoReceiver>();
            services.AddScoped<EventoRepository, EventoRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
                app.UseHsts();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            UseSwagger(app);
        }

        private static void UseSwagger(IApplicationBuilder app)
        {
            app.UseSwagger()
                .UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint($"/swagger/v1/swagger.json", "Integration.GPCS.API V1");
                    c.OAuthClientId("Integration.GPCS.API");
                    c.OAuthAppName("Integration GPCS API");
                });
        }
    }
}
