using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Capstone.Models;
using Capstone.DAO;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;


namespace Capstone.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class PreferencesController : ControllerBase
    {
        private readonly IPreferencesDAO preferencesDAO;

        public PreferencesController(IPreferencesDAO _preferencesDAO)
        {
            preferencesDAO = _preferencesDAO;
        }

        [HttpGet("{userId}")]
        public ActionResult<Preferences> GetPreferencesbyUser(int userId)
        {
            Preferences preferences = preferencesDAO.GetPreferencesbyUser(userId);
            return Ok(preferences);
        }
    }
}
