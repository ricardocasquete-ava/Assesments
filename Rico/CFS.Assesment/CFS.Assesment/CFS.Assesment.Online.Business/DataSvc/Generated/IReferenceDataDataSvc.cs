/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using System;
using Beef.RefData;
using RefDataNamespace = CFS.Assesment.Online.Business.Entities;

namespace CFS.Assesment.Online.Business.DataSvc
{
    /// <summary>
    /// Provides the <b>ReferenceData</b> data services.
    /// </summary>
    public partial interface IReferenceDataDataSvc
    {
        /// <summary>
        /// Gets the <see cref="IReferenceDataCollection"/> for the associated <see cref="ReferenceDataBase"/> <see cref="Type"/>.
        /// </summary>
        /// <param name="type">The <see cref="ReferenceDataBase"/> type associated </param>
        /// <returns>A <see cref="IReferenceDataCollection"/>.</returns>
        IReferenceDataCollection GetCollection(Type type);
    }
}

#pragma warning restore
#nullable restore