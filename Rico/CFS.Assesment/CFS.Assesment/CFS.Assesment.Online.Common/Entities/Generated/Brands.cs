/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Beef.Entities;
using Beef.RefData.Model;
using Newtonsoft.Json;

namespace CFS.Assesment.Online.Common.Entities
{
    /// <summary>
    /// Represents the Brands entity.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Brands : ReferenceDataBaseInt32
    {
    }

    /// <summary>
    /// Represents the <see cref="Brands"/> collection.
    /// </summary>
    public partial class BrandsCollection : List<Brands> { }
}

#pragma warning restore
#nullable restore