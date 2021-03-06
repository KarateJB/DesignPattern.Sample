namespace DP.Domain.Samples.Decorator
{
    public class Transport
    {
        /// <summary>
        /// 運送點
        /// </summary>
        public string Place { get; set; }
        /// <summary>
        /// 里程
        /// </summary>
        public int Miles { get; set; }
        /// <summary>
        /// 加點數
        /// </summary>
        public int ExtraPlaceCnt { get; set; }
        /// <summary>
        /// 假日運送
        /// </summary>
        public bool IsHoliday { get; set; }
        /// <summary>
        /// 延誤時數
        /// </summary>
        public int DelayHours { get; set; } = 0;
    }
}