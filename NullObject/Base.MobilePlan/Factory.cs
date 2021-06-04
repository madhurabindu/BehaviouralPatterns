using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.MobilePlan
{
    public class Factory
    {
        public IMobilePlan GetPlan(string planName)
        {
            IMobilePlan plan = NullObject.Instance();

            switch (planName)
            {
                case "1":
                    {
                        plan = new TalkTooMuch28();
                        break;
                    }
                case "2":
                    {
                        plan = new TalkTooMuch100();
                        break;
                    }
                case "3":
                    {
                        plan = new PostPaidSaver();
                        break;
                    }
                case "4":
                    {
                        plan = new PostPaidExclusive();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            return plan;
        }
    }
}
