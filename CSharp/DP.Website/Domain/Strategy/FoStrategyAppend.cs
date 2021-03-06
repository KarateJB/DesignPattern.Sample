using System;
using System.Diagnostics;
using DP.Website.Models;

namespace DP.Website.Domain.Strategy
{
    public class FoStrategyAppend : IFoStrategy
    {
        public Func<int, FreightOrder> Query { get; set; }
        public Action<FreightOrder> Update { get; set; }
        public void Upload(FreightOrder fo)
        {
            var existFo = this.Query(fo.Id);
            fo.NewAmount = existFo.Amount + fo.Amount;

            //Implement other logic here

            this.Update(fo);
        }
    }
}