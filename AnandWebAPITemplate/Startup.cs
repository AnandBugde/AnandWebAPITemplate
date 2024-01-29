using Littera.Web.Middleware.SecuringWebApiUsingApiKey.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnandWebAPITemplate
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

            services.AddControllers();
            // Use belwo code to Configuration of connecting string
            //   services.AddDbContext<Littera.Data.Feedback.Models.FeedbackContext>(options =>
            //  options.UseSqlServer(Configuration.GetConnectionString("YojnaDatabase")).LogTo(new CustomLogger().FeedbackLog)



            //);

            services.AddControllers().AddNewtonsoftJson(
              options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {
                        builder.WithOrigins(Configuration.GetSection("CORSHost").Get<String[]>())
                                            .AllowAnyHeader()
                                            .AllowAnyMethod();
                    });


            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "AnandWebAPITemplate", Version = "v1" });
                c.OperationFilter<AddRequiredHeaderParameter>();
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }

            // Virtual directory changes are done to publish it with the sub domain
            string VirDir = Configuration.GetSection("VirDirectory").Value;
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint(VirDir + "/swagger/v1/swagger.json", "Anand Template API v1"));

            app.UseHttpsRedirection();
            app.UseCors();
            app.UseRouting();

            app.UseAuthorization();
            app.UseMiddleware<ApiKeyMiddleware>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
