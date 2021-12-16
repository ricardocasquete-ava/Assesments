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
    [Route("Api/Rovers")]
    public partial class RoversController : Basecontroler<RoversController>
    {
        private ICommon common;
        private IRoverControllerAgent apiRoverController;

        public RoversController(
            ICommon common,
            IRoverControllerAgent apiRoverController
           , ILogger<RoversController> logger)
        {
            this.common = common;
            this.apiRoverController = apiRoverController;
        }


        [HttpPost]
        [Route("moveOne")]
        public APIResponse<RoverController> MoveOne(RoverRequestModel request)
        {
            return this.InvokeAPI(() => this.apiRoverController.MoveOneAsync(request.RoverController, request.Action));
        }
    }
}
