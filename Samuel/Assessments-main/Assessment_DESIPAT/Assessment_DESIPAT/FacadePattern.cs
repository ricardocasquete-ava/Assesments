using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_DESIPAT
{
    internal class FacadePattern
    {
        private IAgent agentProvider;
        private IManager managerProvider;

        public FacadePattern()
        {
            agentProvider = new AgentProvider();
            managerProvider = new ManagerProvider();    
        }

        public void GetRefundAgent()
        {
            agentProvider.GetRefundAgent();
        }

        public void GetKYCAgent()
        {
            agentProvider.GetKYCAgent();
        }

        public void GetManagerEscalation()
        {
            managerProvider.GetManagerEscalation();
        }


    }

    public interface IAgent
    {
        void GetRefundAgent();
        void GetKYCAgent();
    }

    public interface IManager
    {
        void GetManagerEscalation();
    }

    public class AgentProvider : IAgent
    {
        public void GetRefundAgent()
        {
            Console.WriteLine("Assigning refund agent to customer...");
            AccomplishTicket();
        }
        public void GetKYCAgent()
        {
            Console.WriteLine("Assigning agent to customer for KYC...");
            AccomplishTicket();
        }
        private void AccomplishTicket()
        {
            Console.WriteLine("Successfully assisted customer with concern.");
        }
    }

    public class ManagerProvider : IManager
    {
        public void GetManagerEscalation()
        {
            Console.WriteLine("Escalating concern to manager...");
            AccomplishTicket();
        }
        private void AccomplishTicket()
        {
            Console.WriteLine("Successfully assisted customer with concern after escalation.");
        }
    }
}
