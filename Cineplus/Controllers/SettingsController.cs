using System;
using System.Collections;
using System.Collections.Generic;
using Cineplus.Models;
using Cineplus.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cineplus.Controllers
{
    [Route("/api/[controller]")]
    public class SettingsController : Controller
    {
        private ISettingsService _settingsService;
		
        public SettingsController(ISettingsService settingsService) {
            _settingsService = settingsService;
        }
        
        [HttpGet]
        [Route("display")]
        public ActionResult<IEnumerable<Settings>> Index()
        {
            return new ActionResult<IEnumerable<Settings>>(_settingsService.GetAllDisplay());
        }

        [HttpPut]
        [Route("display")]
        public ActionResult<Settings> Activate([FromBody]Settings setting)
        {
            return new ActionResult<Settings>(_settingsService.SetActiveDisplay(setting));
        }
    }
}