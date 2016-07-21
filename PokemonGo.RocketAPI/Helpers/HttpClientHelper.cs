using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace PokemonGo.RocketAPI.Helpers
{
    public static class HttpClientHelper
    {
        private static readonly ISettings _clientSettings;

        public static async Task<TResponse> PostFormEncodedAsync<TResponse>(string url, params KeyValuePair<string, string>[] keyValuePairs)
        {
            if(_clientSettings.Debug)
                Logger.Write($"Requesting {typeof(TResponse).Name}", LogLevel.Debug);

            var handler = new HttpClientHandler()
            {
                AutomaticDecompression = DecompressionMethods.GZip,
                AllowAutoRedirect = false
            };

            using (var tempHttpClient = new HttpClient(handler))
            {
                var response = await tempHttpClient.PostAsync(url, new FormUrlEncodedContent(keyValuePairs));
                return await response.Content.ReadAsAsync<TResponse>();
            }
        }
    }
}
