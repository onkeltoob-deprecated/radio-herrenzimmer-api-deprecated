// <copyright file="Mix.cs" company="Radio Herrenzimmer">
// Copyright (c) Radio Herrenzimmer. All rights reserved.
// </copyright>
namespace RadioHerrenzimmer.Api.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a collection of <see cref=" Track">tracks</see>
    /// mixed to form a unique set
    /// </summary>
    public class Mix
    {
        /// <summary>
        /// Unique identifier of the <see cref=" Mix">mix</see>
        /// within the data source
        /// </summary>
        public Guid Id
        {
            get;
            set;
        }

        /// <summary>
        /// Name of the <see cref=" Mix">mix</see>
        /// </summary>
        public string Title
        {
            get;
            set;
        }

        /// <summary>
        /// Name(s) of the person(s)/artist(s) who created
        /// the <see cref=" Mix">mix</see>
        /// </summary>
        public string Artist
        {
            get;
            set;
        }

        /// <summary>
        /// List of the <see cref=" Track">tracks</see>
        /// this <see cref=" Mix">mix</see> is made of
        /// </summary>
        public IEnumerable<Track> Tracks
        {
            get;
            set;
        }
    }
}
