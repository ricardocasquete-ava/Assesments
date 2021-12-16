/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Beef.Entities;
using Newtonsoft.Json;

namespace CFS.Assesment.Online.Common.Entities
{
    /// <summary>
    /// Represents the Position of the Rovers within a Plateau entity.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class RoverPosition
    {
        /// <summary>
        /// Gets or sets the X Coordinate.
        /// </summary>
        [JsonProperty("xCoordinate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int XCoordinate { get; set; }

        /// <summary>
        /// Gets or sets the Latitude from the vertial axis.
        /// </summary>
        [JsonProperty("yCoordinate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int YCoordinate { get; set; }

        /// <summary>
        /// Gets or sets the Orientation (see <see cref="RefDataNamespace.CardinalPosition"/>).
        /// </summary>
        [JsonProperty("orientation", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Orientation { get; set; }
    }
}

#pragma warning restore
#nullable restore