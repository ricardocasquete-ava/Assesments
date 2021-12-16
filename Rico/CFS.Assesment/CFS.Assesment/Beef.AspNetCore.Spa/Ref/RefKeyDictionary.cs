using Beef.AspNetCore.Spa.Response;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Beef.AspNetCore.Spa.Ref
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
}