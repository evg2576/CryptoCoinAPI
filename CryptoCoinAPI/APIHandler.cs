using Flurl.Http;
using System.Net.Http.Json;

namespace CryptoCoinAPI
{
    public class APIHandler<T>
    {
        //public static async Task<T> GetDataAsync(string url)
        //{
        //    try
        //    {
        //        using (var httpClient = new HttpClient())
        //        {
        //            return await httpClient.GetFromJsonAsync<T>(url);
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        public static async Task<T> GetDataAsync(string url, Dictionary<string, string>? headers = null, Dictionary<string, string>? query = null)
        {
            try
            {
                return await url
                    .WithHeaders(headers)
                    .SetQueryParams(query)
                    .GetAsync()
                    .ReceiveJson<T>();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
