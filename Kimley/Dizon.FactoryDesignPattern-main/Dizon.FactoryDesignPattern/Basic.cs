using System;
using System.Collections.Generic;
using System.Text;

namespace Dizon.FactoryDesignPattern
{
    class Basic : Subscription
    {
        public string GetPlan()
        {
            return "Basic";
        }
        public int GetMonthlyCost()
        {
            return 369;
        }
        public int GetNumberOfDevices()
        {
            return 1;
        }
    }
}
