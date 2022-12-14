using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone.Models;

namespace Capstone.DAO
{
    public interface IRestaurantDAO
    {
        public List<Restaurant> getRestaurantsBySearchParameters(Location location, List<Category> categories);
    }
}
