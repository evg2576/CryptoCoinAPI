using DobriyCoder.Core.Common;

namespace CryptoCoinAPI
{
    public class Coingecko
    {
        public async Task<CoingeckoCoinData> GetCoin(string symbol)
        {
            IErrors? errors = new Errors();
            try
            {
                return await APIHandler<CoingeckoCoinData>.GetDataAsync($"https://api.coingecko.com/api/v3/coins/{symbol.ToLower()}");
            }
            catch (Exception ex)
            {
                errors.ErrorsList.Add(new Error(ex.Message));
                return new CoingeckoCoinData { errors = errors };
            }
        }

        public async Task<List<CoingeckoCoinData>> GetCoins(List<string> symbols)
        {
            IErrors? errors = new Errors();
            try
            {
                List<CoingeckoCoinData> res = new List<CoingeckoCoinData>();
                foreach (string symbol in symbols)
                {
                    res.Add(await GetCoin(symbol));
                }
                return res;
            }
            catch (Exception ex)
            {
                errors.ErrorsList.Add(new Error(ex.Message));
                return new List<CoingeckoCoinData> { new CoingeckoCoinData { errors = errors } };
            }
        }

        public async Task<CoingeckoPairData> GetPair(string pairSymbol)
        {
            IErrors? errors = new Errors();
            try
            {
                string[] coins = pairSymbol.ToLower().Split(new char[] { '-' });
                string coin1Symbol = coins[0];
                string coin2Symbol = coins[1];
                CoingeckoCoinData coin1 = await GetCoin(coin1Symbol);
                return new CoingeckoPairData { coin1 = coin1, coin2Symbol = coin2Symbol };
            }
            catch (Exception ex)
            {
                errors.ErrorsList.Add(new Error(ex.Message));
                return new CoingeckoPairData { errors = errors };
            }
        }

        public async Task<List<CoingeckoPairData>> GetPairs(List<string> pairSymbols)
        {
            IErrors? errors = new Errors();
            try
            {
                List<CoingeckoPairData> res = new List<CoingeckoPairData>();
                foreach (string pairSymbol in pairSymbols)
                {
                    res.Add(await GetPair(pairSymbol));
                }
                return res;
            }
            catch (Exception ex)
            {
                errors.ErrorsList.Add(new Error(ex.Message));
                return new List<CoingeckoPairData> { new CoingeckoPairData { errors = errors } };
            }
        }
    }
}
