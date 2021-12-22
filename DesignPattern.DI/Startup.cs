using DesignPattern.DI.Models;
using DesignPattern.DI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.DI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddTransient<IPersonService, TeacherService>();
            //services.AddTransient<IPersonService, StudentService>();

            services.AddSingleton<StudentService>();
            services.AddSingleton<TeacherService>();

            services.AddTransient<Func<PersonType, IPersonService>>(serviceProvider=>key=> {
                switch (key)
                {
                    case PersonType.Student:
                        return serviceProvider.GetService<StudentService>();
                    case PersonType.Teacher:
                        return serviceProvider.GetService<TeacherService>();
                    default:
                        return serviceProvider.GetService<TeacherService>();
                }
            });

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
