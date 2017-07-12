using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Telegram.Core.OutComingRequests.Actions
{
    public static class Actions
    {
        private static readonly string baseAddress =
            "https://api.telegram.org/bot431025520:AAFft2O5veSRU71trdJpHJcIGdJRJoxxNTU";

        public static async void SetWebHook()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseAddress);
            var content = new FormUrlEncodedContent(new []
            {
                new KeyValuePair<string, string>("url", "http://cc1dc636.ngrok.io/Telegram/Update"), 
            });

            var response = client.PostAsync("/setWebhook", content);
            string responseContent = await response.Result.Content.ReadAsStringAsync();
            Debug.WriteLine(responseContent);
        }
    }
}
