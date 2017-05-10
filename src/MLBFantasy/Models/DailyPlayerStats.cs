using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace MLBFantasy.Models
{
    
    public class DailyPlayerStats
    {        
        private async Task<bool> Request()
        {
            var userName = skarski10;
            var password = ;
            string url = https://www.mysportsfeeds.com/api/feed/pull/mlb/2016-regular/daily_player_stats.json?fordate=20161002&playerstats=AB,H,R,HR,ER;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            request.Headers.Add("Authorization", "Basic " + base64_encode(userName
            +":" + password));

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    return true;
                    //process the response
                }
            }
        }
    }
}
