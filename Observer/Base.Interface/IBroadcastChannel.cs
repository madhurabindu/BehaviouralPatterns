using System;

namespace Base.Interface
{
    public interface IBroadcastChannel
    {
        void Update(News news);

        ChannelType CType { get; }
    }

    public enum ChannelType { News, Entertainment, Travel, Cooking, Movies, Music, Sports}
}
