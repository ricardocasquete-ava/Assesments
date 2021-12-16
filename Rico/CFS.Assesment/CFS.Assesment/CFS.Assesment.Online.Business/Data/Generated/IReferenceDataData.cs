/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using RefDataNamespace = CFS.Assesment.Online.Business.Entities;

namespace CFS.Assesment.Online.Business.Data
{
    /// <summary>
    /// Provides the <b>ReferenceData</b> data access.
    /// </summary>
    public partial interface IReferenceDataData
    {
        /// <summary>
        /// Gets all the <see cref="RefDataNamespace.CardinalPosition"/> items.
        /// </summary>
        /// <returns>The <see cref="RefDataNamespace.CardinalPositionCollection"/>.</returns>
        Task<RefDataNamespace.CardinalPositionCollection> CardinalPositionGetAllAsync();

        /// <summary>
        /// Gets all the <see cref="RefDataNamespace.RoverOperation"/> items.
        /// </summary>
        /// <returns>The <see cref="RefDataNamespace.RoverOperationCollection"/>.</returns>
        Task<RefDataNamespace.RoverOperationCollection> RoverOperationGetAllAsync();

        /// <summary>
        /// Gets all the <see cref="RefDataNamespace.UserContext"/> items.
        /// </summary>
        /// <returns>The <see cref="RefDataNamespace.UserContextCollection"/>.</returns>
        Task<RefDataNamespace.UserContextCollection> UserContextGetAllAsync();
    }
}

#pragma warning restore
#nullable restore