using CFS.Assesment.Framework.RulesEngine.Definition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CFS.Assesment.Framework.RulesEngine
{
    public class FactoryDictionary : IInit
    {
        private Dictionary<Type, Dictionary<string, Type>> registeredTypes = new Dictionary<Type, Dictionary<string, Type>>();

        public FactoryDictionary() { }

        public IBLLRule CreateBLLRule<IBLLRule>(string companyCode, object[] activateParams = null) where IBLLRule : class
        {
            var type = this.getBusinessRuleType<IBLLRule>(companyCode);
            var instance = Activator.CreateInstance(type, activateParams) as IBLLRule;

            return instance;
        }

        public void Init()
        {
            var registeredTypes = default(Type[]);
            try
            {
                registeredTypes = Assembly
                    .Load("CFS.Assesment.Framework.RulesEngine")
                    .GetTypes();

            }
            catch (ReflectionTypeLoadException loadException)
            {
                registeredTypes = loadException.Types;
            }

            registeredTypes
                .Where(registeredTypes => registeredTypes.IsInterface)
                .Where(registeredType => (typeof(IBLLBaseRule).IsAssignableFrom(registeredType)) && (registeredType != typeof(IBLLBaseRule)))
                .ToList()
                .ForEach(iBLLBaseRuleType =>
                {
                    var implementations = new Dictionary<string, Type>();

                    registeredTypes.Where(registeredType => (iBLLBaseRuleType.IsAssignableFrom(registeredType)) && (registeredType != iBLLBaseRuleType))
                    .ToList()
                    .ForEach(bllImplemtationType =>
                    {
                        var attr = bllImplemtationType.GetCustomAttribute<BrandActivationAttribute>();
                        implementations.Add(attr.Code, bllImplemtationType);
                    });

                    this.registeredTypes.Add(iBLLBaseRuleType, implementations);
                });
        }

        private Type getBusinessRuleType<IBLLRule>(string companyCode)
        {
            if (this.registeredTypes.ContainsKey(typeof(IBLLRule)))
            {
                var typeImplementations = this.registeredTypes[typeof(IBLLRule)];
                if (typeImplementations.ContainsKey(companyCode))
                    return typeImplementations[companyCode];
                else
                    return typeImplementations["*"];
            }

            return null;
        }
    }
}
