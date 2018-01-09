using System.Diagnostics;

namespace DP.Domain.Samples.Command
{
    /// <summary>
    /// Navy
    /// </summary>
    public class ReceiverNavy : IReceiver
    {
        public void Fire()
        {
            Trace.WriteLine("[Navy] 射出所有魚雷和對空飛彈!");
        }

        public void GatherArmy()
        {
            Trace.WriteLine("[Navy] 集合艦艇!");
        }

        public void Hold()
        {
            Trace.WriteLine("[Navy] 觀察敵情，伺機而動!");
        }
        public void SetHighGround()
        {
            Trace.WriteLine("[Navy] 組織成戰鬥隊形!");
        }
        public void Support()
        {
            Trace.WriteLine("[Navy] 砲彈支援友軍!");
        }
    }
}