using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Compare_Transient_Scope_Singleton.Models;
using Compare_Transient_Scope_Singleton.IService;

namespace Compare_Transient_Scope_Singleton.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IScopeService _scopeService;
        private readonly ITransientService _transientService;
        private readonly ISingletonService _singletonService;
        private readonly IScopeService _scopeService2;
        private readonly ITransientService _transientService2;
        private readonly ISingletonService _singletonService2;

        public HomeController(ILogger<HomeController> logger,
                              IScopeService scopeService,
                              ITransientService transientService,
                              ISingletonService singletonService,
                              IScopeService scopeService2,
                              ITransientService transientService2,
                              ISingletonService singletonService2)
        {
            _logger = logger;
            _transientService = transientService;
            _scopeService = scopeService;
            _singletonService = singletonService;
            _transientService2 = transientService2;
            _scopeService2 = scopeService2;
            _singletonService2 = singletonService2;
        }

        public IActionResult Index()
        {
            var transientService = _transientService.GetGuild();
            var scopeService = _scopeService.GetGuild();
            var singletonService = _singletonService.GetGuild();
            var transientService2 = _transientService2.GetGuild();
            var scopeService2 = _scopeService2.GetGuild();
            var singletonService2 = _singletonService2.GetGuild();

            ViewData["transientService"] = transientService;
            ViewData["scopeService"] = scopeService;
            ViewData["singletonService"] = singletonService;
            ViewData["transientService2"] = transientService2;
            ViewData["scopeService2"] = scopeService2;
            ViewData["singletonService2"] = singletonService2;
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
    }
}
