using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Swagger;
using TodoApi.Models;

namespace TodoApi
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
            //将数据库上下文添加到DI容器
            services.AddDbContext<TodoContext>(opt =>
                opt.UseInMemoryDatabase("TodoList")); //指定数据库上下文将使用内存中数据库

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);


            //注册Swagger中间件，定义一个或多个Swagger文档
            services.AddSwaggerGen(c =>
            {
                //传递给AddSwaggerGen方法的配置操作 添加作者，许可证和说明等信息
                c.SwaggerDoc("v1", new Info
                {
                    Title = "ToDo API",
                    Version = "v1",
                    Description = "A simple example ASP.NET Core Web API",
                    TermsOfService = "None",
                    Contact = new Contact
                    {
                        Name = "Shayne Boyer",
                        Email = string.Empty,
                        Url = "Https://twitter.com/spboyer"
                    },
                    License = new License
                    {
                        Name = "Use under LICX",
                        Url = "https://example.com/license"
                    }
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //启动中间件以将生成的Swagger作为JSON端点提供服务
            app.UseSwagger();
            //调用启用了静态文件中间件
            //指定Swagger JSON端点
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                //设置应用跟(http://localhost:<port>/)提供Swagger UI
                c.RoutePrefix=string.Empty;
            });


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
