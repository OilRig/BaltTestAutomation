using Automation.Entity.Context;
using Automation.Entity.Models;
using ForTestHost.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ForTestHost.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AutomationContext _automationContext;

        public HomeController(ILogger<HomeController> logger, AutomationContext automationContext)
        {
            _logger = logger;
            _automationContext = automationContext;
        }

        public async  Task<IActionResult> Index()
        {
            var res = await _automationContext.Cases.FirstOrDefaultAsync();

            return Ok(new CaseModel()
            {
               Name = res.Name,
               Contents = res.Contents,
               CreatedDate = DateTime.Now,
               Id = res.Id,
               
            });
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
    }
}