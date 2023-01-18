using Microsoft.AspNetCore.WebUtilities;
using System.Net.Http.Json;

namespace CryptoCoinAPI
{
    public class APIHandler<T>
    {
        public static async Task<T> GetDataAsync(string url)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    return await httpClient.GetFromJsonAsync<T>(url);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
