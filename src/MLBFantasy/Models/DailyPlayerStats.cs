using System;
using System.Net.Http;
using RestSharp.Extensions.MonoHttp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MLBFantasy.Models
{
    public class DailyPlayerStats
    {
        public string Day { get; set; }
        public string RunsBattedIn { get; set; }
    }
    static class Program
    {
        
        static void Main()
        {
            MakeRequest();
            Console.WriteLine("Hit ENTER to exit...");
            Console.ReadLine();
        }

        static async void MakeRequest()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "4acbaded76264e5aa3168c215df197e4");

            var uri = "https://api.fantasydata.net/mlb/v2/JSON/PlayerGameStatsByDate/2016-Jul-24?" + queryString;

            var response = await client.GetAsync(uri);
        }
    }
}