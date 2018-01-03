namespace DP.Domain.Samples.Template
{
    public abstract class ProductFixingTemplate
    {
        /// <summary>
        /// 找出Working Option Leg
        /// </summary>
        protected abstract void FindWorkOptionLeg();
        /// <summary>
        /// 檢查是否已經觸及生效/失效障礙
        /// </summary>
        protected abstract void CheckBarriers();
        /// <summary>
        /// 由檢核障礙結果做Rebate process
        /// </summary>
        /// <returns>是否繼續比價</returns>
        protected abstract bool RebateBarriers();
        /// <summary>
        /// 計算每個部位的PayOff及交割結果
        /// </summary>
        protected abstract void FixingOptionLeg();
        /// <summary>
        /// 檢核Triggers
        /// </summary>
        protected abstract void CheckTriggers();

        /// <summary>
        /// 開始比價
        /// </summary>
        public void Fixing()
        {
            //Find the work option leg
            this.FindWorkOptionLeg();
            
            //Check Barriers
            this.CheckBarriers();

            //Rebate Barriers
            if(this.RebateBarriers())
            {
                //Fixing working Option Leg
                this.FixingOptionLeg();

                //Check Triggers
                this.CheckTriggers();
            }
            else
            {
                //Check Triggers
                this.CheckTriggers();
            }
        }
    }
}