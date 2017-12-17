using System;
using System.Collections.Generic;
using System.Text;

namespace DP.Domain.Samples.Strategy
{
    public class MyTask
    {
        private ILogger _logger = null;
        public MyTask(ILogger logger)
        {
            if (logger != null)
                this._logger = logger;
        }

        public void Run()
        {
            try
            {
                //Do something
                this._logger.Debug($"My task was done on {DateTime.Now.ToString()}");

            }
            catch (Exception ex)
            {
                this._logger.Error(ex.Message);
                throw;
            }
        }
    }
}
