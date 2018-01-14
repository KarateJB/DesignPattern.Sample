using System;
using DP.Website.Models;

namespace DP.Website.Domain.Strategy
{
    public interface IFoStrategy
    {
         Func<int, FreightOrder> Query {get;set;}
         Action<FreightOrder> Update {get; set;}
         void Upload(FreightOrder so);
        
    }
}