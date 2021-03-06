/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Beef;
using Beef.RefData;
using CFS.Assesment.Online.Business.DataSvc;
using RefDataNamespace = CFS.Assesment.Online.Business.Entities;

namespace CFS.Assesment.Online.Business
{
    /// <summary>
    /// Provides the <see cref="ReferenceData"/> implementation using the corresponding data services.
    /// </summary>
    public partial class ReferenceDataProvider : RefDataNamespace.ReferenceData
    {
        private readonly IReferenceDataDataSvc _dataService;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceDataProvider"/> class.
        /// </summary>
        /// <param name="dataService">The <see cref="IReferenceDataDataSvc"/>.</param>
        public ReferenceDataProvider(IReferenceDataDataSvc dataService) { _dataService = Check.NotNull(dataService, nameof(dataService)); ReferenceDataProviderCtor(); }

        partial void ReferenceDataProviderCtor(); // Enables the ReferenceDataProvider constructor to be extended.
        
        #region Collections

        /// <summary> 
        /// Gets the <see cref="RefDataNamespace.CardinalPositionCollection"/>.
        /// </summary>
        public override RefDataNamespace.CardinalPositionCollection CardinalPosition => (RefDataNamespace.CardinalPositionCollection)this[typeof(RefDataNamespace.CardinalPosition)];

        /// <summary> 
        /// Gets the <see cref="RefDataNamespace.RoverOperationCollection"/>.
        /// </summary>
        public override RefDataNamespace.RoverOperationCollection RoverOperation => (RefDataNamespace.RoverOperationCollection)this[typeof(RefDataNamespace.RoverOperation)];

        /// <summary> 
        /// Gets the <see cref="RefDataNamespace.UserContextCollection"/>.
        /// </summary>
        public override RefDataNamespace.UserContextCollection UserContext => (RefDataNamespace.UserContextCollection)this[typeof(RefDataNamespace.UserContext)];

        #endregion

        /// <summary>
        /// Gets the <see cref="IReferenceDataCollection"/> for the associated <see cref="ReferenceDataBase"/> <see cref="Type"/>.
        /// </summary>
        /// <param name="type">The <see cref="ReferenceDataBase"/> <see cref="Type"/>.</param>
        /// <returns>A <see cref="IReferenceDataCollection"/>.</returns>
        public override IReferenceDataCollection this[Type type] => _dataService.GetCollection(type);
        
        /// <summary>
        /// Prefetches all, or the list of <see cref="ReferenceDataBase"/> objects, where not already cached or expired.
        /// </summary>
        /// <param name="names">The list of <see cref="ReferenceDataBase"/> names; otherwise, <c>null</c> for all.</param>
        public override Task PrefetchAsync(params string[] names)
        {
            var types = new List<Type>();
            if (names == null)
            {
                types.AddRange(GetAllTypes());
            }
            else
            {
                foreach (string name in names.Distinct())
                {
                    switch (name)
                    {
                        case var n when string.Compare(n, nameof(RefDataNamespace.CardinalPosition), StringComparison.InvariantCultureIgnoreCase) == 0: types.Add(typeof(RefDataNamespace.CardinalPosition)); break;
                        case var n when string.Compare(n, nameof(RefDataNamespace.RoverOperation), StringComparison.InvariantCultureIgnoreCase) == 0: types.Add(typeof(RefDataNamespace.RoverOperation)); break;
                        case var n when string.Compare(n, nameof(RefDataNamespace.UserContext), StringComparison.InvariantCultureIgnoreCase) == 0: types.Add(typeof(RefDataNamespace.UserContext)); break;
                    }
                }
            }

            Parallel.ForEach(types, (type, _) => { var __ = this[type]; });
            return Task.CompletedTask;
        }
    }
}

#pragma warning restore
#nullable restore