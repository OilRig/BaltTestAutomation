using Automation.Entity.Context;
using Microsoft.AspNetCore.Mvc;

namespace Automation.Controllers
{
    public class HomeController : Controller
    {
        private readonly AutomationContext automationContext;

        public HomeController(AutomationContext automationContext)
        {
            this.automationContext = automationContext;
        }
    }
}
