using System;
using System.Collections.Generic;
using System.Text;

namespace Dizon.FactoryDesignPattern
{
    class Premium : Subscription
    {
        public string GetPlan()
        {
            return "Premium";
        }
        public int GetMonthlyCost()
        {
            return 549;
        }
        public int GetNumberOfDevices()
        {
            return 4;
        }
    }
}
