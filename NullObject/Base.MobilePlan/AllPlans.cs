using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.MobilePlan
{
    public class PostPaidSaver : IMobilePlan
    {
        private int rent = 200, callrate = 20, smsrate = 100, numberofdays = 30;
        public string Name { get { return this.GetType().Name; } }

        public int Rate { get {return rent + callrate * numberofdays + smsrate; } }

        public PlanType MPlanType { get { return PlanType.Postpaid; } }

        public int SMSRate { get { return smsrate; } }

        public int NumberOfDays { get { return numberofdays; } }
    }

    public class PostPaidExclusive : IMobilePlan
    {
        private int rent = 200, callrate = 10, smsrate = 10, numberofdays = 365;
        public string Name { get { return this.GetType().Name; } }

        public int Rate { get { return rent + callrate * numberofdays + smsrate; } }

        public PlanType MPlanType { get { return PlanType.Postpaid; } }
        public int SMSRate { get { return smsrate; } }

        public int NumberOfDays { get { return numberofdays; } }
    }

    public class TalkTooMuch28 : IMobilePlan
    {
        private int rent = 0, callrate = 5, smsrate = 10, numberofdays = 28;
        public string Name { get { return this.GetType().Name; } }

        public int Rate { get { return rent + callrate * numberofdays + smsrate; } }

        public PlanType MPlanType { get { return PlanType.Postpaid; } }
        public int SMSRate { get { return smsrate; } }

        public int NumberOfDays { get { return numberofdays; } }
    }

    public class TalkTooMuch100 : IMobilePlan
    {
        private int rent = 0, callrate = 3, smsrate = 10, numberofdays = 100;
        public string Name { get { return this.GetType().Name; } }

        public int Rate { get { return rent + callrate * numberofdays + smsrate; } }

        public PlanType MPlanType { get { return PlanType.Postpaid; } }
        public int SMSRate { get { return smsrate; } }

        public int NumberOfDays { get { return numberofdays; } }
    }

    public class NullObject : IMobilePlan
    {
        public string Name { get { return this.GetType().Name; } }

        public int Rate { get { return 0; } }

        public PlanType MPlanType { get { return PlanType.None; } }
        public int SMSRate { get { return 0; } }

        public int NumberOfDays { get { return 0; } }

        static NullObject instance;
        static NullObject()
        {
            instance = new NullObject();
        }
        public static NullObject Instance() { return instance; }
        private NullObject()
        {

        }
    }
}
