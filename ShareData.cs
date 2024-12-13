using System;

namespace ShareLiveVar
{
    internal class ShareData
    {
        public static event Action DataEvent; // 建立一個事件
        private static int _count = 0; // 存數字(加private只能在這個class中使用)
        public static int Count // 用來在forms之間共享的數字(設有get和set)
        {
            get => _count; // 當取得數字時，回傳_count (Ex: number.Text = ShareData.Count.ToString();)
            set // 當設定數字時，將_count設為value，並觸發DataEvent事件 (Ex: ShareData.Count++;)
            {
                _count = value; // 設定數字
                DataEvent?.Invoke(); // 觸發DataEvent事件，也就是說所有在forms中註冊DataEvent事件的function都會被執行
            }
        }
    }
}