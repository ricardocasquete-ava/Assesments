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
using Beef.Entities;
using Beef.WebApi;
using Newtonsoft.Json.Linq;
using CFS.Assesment.Online.Common.Entities;
using RefDataNamespace = CFS.Assesment.Online.Common.Entities;

namespace CFS.Assesment.Online.Common.Agents
{
    /// <summary>
    /// Defines the <see cref="Patterns"/> Web API agent.
    /// </summary>
    public partial interface IPatternsAgent
    {
        /// <summary>
        /// Gets the specified <see cref="Patterns"/>.
        /// </summary>
        /// <param name="id">The Valid Values are [Teen, Retiree, Expat] - Any other value revents to default implementation.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        Task<WebApiAgentResult<Patterns?>> GetAsync(string? id, WebApiRequestOptions? requestOptions = null);
    }

    /// <summary>
    /// Provides the <see cref="Patterns"/> Web API agent.
    /// </summary>
    public partial class PatternsAgent : WebApiAgentBase, IPatternsAgent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatternsAgent"/> class.
        /// </summary>
        /// <param name="args">The <see cref="IOnlineWebApiAgentArgs"/>.</param>
        public PatternsAgent(IOnlineWebApiAgentArgs args) : base(args) { }

        /// <summary>
        /// Gets the specified <see cref="Patterns"/>.
        /// </summary>
        /// <param name="id">The Valid Values are [Teen, Retiree, Expat] - Any other value revents to default implementation.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<Patterns?>> GetAsync(string? id, WebApiRequestOptions? requestOptions = null) =>
            GetAsync<Patterns?>("/{id}", requestOptions: requestOptions,
                args: new WebApiArg[] { new WebApiArg<string?>("id", id) });
    }
}

#pragma warning restore
#nullable restore