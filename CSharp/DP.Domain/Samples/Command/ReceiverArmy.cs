using System.Diagnostics;

namespace DP.Domain.Samples.Command
{
    /// <summary>
    /// 陸軍
    /// </summary>
    public class ReceiverArmy : IReceiver
    {
        public void Fire()
        {
            Trace.WriteLine("[Army] 坦克及路面部隊開始前進突破敵方防線!");
        }

        public void GatherArmy()
        {
            Trace.WriteLine("[Army] 集合裝甲部隊和部兵!");
        }

        public void Hold()
        {
            Trace.WriteLine("[Army] 子彈上膛!等待開火指令!");
        }

        public void SetHighGround()
        {
            Trace.WriteLine("[Army] 不要跑到有沙的地方!");
        }
        public void Support()
        {
            Trace.WriteLine("[Army] 以50機槍掃射掩護!");
        }
    }
}