using System;

namespace DP.Domain.Samples.Interpreter
{
    /// <summary>
    /// Pay data
    /// </summary>
    public class PayData
    {
        public Store Store {get;set;}
        public string Customer { get; set; }
        public decimal PayAmout { get; set; }
        public DateTime PayOn { get; set; }
        public Vip  Vip { get; set; }

        public PayData()
        {
            this.Store = new Store();
            this.Vip = new Vip();
        }
    }
}