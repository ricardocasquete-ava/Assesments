using CFS.Assesment.Framework.RulesEngine;
using CFS.Assesment.Framework.RulesEngine.Implementation;
using CFS.Assesment.Online.Business.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CFS.Assesment.Online.Business.Data
{
    public partial class PatternsData
    {
        private Task<Patterns?> GetOnImplementationAsync(string? id)
        {
            var feeImplementation = Singleton<FactoryDictionary>.Instance.CreateBLLRule<IFeeCalculator>(id);
            var response = feeImplementation.CaculateFee(new Random().Next());

            var pattern = new Patterns
            {
                Id = id,
                Response = response
            };

            return Task.FromResult(pattern);
        }
    }
}
