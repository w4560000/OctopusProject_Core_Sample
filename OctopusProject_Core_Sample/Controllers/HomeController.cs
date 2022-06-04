using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OctopusProject_Core_Sample.Models;
using OctopusProject_Core_Sample.Repository.Models;
using OctopusProject_Core_Sample.Service;
using System.Diagnostics;

namespace OctopusProject_Core_Sample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        /// <summary>
        /// AppSettings
        /// </summary>
        private readonly AppSettings _appSettings;

        private readonly ITestService _testService;

        public HomeController(
            ILogger<HomeController> logger,
            IOptions<AppSettings> appSettings,
            ITestService testService)
        {
            _logger = logger;
            _appSettings = appSettings.Value;
            _testService = testService;
        }

        public IActionResult Index()
        {
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

        public IActionResult GetEnv()
        {
            return Json(_appSettings.Env);
        }

        public IActionResult Test()
        {
            return Json(_testService.Test());
        }

        public void TestLog()
        {
            _logger.LogInformation(".net core 3.1 log test");
        }
    }
}