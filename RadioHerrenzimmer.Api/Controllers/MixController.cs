﻿// <copyright file="MixController.cs" company="Radio Herrenzimmer">
// Copyright (c) Radio Herrenzimmer. All rights reserved.
// </copyright>
namespace RadioHerrenzimmer.Api.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using RadioHerrenzimmer.Api.Model;

    /// <summary>
    /// Controller for API interactions to retrieve <see cref=" Mix"/> data
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class MixController : ControllerBase
    {
        /// <summary>
        /// Retrieves a collection of <see cref=" Mix">mixes</see>
        /// </summary>
        /// <returns>The collection of <see cref=" Mix">mixes</see></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mix>>> GetAsync()
        {
            await Task.Run(() => System.Console.WriteLine("GetAsync"));

            return this.Ok(new List<Mix>());
        }

        /// <summary>
        /// Retrieves a <see cref=" Mix">mix</see> by the specified ID value
        /// </summary>
        /// <param name="id">
        /// ID of the <see cref=" Mix">mix</see> to be returned from the
        /// data source
        /// </param>
        /// <returns>The retrieved <see cref=" Mix">mix</see></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Mix>> GetAsync(int id)
        {
            await Task.Run(() => System.Console.WriteLine($"GetAsync({id})"));

            return this.Ok(new Mix());
        }
    }
}
