using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RunLoyaltyBatchWeb.Models;

namespace RunLoyaltyBatchWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(BatchEntity entity)
        {
            if (entity.BatchSelected != 0 && entity.SelectedDate != null)
            {
                ViewData["BatchEntity"] = entity;
                SendExecute(entity);
            }
            else
            {
                var _entity = new BatchEntity();
                _entity.BatchSelected = 1;
                _entity.SelectedDate = DateTime.Now;
                ViewData["BatchEntity"] = _entity;
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        private void SendExecute(BatchEntity entity)
        {
            if(entity.SelectedDate == null || entity.BatchSelected == 0)
            {
                return;
            }

            if(entity.BatchSelected == 1)
            {

            }
            else if(entity.BatchSelected == 2)
            {

            }
            else if (entity.BatchSelected == 3)
            {

            }
            else if (entity.BatchSelected == 4)
            {

            }
            else if (entity.BatchSelected == 5)
            {

            }
            else if (entity.BatchSelected == 6)
            {

            }
            else if (entity.BatchSelected == 7)
            {

            }
            else if (entity.BatchSelected == 8)
            {

            }
            else if (entity.BatchSelected == 9)
            {

            }

        }
    }
}
