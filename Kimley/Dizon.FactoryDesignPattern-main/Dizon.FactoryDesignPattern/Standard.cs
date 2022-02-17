using System;
using System.Collections.Generic;
using System.Text;

namespace Dizon.FactoryDesignPattern
{
    class Standard : Subscription
    {
        public string GetPlan()
        {
            return "Standard";
        }
        public int GetMonthlyCost()
        {
            return 459;
        }
        public int GetNumberOfDevices()
        {
            return 2;
        }
    }
}
