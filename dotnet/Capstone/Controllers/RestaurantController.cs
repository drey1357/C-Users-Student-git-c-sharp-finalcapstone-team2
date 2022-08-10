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
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantDAO restaurantDAO;
        private readonly IPreferencesDAO preferencesDAO;

        public RestaurantController(IRestaurantDAO _restaurantDAO, IPreferencesDAO _preferencesDAO)
        {
            preferencesDAO = _preferencesDAO;
            restaurantDAO = _restaurantDAO;
        }

        [HttpGet("{userId}/new-restaurants")]
        public ActionResult<Restaurant> getRestaurantsBySearchParameters(int userId, Location location)
        {
            //make a category array (to then be "csv'd")
            List<Category> categoriesToSearch = new List<Category>();

            //find preferences
            List<Preferences> PreferencesToConvertToCategories = preferencesDAO.GetPreferencesbyUser(userId);
            foreach(Preferences preference in PreferencesToConvertToCategories)
            {
                categoriesToSearch.Add(preference.PreferenceType);
            }
            
            List<Restaurant> restaurants = restaurantDAO.getRestaurantsBySearchParameters(location, categoriesToSearch);
            return Ok(restaurants);
        }
    }
}
