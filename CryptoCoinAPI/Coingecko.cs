using DobriyCoder.Core.Common;
using static System.Net.Mime.MediaTypeNames;

namespace CryptoCoinAPI
{
    public class Coingecko
    {
        public async Task<CoingeckoCoinData> GetCoin(string id)
        {
            IErrors? errors = new Errors();
            try
            {
                return await APIHandler<CoingeckoCoinData>.GetDataAsync($"https://api.coingecko.com/api/v3/coins/{id.ToLower()}");
            }
            catch (Exception ex)
            {
                errors.ErrorsList.Add(new Error(ex.Message));
                return new CoingeckoCoinData { Errors = errors };
            }
        }

        public async Task<List<CoingeckoCoinData>> GetCoins(List<string> ids)
        {
            IErrors? errors = new Errors();
            try
            {
                List<CoingeckoCoinData> res = new List<CoingeckoCoinData>();
                foreach (string id in ids)
                {
                    res.Add(await GetCoin(id));
                }
                return res;
            }
            catch (Exception ex)
            {
                errors.ErrorsList.Add(new Error(ex.Message));
                return new List<CoingeckoCoinData> { new CoingeckoCoinData { Errors = errors } };
            }
        }

        public async Task<CoingeckoPairData> GetPair(string pairId)
        {
            IErrors? errors = new Errors();
            try
            {
                string[] coins = pairId.ToLower().Split(new char[] { '-' });
                return await APIHandler<CoingeckoPairData>.GetDataAsync($"https://api.coingecko.com/api/v3/simple/price?ids={coins[0]}&vs_currencies={coins[1]}");
            }
            catch (Exception ex)
            {
                errors.ErrorsList.Add(new Error(ex.Message));
                return new CoingeckoPairData { Errors = errors };
            }
        }
    }
}
