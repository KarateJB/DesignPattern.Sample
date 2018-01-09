using System.Diagnostics;

namespace DP.Domain.Samples.Command
{
    /// <summary>
    /// 陸軍
    /// </summary>
    public class ReceiverAirForce : IReceiver
    {
        public void Fire()
        {
            Trace.WriteLine("[AirForce] 自由開火!");
        }

        public void GatherArmy()
        {
            Trace.WriteLine("[AirForce] 集合戰鬥機飛官!");
        }

        public void Hold()
        {
            Trace.WriteLine("[AirForce] 組織巡邏隊形進行觀察!");
        }

        public void SetHighGround()
        {
            Trace.WriteLine("[AirForce] 飛高高!");
        }

        public void Support()
        {
            Trace.WriteLine("[AirForce] 以機槍掃射掩護!");
        }
    }
}