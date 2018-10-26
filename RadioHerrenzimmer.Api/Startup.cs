// <copyright file="Startup.cs" company="Radio Herrenzimmer">
// Copyright (c) Radio Herrenzimmer. All rights reserved.
// </copyright>

namespace RadioHerrenzimmer.Api
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using NJsonSchema;
    using NSwag.AspNetCore;

    /// <summary>
    /// Wires up the application and all its services
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Application configuration
        /// </summary>
        private readonly IConfiguration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:RadioHerrenzimmer.Api.Startup"/> class.
        /// </summary>
        /// <param name="configuration">Application configuration</param>
        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        /// <summary>
        /// Adds services to the application
        /// </summary>
        /// <param name="services">The collection to add the services to</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services
                 .AddMvc()
                 .AddJsonOptions(options =>
                 {
                     options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                     options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                 })
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddSwagger();
        }

        /// <summary>
        /// Configures the HTTP request pipeline
        /// </summary>
        /// <param name="app">The application</param>
        /// <param name="env">Hosting environment of the application</param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseSwaggerUi3WithApiExplorer(settings =>
                {
                    settings.GeneratorSettings.DefaultPropertyNameHandling = PropertyNameHandling.CamelCase;
                    settings.SwaggerUiRoute = this.configuration["Application:DocumentationRoute"];
                    settings.GeneratorSettings.Title = this.configuration["Application:Name"];
                });
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
