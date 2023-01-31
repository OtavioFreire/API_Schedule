using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Extensions.Logging;

namespace API_Schedule
{
    public static class CustomExtensionMethods
    {
        public static IServiceCollection AddLoggerFactory(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerFactory>(services => new SerilogLoggerFactory(Log.Logger));
            return services;
        }

        public static IServiceCollection AddCustomSwagger(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "API Super Agenda",
                    Version = "v1",
                    Description = ""
                });
            });

            return services;
        }

        public static IServiceCollection AddCustomMvc(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                        .WithOrigins("*")
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });

            services
                    .AddMvc(config => config.Filters.Add(new ExceptionHandlingAttribute()))
                    .AddControllersAsServices();

            return services;
        }

        public class ExceptionHandlingAttribute : ExceptionFilterAttribute
        {
            public override void OnException(ExceptionContext context)
            {
                base.OnException(context);

                Log.Logger.Error($"{context.Exception.Message}\n{context.Exception.StackTrace}");
            }
        }
    }
}
