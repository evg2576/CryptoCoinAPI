using DobriyCoder.Core.Common;
using static System.Net.Mime.MediaTypeNames;

namespace CryptoCoinAPI
{
    public static class Coingecko
    {
        public static CoingeckoCoinData GetCoin(string id, out IErrors? errors)
        {
            errors = new Errors();
            try
            {
                return APIHandler<CoingeckoCoinData>.GetDataAsync($"https://api.coingecko.com/api/v3/coins/{id.ToLower()}").Result;
            }
            catch (Exception ex)
            {
                errors.ErrorsList.Add(new Error(ex.Message));
                return null;
            }
        }

        public static List<CoingeckoCoinData> GetCoins(List<string> ids, out IErrors? errors)
        {
            errors = new Errors();
            try
            {
                List<CoingeckoCoinData> res = new List<CoingeckoCoinData>();
                foreach (string id in ids)
                {
                    res.Add(GetCoin(id, out errors));
                }
                return res;
            }
            catch (Exception ex)
            {
                errors.ErrorsList.Add(new Error(ex.Message));
                return null;
            }
        }

        public static CoingeckoCoinData GetPair(string pairId, out IErrors? errors)
        {
            errors = new Errors();
            try
            {
                string[] coins = pairId.ToLower().Split(new char[] { ',' });
                return APIHandler<CoingeckoCoinData>.GetDataAsync($"https://api.coingecko.com/api/v3/simple/price?ids={coins[0]}&vs_currencies={coins[1]}").Result;
            }
            catch (Exception ex)
            {
                errors.ErrorsList.Add(new Error(ex.Message));
                return null;
            }
        }
    }
}
