using CFS.Assesment.Framework.RulesEngine.Definition;

namespace CFS.Assesment.Framework.RulesEngine.Implementation
{
    public interface IFeeCalculator : IBLLBaseRule
    {
        string CaculateFee(int age);
    }
}

namespace CFS.Assesment.Framework.RulesEngine.Implementation.Corporate
{
    using CFS.Assesment.Framework.RulesEngine.Implementation;

    [BrandActivation(DefaultImplementation = true)]
    public class FeeCalculator : BLLBaseRule, IFeeCalculator
    {
        public string CaculateFee(int age)
        {
            return "Standard Fee Applies";
        }
    }
}

namespace CFS.Assesment.Framework.RulesEngine.Implementation.Teenager
{
    using CFS.Assesment.Framework.RulesEngine.Implementation;

    [BrandActivation("Teen")]
    public class FeeCalculator : BLLBaseRule, IFeeCalculator
    {
        public string CaculateFee(int age)
        {
            return "No Fee for Under 18s";
        }
    }
}

namespace CFS.Assesment.Framework.RulesEngine.Implementation.Retirees
{
    using CFS.Assesment.Framework.RulesEngine.Implementation;

    [BrandActivation("Retiree")]
    public class FeeCalculator : BLLBaseRule, IFeeCalculator
    {
        public string CaculateFee(int age)
        {
            return "Discount for older australians";
        }
    }

    [BrandActivation("Expat")]
    public class FeeCalculatorOverseas : BLLBaseRule, IFeeCalculator
    {
        public string CaculateFee(int age)
        {
            return "Expats don't pay fees";
        }
    }
}
