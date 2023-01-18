using DobriyCoder.Core.Common;
using DobriyCoder.Core.Exceptions;
using System.Reflection;
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
                string coinId = coins[0];
                string vsCoinId = coins[1];
                //List<FieldInfo> res2 = new List<FieldInfo>();
                //var res = await GetCoin(coinId);
                //foreach (FieldInfo field in res.GetType().GetFields())
                //{
                //    if (field.GetType() == typeof(Dictionary<string, decimal>))
                //        res2.Add(field);
                //}
                //res.GetType().GetFields().PrintAsJson();
                //return res;
                CoingeckoPairData res = await APIHandler<CoingeckoPairData>.GetDataAsync($"https://api.coingecko.com/api/v3/coins/{coinId.ToLower()}");
                res.vsSymbol = vsCoinId;
                var res2 = res as object;
                foreach (FieldInfo field in res2.GetType().GetFields())
                {
                    Console.WriteLine(1);
                }
                return res;
            }
            catch (Exception ex)
            {
                errors.ErrorsList.Add(new Error(ex.Message));
                return new CoingeckoPairData { Errors = errors };
            }
        }
    }
}
