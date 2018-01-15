using System;
using System.Diagnostics;
using DP.Website.Models;

namespace DP.Website.Domain.Strategy
{
    public class DataAccessService
    {
        public static FreightOrder Query(int id)
        {
            Trace.WriteLine("==>查詢資料庫");
            return new FreightOrder{
                Id = 1,
                Customer = "供應商A",
                Product = "塑膠原料",
                Amount = 1000
            };
        }


         public static void Update(FreightOrder fo)
         {
            Trace.WriteLine("==>更新資料庫...");             
         }
    }
}