using Furniture_assembly_BusinessLogic.BusinessLogics;
using Furniture_assembly_BusinessLogic.HelperModels;
using Furniture_assembly_BusinessLogic.Interfaces;
using Furniture_assembly_DatabaseImplement.Implements;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Furniture_assembly_RestApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {

            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IClientStorage, ClientStorage>();
            services.AddTransient<IOrderStorage, OrderStorage>();
            services.AddTransient<IFurnitureStorage, FurnitureStorage>();
            services.AddTransient<IMessageInfoStorage, MessageInfoStorage>();
            services.AddTransient<OrderLogic>();
            services.AddTransient<ClientLogic>();
            services.AddTransient<MailLogic>();
            services.AddTransient<FurnitureLogic>();
            MailLogic.MailConfig(new MailConfig
            {
                SmtpClientHost = "smpt.gmail.com",
                SmtpClientPort = 587,
                MailLogin = "tplab94@gmail.com",
                MailPassword = "12345qwert67",
            });
            services.AddControllers().AddNewtonsoftJson();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
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
