using DobriyCoder.Core.Common;
using Flurl.Http;

namespace CryptoCoinAPI
{
    public class CoinMarketCapClient
    {
        public string ApiKey { private get; set; } = "b6a54e2d-2076-4929-ac2c-b48e1aa5bd7d";

        public CoinMarketCapClient(string apiKey) { }

        public CoinMarketCapClient()
        {
            ApiKey= ApiKey;
        }

        public async Task<MarketCapCoinData> GetCoin(string symbol)
        {
            IErrors? errors = new Errors();
            try
            {
                var headers = new Dictionary<string, string>();
                headers.Add("X-CMC_PRO_API_KEY", ApiKey);
                headers.Add("Accept", "application/json");

                var query = new Dictionary<string, string>();
                query.Add("symbol", symbol.ToUpper());

                return await "https://pro-api.coinmarketcap.com/v2/cryptocurrency/quotes/latest"
                    .WithHeader("Accept", "application/json")
                    .WithHeader("X-CMC_PRO_API_KEY", ApiKey)
                    .SetQueryParams(query)
                    .GetAsync()
                    .ReceiveJson<MarketCapCoinData>();
            }
            catch (Exception ex)
            {
                errors.ErrorsList.Add(new Error(ex.Message));
                return new MarketCapCoinData { errors = errors };
            }
        }

        public async Task<List<MarketCapCoinData>> GetCoins(List<string> symbols)
        {
            IErrors? errors = new Errors();
            try
            {
                List<MarketCapCoinData> res = new List<MarketCapCoinData>();
                foreach (string symbol in symbols)
                {
                    res.Add(await GetCoin(symbol));
                }
                return res;
            }
            catch (Exception ex)
            {
                errors.ErrorsList.Add(new Error(ex.Message));
                return new List<MarketCapCoinData> { new MarketCapCoinData { errors = errors } };
            }
        }

        public async Task<MarketCapPairData> GetPair(string pairSymbol)
        {
            IErrors? errors = new Errors();
            try
            {
                string[] coins = pairSymbol.ToUpper().Split(new char[] { '-' });
                string coin1Symbol = coins[0];
                string coin2Symbol = coins[1];

                var headers = new Dictionary<string, string>();
                headers.Add("X-CMC_PRO_API_KEY", ApiKey);
                headers.Add("Accept", "application/json");

                var query = new Dictionary<string, string>();
                query.Add("symbol", coin1Symbol);
                query.Add("convert", coin2Symbol);
                MarketCapCoinData coin1 = await "https://pro-api.coinmarketcap.com/v2/cryptocurrency/quotes/latest"
                    //.WithHeader("Accept", "application/json")
                    .WithHeaders(headers)
                    //.WithHeader("X-CMC_PRO_API_KEY", ApiKey)
                    .SetQueryParams(query)
                    .GetAsync()
                    .ReceiveJson<MarketCapCoinData>();

                return new MarketCapPairData { coin1 = coin1, coin1Symbol = coin1Symbol, coin2Symbol = coin2Symbol };
            }
            catch (Exception ex)
            {
                errors.ErrorsList.Add(new Error(ex.Message));
                return new MarketCapPairData { errors = errors };
            }
        }

        public async Task<List<MarketCapPairData>> GetPairs(List<string> pairSymbols)
        {
            IErrors? errors = new Errors();
            try
            {
                List<MarketCapPairData> res = new List<MarketCapPairData>();
                foreach (string pairId in pairSymbols)
                {
                    res.Add(await GetPair(pairId));
                }
                return res;
            }
            catch (Exception ex)
            {
                errors.ErrorsList.Add(new Error(ex.Message));
                return new List<MarketCapPairData> { new MarketCapPairData { errors = errors } };
            }
        }
    }
}
