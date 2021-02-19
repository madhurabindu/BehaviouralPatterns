using System;

namespace Base.Interface
{
    public interface ICRMStep
    {
        void RaiseRequest(CRMData data);

        CRMData GetStatus(string trackingId);

        void EscalateIssue(string trackingId, CRMData data);
    }

    public class CRMData
    {
        public string RaisedBy;
        public string RaisedByEmail;
        public enum Type { Complaint, ChangeRequest, Enquiry, Feedback};
        public enum Status { New, Assigned, InProgress, OnHold, Resolved, Rejected };
        public string TrackingId;
        public string RequestDescription;
        public DateTime DateRaised;
        public DateTime DateResolved;

        public Type CRMType;
        public Status CRMStatus;

        public Department OrgDept;
    }

    public class Department
    {
        public string Name;
        public string ContactName;

        public string ContactEmailId;
        public string DeptEscalationEmailId;
    }
}
