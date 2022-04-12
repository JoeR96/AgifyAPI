using AgifyAPI.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

        
namespace AgifyAPI.Domain
{ 
    public static class AgeCoordinator
    {
        public static async Task<AverageAgeResponseModel> GetAverageAge(AverageAgeOfNameInCountryRequestModel request)
        {
            HttpClient client = new HttpClient();
            string u = "https://api.agify.io/";
            var builder = new UriBuilder(u);
            builder.Query = $"name={request.Name}&country_id={request.Country}";

            var url = builder.ToString();

            var res = await client.GetAsync(url);

            if(res.IsSuccessStatusCode)
            {
                CallCountCoordinator.CallsRemaining--;
                //Persistence.PersistenceCoordinator.SaveCountToTextFile();
            }

            return Newtonsoft.Json.JsonConvert.DeserializeObject<AverageAgeResponseModel>(res.Content.ReadAsStringAsync().Result);
        }
    }
    
}
