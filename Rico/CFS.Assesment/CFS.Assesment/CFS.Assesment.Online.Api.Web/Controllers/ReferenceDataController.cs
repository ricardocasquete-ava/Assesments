using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using Microsoft.Extensions.Logging;
using Beef.AspNetCore.Spa.Response;
using Beef.AspNetCore.Spa.Ref;
using CFS.Assesment.Online.Web.Framework;
using CFS.Assesment.Online.Common.Agents;
using CFS.Assesment.Online.Common.Entities;

namespace RTech.Online.Shop.WebChannel.Controllers
{
    public class RefKeyDictionary
    {
        private bool typesLoaded = false;
        private Dictionary<string, List<RefItem>> registerTypes = null;

        public APIResponse<List<RefType>> TypesResponse { get; private set; } = null;

        public static RefKeyDictionary Instance { get; private set; } = default;
        public bool TypesLoaded
        {
            get { return this.typesLoaded; }
            set
            {
                this.typesLoaded = value;
                if (this.typesLoaded)
                {
                    this.TypesResponse = new APIResponse<List<RefType>>
                    {
                        IsSuccessful = true,
                        Data = this.registerTypes
                            .Select(type => new RefType { RefTypeName = type.Key, Values = type.Value })
                            .ToList()
                    };
                }
            }
        }

        private RefKeyDictionary() { }

        static RefKeyDictionary()
        {
            RefKeyDictionary.Instance = new RefKeyDictionary();
            RefKeyDictionary.Instance.registerTypes = new Dictionary<string, List<RefItem>>();
        }

        public void AddType(string type, List<RefItem> refItems)
        {
            if (!this.registerTypes.ContainsKey(type))
                this.registerTypes.Add(type, refItems);
        }
    }

    [ApiController]
    [Route("Api/Ref")]
    public partial class ReferenceDataController : Basecontroler<ReferenceDataController>
    {
        private IReferenceDataAgent _refAgent;

        public ReferenceDataController(IReferenceDataAgent refAgent,
            ILogger<ReferenceDataController> logger)
        {
            this._refAgent = refAgent;
        }

        //Load Ref Types in a Batch
        [HttpPost]
        [Route("getBatch")]
        public APIResponse<List<RefType>> LoadTypes()
        {
            if (!RefKeyDictionary.Instance.TypesLoaded)
            {
                RefKeyDictionary.Instance.AddType("roverOperation", this.AppendAPIRef<RoverOperationCollection, RoverOperation>(() => _refAgent.RoverOperationGetAllAsync()));
                RefKeyDictionary.Instance.AddType("cardinalPosition", this.AppendAPIRef<CardinalPositionCollection, CardinalPosition>(() => _refAgent.CardinalPositionGetAllAsync()));
                RefKeyDictionary.Instance.AddType("userContext", this.AppendAPIRef<UserContextCollection, UserContext>(() => _refAgent.UserContextGetAllAsync()));

                RefKeyDictionary.Instance.TypesLoaded = true;
            }

            return RefKeyDictionary.Instance.TypesResponse;
        }


        //Indidual Ref Data Entries
        [HttpPost]
        [Route("RoverOperation")]
        public APIResponse<List<RefItem>> RoverOperation()
        {
            return this.InvokeAPIRef<RoverOperationCollection, RoverOperation>(() => _refAgent.RoverOperationGetAllAsync());
        }

        //Config and Session
        [HttpPost]
        [Route("Config")]
        public APIResponse<AppConfig> GetConfig()
        {
            return new APIResponse<AppConfig>
            {
                IsSuccessful = true,
                Data = AppConfig.Default
            };
        }

        [HttpPost]
        [Route("setSession")]
        public APIResponse<EmptyResponse> SetSession(dynamic model)
        {
            return new APIResponse<EmptyResponse>
            {
                IsSuccessful = true
            };
        }
    }
}
