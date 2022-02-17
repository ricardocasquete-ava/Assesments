using System;
using System.Collections.Generic;
using System.Text;

namespace Dizon.FactoryDesignPattern
{
    class SubscriptionFactory
    {
        public static Subscription GetSubscription(string getPlan)
        {
            Subscription subscriptionDetails = null;

            if (getPlan == "Mobile")
            {
                subscriptionDetails = new Mobile();
            }
            else if (getPlan == "Basic")
            {
                subscriptionDetails = new Basic();
            }
            else if (getPlan == "Standard")
            {
                subscriptionDetails = new Standard();
            }
            else if (getPlan == "Premium")
            {
                subscriptionDetails = new Premium();
            }

            return subscriptionDetails;
        }
    }
}
