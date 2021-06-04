using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.MobilePlan
{
    public interface IMobilePlan
    {
        string Name { get; }
        int Rate { get; }
        int SMSRate { get; }
        int NumberOfDays { get; }

        PlanType MPlanType { get; }
    }

    public enum PlanType { Prepaid, Postpaid, None};
}
