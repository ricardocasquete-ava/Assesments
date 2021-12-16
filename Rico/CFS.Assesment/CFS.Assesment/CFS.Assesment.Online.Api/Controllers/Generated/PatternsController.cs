/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Beef;
using Beef.AspNetCore.WebApi;
using Beef.Entities;
using CFS.Assesment.Online.Business;
using CFS.Assesment.Online.Business.Entities;
using RefDataNamespace = CFS.Assesment.Online.Business.Entities;

namespace CFS.Assesment.Online.Api.Controllers
{
    /// <summary>
    /// Provides the <see cref="Patterns"/> Web API functionality.
    /// </summary>
    public partial class PatternsController : ControllerBase
    {
        private readonly IPatternsManager _manager;

        /// <summary>
        /// Initializes a new instance of the <see cref="PatternsController"/> class.
        /// </summary>
        /// <param name="manager">The <see cref="IPatternsManager"/>.</param>
        public PatternsController(IPatternsManager manager)
            { _manager = Check.NotNull(manager, nameof(manager)); PatternsControllerCtor(); }

        partial void PatternsControllerCtor(); // Enables additional functionality to be added to the constructor.

        /// <summary>
        /// Gets the specified <see cref="Patterns"/>.
        /// </summary>
        /// <param name="id">The Valid Values are [Teen, Retiree, Expat] - Any other value revents to default implementation.</param>
        /// <returns>The selected <see cref="Patterns"/> where found.</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Patterns), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult Get(string? id) =>
            new WebApiGet<Patterns?>(this, () => _manager.GetAsync(id),
                operationType: OperationType.Read, statusCode: HttpStatusCode.OK, alternateStatusCode: HttpStatusCode.NotFound);
    }
}

#pragma warning restore
#nullable restore