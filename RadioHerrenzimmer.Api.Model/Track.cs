// <copyright file="Track.cs" company="Radio Herrenzimmer">
// Copyright (c) Radio Herrenzimmer. All rights reserved.
// </copyright>
namespace RadioHerrenzimmer.Api.Model
{
    using System;

    /// <summary>
    /// Represents a single track that may be part of a
    /// <see cref=" Mix">mix</see>
    /// </summary>
    public class Track
    {
        /// <summary>
        /// Unique identifier of the <see cref=" Track"/> object within
        /// the data source
        /// </summary>
        public Guid Id
        {
            get;
            set;
        }

        /// <summary>
        /// Name of the <see cref=" Track">track</see>
        /// </summary>
        public string Title
        {
            get;
            set;
        }

        /// <summary>
        /// Name(s) of the person(s)/artist(s) who created the
        /// <see cref=" Track">track</see> object
        /// </summary>
        public string Artist
        {
            get;
            set;
        }

        /// <summary>
        /// Name of the record label the <see cref=" Track">track</see>
        /// has been released on
        /// </summary>
        public string Label
        {
            get;
            set;
        }
    }
}
