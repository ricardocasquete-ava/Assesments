/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Beef;
using Beef.Entities;
using CFS.Assesment.Online.Business.Entities;
using RefDataNamespace = CFS.Assesment.Online.Business.Entities;

namespace CFS.Assesment.Online.Business.Data
{
    /// <summary>
    /// Defines the <see cref="Patterns"/> data access.
    /// </summary>
    public partial interface IPatternsData
    {
        /// <summary>
        /// Gets the specified <see cref="Patterns"/>.
        /// </summary>
        /// <param name="id">The Valid Values are [Teen, Retiree, Expat] - Any other value revents to default implementation.</param>
        /// <returns>The selected <see cref="Patterns"/> where found.</returns>
        Task<Patterns?> GetAsync(string? id);
    }
}

#pragma warning restore
#nullable restore