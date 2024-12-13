using System;

namespace ShareLiveVar
{
    internal class ShareData
    {
        public static event Action DataEvent;
        private static int _count = 0;
        public static int Count
        {
            get => _count;
            set
            {
                _count = value;
                DataEvent?.Invoke();
            }
        }
    }
}
