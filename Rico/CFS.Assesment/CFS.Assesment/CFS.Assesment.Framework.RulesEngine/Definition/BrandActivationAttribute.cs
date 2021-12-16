using System;

namespace CFS.Assesment.Framework.RulesEngine.Definition
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class BrandActivationAttribute : Attribute
    {
        public bool DefaultImplementation { get; set; }
        public string Code { get; set; }

        public BrandActivationAttribute () { this.Code = "*"; }
        public BrandActivationAttribute (string code) { this.Code = code; }
    }
}
