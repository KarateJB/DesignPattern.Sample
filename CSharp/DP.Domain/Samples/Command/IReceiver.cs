namespace DP.Domain.Samples.Command
{
    public interface IReceiver
    {
        /// <summary>
        /// 集合部隊
        /// </summary>
        void GatherArmy(); 
        /// <summary>
        /// 開火
        /// </summary>
        void Fire();
        /// <summary>
        /// 設定制高點=有利之位置...(語出歐比王)
        /// </summary>
        void SetHighGround();
        /// <summary>
        /// 等待開火指示
        /// </summary>
        void Hold();
         /// <summary>
        /// 支援
        /// </summary>
        void Support();
    }
}