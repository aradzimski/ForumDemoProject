using ForumDemo.Data.Models;
using ForumDemo.Repositories;
using ForumDemo.Tools;
using ForumDemo.ViewModels;
using ForumDemo.ViewModels.Main;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmartBreadcrumbs.Attributes;
using SmartBreadcrumbs.Nodes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ForumDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ForumRepository _forumRepository;

        public HomeController(ILogger<HomeController> logger, ForumRepository forumRepository)
        {
            _logger = logger;
            _forumRepository = forumRepository;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [DefaultBreadcrumb("ForumDemo")]
        public async Task<IActionResult> Index()
        {
            ForumListModel vm = new ForumListModel() {
                ForumList = await _forumRepository.GetAllWithTopics()
            };

            return View(vm);
        }
    }
}
