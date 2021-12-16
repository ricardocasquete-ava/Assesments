/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Beef.RefData;
using Beef.WebApi;
using CFS.Assesment.Online.Common.Entities;
using RefDataNamespace = CFS.Assesment.Online.Common.Entities;

namespace CFS.Assesment.Online.Common.Agents
{
    /// <summary>
    /// Defines the <b>ReferenceData</b> Web API agent.
    /// </summary>
    public partial interface IReferenceDataAgent
    {
        /// <summary>
        /// Gets all of the <see cref="RefDataNamespace.CardinalPosition"/> items that match the filter arguments.
        /// </summary>
        /// <param name="args">The optional <see cref="ReferenceDataFilter"/> arguments.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        Task<WebApiAgentResult<RefDataNamespace.CardinalPositionCollection>> CardinalPositionGetAllAsync(ReferenceDataFilter? args = null, WebApiRequestOptions? requestOptions = null);

        /// <summary>
        /// Gets all of the <see cref="RefDataNamespace.RoverOperation"/> items that match the filter arguments.
        /// </summary>
        /// <param name="args">The optional <see cref="ReferenceDataFilter"/> arguments.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        Task<WebApiAgentResult<RefDataNamespace.RoverOperationCollection>> RoverOperationGetAllAsync(ReferenceDataFilter? args = null, WebApiRequestOptions? requestOptions = null);

        /// <summary>
        /// Gets all of the <see cref="RefDataNamespace.UserContext"/> items that match the filter arguments.
        /// </summary>
        /// <param name="args">The optional <see cref="ReferenceDataFilter"/> arguments.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        Task<WebApiAgentResult<RefDataNamespace.UserContextCollection>> UserContextGetAllAsync(ReferenceDataFilter? args = null, WebApiRequestOptions? requestOptions = null);

        /// <summary>
        /// Gets the reference data entries for the specified entities and codes from the query string; e.g: api/v1/ref?entity=codeX,codeY&amp;entity2=codeZ&amp;entity3
        /// </summary>
        /// <param name="names">The optional list of reference data names.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        /// <remarks>The reference data objects will need to be manually extracted from the corresponding response content.</remarks>
        Task<WebApiAgentResult> GetNamedAsync(string[] names, WebApiRequestOptions? requestOptions = null);
    }

    /// <summary>
    /// Provides the <b>ReferenceData</b> Web API agent.
    /// </summary>
    public partial class ReferenceDataAgent : WebApiAgentBase, IReferenceDataAgent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceDataAgent"/> class.
        /// </summary>
        /// <param name="args">The <see cref="IOnlineWebApiAgentArgs"/>.</param>
        public ReferenceDataAgent(IOnlineWebApiAgentArgs args) : base(args) { }

        /// <summary>
        /// Gets all of the <see cref="RefDataNamespace.CardinalPosition"/> items that match the filter arguments.
        /// </summary>
        /// <param name="args">The optional <see cref="ReferenceDataFilter"/> arguments.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<RefDataNamespace.CardinalPositionCollection>> CardinalPositionGetAllAsync(ReferenceDataFilter? args = null, WebApiRequestOptions? requestOptions = null) =>
            GetAsync<RefDataNamespace.CardinalPositionCollection>("api/v1/ref/cardinalPositions", requestOptions: requestOptions, args: new WebApiArg[] { new WebApiArg<ReferenceDataFilter>("args", args!, WebApiArgType.FromUriUseProperties) });      

        /// <summary>
        /// Gets all of the <see cref="RefDataNamespace.RoverOperation"/> items that match the filter arguments.
        /// </summary>
        /// <param name="args">The optional <see cref="ReferenceDataFilter"/> arguments.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<RefDataNamespace.RoverOperationCollection>> RoverOperationGetAllAsync(ReferenceDataFilter? args = null, WebApiRequestOptions? requestOptions = null) =>
            GetAsync<RefDataNamespace.RoverOperationCollection>("api/v1/ref/roverOperation", requestOptions: requestOptions, args: new WebApiArg[] { new WebApiArg<ReferenceDataFilter>("args", args!, WebApiArgType.FromUriUseProperties) });      

        /// <summary>
        /// Gets all of the <see cref="RefDataNamespace.UserContext"/> items that match the filter arguments.
        /// </summary>
        /// <param name="args">The optional <see cref="ReferenceDataFilter"/> arguments.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<RefDataNamespace.UserContextCollection>> UserContextGetAllAsync(ReferenceDataFilter? args = null, WebApiRequestOptions? requestOptions = null) =>
            GetAsync<RefDataNamespace.UserContextCollection>("api/v1/ref/userContext", requestOptions: requestOptions, args: new WebApiArg[] { new WebApiArg<ReferenceDataFilter>("args", args!, WebApiArgType.FromUriUseProperties) });      

        /// <summary>
        /// Gets the reference data entries for the specified entities and codes from the query string; e.g: api/v1/ref?entity=codeX,codeY&amp;entity2=codeZ&amp;entity3
        /// </summary>
        /// <param name="names">The optional list of reference data names.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        /// <remarks>The reference data objects will need to be manually extracted from the corresponding response content.</remarks>
        public Task<WebApiAgentResult> GetNamedAsync(string[] names, WebApiRequestOptions? requestOptions = null)
        {
            var ro = requestOptions ?? new WebApiRequestOptions();
            if (names != null)
                ro.UrlQueryString += string.Join("&", names);
                
            return GetAsync("api/v1/ref", requestOptions: ro);
        }
    }
}

#pragma warning restore
#nullable restore