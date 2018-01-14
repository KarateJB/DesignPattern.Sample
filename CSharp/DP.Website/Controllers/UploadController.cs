using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DP.Website.Models;
using DP.Website.Domain;
using DP.Website.Domain.Strategy;

namespace DP.Website.Controllers
{
    public class UploadController : Controller
    {
        public IActionResult Index()
        {
            FreightOrder fo = DataAccessService.Query(1);
            return View(fo);
        }

        [HttpPost]
        public IActionResult Index(string fileType, FreightOrder fo)
        {
            ModelState.Clear();

            IFoStrategy stg = null;
            if (fileType.Equals("1"))
            {
                stg = new FoStrategyAppend();
                ViewBag.Strategy = "採用策略：累加原單之數量";
            }
            else
            {
                stg = new FoStrategyReplace();
                ViewBag.Strategy = "採用策略：覆蓋原單之數量";
            }
            stg.Query = DataAccessService.Query;
            stg.Update = DataAccessService.Update;
            updateFreightOrder(fo, stg);
            return View(fo);
        }

        private void updateFreightOrder(FreightOrder fo, IFoStrategy stg)
        {
            stg.Upload(fo);
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
