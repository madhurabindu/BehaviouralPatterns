using System;

namespace Base.Interface
{
    public class News
    {
        public enum NType { Politics, Sports, Entertainment, Health, Travel, Tech};

        public string Message;

        public NType NewsType;

        public string Reporter;

        public override string ToString()
        {
            return string.Format("Reported by : {0, -10}, {1}", Reporter, Message);
        }
    }
}
