// <copyright file="Program.cs" company="Radio Herrenzimmer">
// Copyright (c) Radio Herrenzimmer. All rights reserved.
// </copyright>

namespace RadioHerrenzimmer.Api
{
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;

    /// <summary>
    /// The application wrapper
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Entry point of this application
        /// </summary>
        /// <param name="args">Command-line arguments</param>
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args)
                .Build()
                .Run();
        }

        /// <summary>
        /// Creates the web host builder
        /// </summary>
        /// <returns>The created web host builder</returns>
        /// <param name="args">Arguments for the creation</param>
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
