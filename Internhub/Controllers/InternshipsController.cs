﻿using Microsoft.AspNetCore.Mvc;

namespace Internhub.Controllers
{
    public class InternshipsController : Controller
    {
        private readonly ILogger<InternshipsController> _logger;

        public InternshipsController(ILogger<InternshipsController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
