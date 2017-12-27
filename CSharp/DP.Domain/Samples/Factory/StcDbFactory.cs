using System;

namespace DP.Domain.Samples.Factory
{
    /// <summary>
    /// Static Database factory
    /// </summary>
    public class StcDbFactory
    {
        public static DbContext Create(DbEnum dbEnum)
        {
            switch (dbEnum)
            {
                case DbEnum.DataMart:
                    return new DbContext()
                    {
                        Server = "DataMart",
                        ConnectionStr = "DataMart connection string"
                    };
                case DbEnum.History:
                    return new DbContext()
                    {
                        Server = "History",
                        ConnectionStr = "History connection string"
                    };
                case DbEnum.Online:
                    return new DbContext()
                    {
                        Server = "Online",
                        ConnectionStr = "Online connection string"
                    };
                default:
                    throw new Exception("No mapping database settings!");
            }

        }

        public static DbContext CreateDataMart()
        {
            return new DbContext()
            {
                Server = "DataMart",
                ConnectionStr = "DataMart connection string"
            };
        }

        public static DbContext CreateHistory()
        {
            return new DbContext()
            {
                Server = "History",
                ConnectionStr = "History connection string"
            };
        }

        public static DbContext CreateOnline()
        {
            return new DbContext()
            {
                Server = "Online",
                ConnectionStr = "Online connection string"
            };
        }
    }


}