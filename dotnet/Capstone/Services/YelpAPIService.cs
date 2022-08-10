using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone.Models;
using RestSharp;
using Capstone.DAO;



namespace Capstone.Services
{
    public class YelpAPIService : IRestaurantDAO
    {

        public const string ApiUrl = "https://api.yelp.com/v3";
        RestClient client = new RestClient();
        public YelpAPIService()
        {
            if (client == null)
            {
                client = new RestClient(ApiUrl);
            }
        }
        public List<Restaurant> getRestaurantsBySearchParameters(Location location, List<Category> categories)
        {
            string categoryCsv = "";
            foreach (Category category in categories)
            {
                categoryCsv += category.alias;
            }
            RestRequest request = new RestRequest($"/businesses/search?term=food,{categoryCsv}&radius=40000&location={location.DisplayAddress}");
            request.AddHeader("Authorization", "Bearer " + "tbLZ8n3NuTjRRiPULshmKFXr2XbSi49JAUSFjnWWcNZXNFvzqdQwNBf8RPBG4gvwuL7EY9LXrduoBE61m1vy - HDpUOR5t5lpZwgyAewqijVzGxP7d9twrnKEDB_xYnYx");
            IRestResponse <List<Restaurant>> response = client.Get<List<Restaurant>>(request);

            CheckForError(response, "getRestaurantBySerachParameters");
            return response.Data;
            
        }

        ////////////////
        protected void CheckForError(IRestResponse response, string action)
        {
            string message = "";
            string messageDetails = "";
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                message = $"Error occurred in '{action}' - unable to reach server.";
                messageDetails = $"Action: {action}\n" +
                    $"\tResponse status was '{response.ResponseStatus}'.";
                if (response.ErrorException != null)
                {
                    messageDetails += $"\n\t{response.ErrorException.Message}";
                }
            }
            else if (!response.IsSuccessful)
            {
                message = $"An http error occurred.";

                //if it's 401, tell them to log tf in
                if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    message = $"401 - Authentication is required, please log tf in.";
                }


                messageDetails = $"Action: {action}\n" +
                    $"\tResponse: {(int)response.StatusCode} {response.StatusDescription}";
            }
        }

    }
}

