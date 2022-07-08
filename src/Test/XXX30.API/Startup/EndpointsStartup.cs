﻿// <auto-generated>
//  UseEndpoints   
// </auto-generated>

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.NetPro;

namespace NetPro.Web.Api
{
    /// <summary>
    /// Endpoints 
    /// </summary>
    public class EndpointsStartup : INetProStartup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="typeFinder"></param>
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration, ITypeFinder typeFinder)
        {

        }

        /// <summary>
        /// Endpoints请求管道;
        /// Order执行顺序保证在RoutingStartup（200）之后即可
        /// </summary>
        /// <param name="application"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder application, IWebHostEnvironment env)
        {
            application.UseEndpoints(s =>
            {
                s.MapControllers();
            });
        }

        /// <summary>
        /// UseEndpoints can be executed after RoutingStartup
        /// </summary>
        public double Order { get; set; } = 1000;
    }
}
