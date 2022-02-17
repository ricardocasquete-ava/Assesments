using System;
using System.Collections.Generic;
using System.Text;

namespace Dizon.FactoryDesignPattern
{
    class Mobile : Subscription
    {
        public string GetPlan()
        {
            return "Mobile";
        }
        public int GetMonthlyCost()
        {
            return 149;
        }
        public int GetNumberOfDevices()
        {
            return 1;
        }
    }
}
