using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Restaurant
    {
        public string Id { get; set; }
        public string Alias { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public bool IsClosed { get; set; }
        public string Url { get; set; }
        public int ReviewCount { get; set; }
        public List<Category> Categories { get; set; }
        public double Rating { get; set; }
        public string Price { get; set; }
        public Location Location { get; set; }
        public string Phone { get; set; }
        public string DisplayPhone { get; set; }
        public double Distance { get; set; }
    }
}
