using System;
using System.Collections;
using Base.Interface;

namespace Imp.CRMSteps
{
    public class CRMAllocator : ICRMStep
    {
        private ICRMStep successor;

        public CRMAllocator(Hashtable table, ICRMStep next)
        {
            successor = next;
        }
        public void RaiseRequest(CRMData data)
        {
            Console.WriteLine("\nNew Request Raised.. Allocate to The Right Department.. ");

            // Forward to right department
            switch (data.OrgDept.Name)
            {
                case "IT":
                    break;
                case "SW":
                    break;
                case "HR":
                    break;
            }

            data.CRMStatus = CRMData.Status.Assigned;

            successor?.RaiseRequest(data);
        }

        public CRMData GetStatus(string trackingId)
        {
            return successor != null ? successor.GetStatus(trackingId) : null;
        }

        public void EscalateIssue(string trackingId, CRMData data)
        {
            successor?.EscalateIssue(trackingId, data);
        }
    }
}
