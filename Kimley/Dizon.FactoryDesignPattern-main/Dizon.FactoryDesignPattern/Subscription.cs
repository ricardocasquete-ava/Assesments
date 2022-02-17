using System;
using System.Collections.Generic;
using System.Text;

namespace Dizon.FactoryDesignPattern
{
    public interface Subscription
    {
        string GetPlan();
        int GetMonthlyCost();
        int GetNumberOfDevices();
    }
}
