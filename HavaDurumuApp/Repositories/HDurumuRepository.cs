﻿using HavaDurumuApp.OpenWeatherMap_Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;


namespace HavaDurumuApp.Repositories
{
    public class HDurumuRepository : IHDurumuRepository
    {
        

        public HavaResponse GetTahmin(string sehir)
        {

            string APP_ID = Configuration.Values.OPEN_WEATHER_APP_ID;
            var client = new RestClient($"https://api.openweathermap.org/data/2.5/weather?q={sehir}&appid={APP_ID}");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            if(response.IsSuccessful)
            {
                var content = JsonConvert.DeserializeObject<JToken>(response.Content);
                return content?.ToObject<HavaResponse>();
            }
            else
            {
                return null;
            }
            
            
        }
    }
    
}
