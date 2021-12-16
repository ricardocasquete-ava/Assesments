using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;

using CFS.Assesment.Online.Web.Framework;
using Beef.AspNetCore.Spa.Response;
using CFS.Assesment.Online.Common.Agents;
using CFS.Assesment.Online.Common.Entities;
using CFS.Assesment.Online.Api.Web.Models;

namespace RTech.Online.Shop.WebChannel.Controllers
{
    [ApiController]
    [Route("Api/Patterns")]
    public partial class PatternsController : Basecontroler<PatternsController>
    {
        private ICommon common;
        private IPatternsAgent apiPatterns;

        public PatternsController(
            ICommon common,
            IPatternsAgent apiPatterns
           , ILogger<PatternsController> logger)
        {
            this.common = common;
            this.apiPatterns = apiPatterns;
        }


        [HttpPost]
        [Route("getFee")]
        public APIResponse<Patterns> MoveOne(PatternsRequestModel model)
        {
            return this.InvokeAPI(() => this.apiPatterns.GetAsync(model.Context));
        }
    }
}
//api/patterns/getFee
//Api/Patterns/getFee