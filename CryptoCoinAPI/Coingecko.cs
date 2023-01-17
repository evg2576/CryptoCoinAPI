namespace CryptoCoinAPI
{
    public static class Coingecko
    {
        public static CoingeckoCoinData GetCoin(string id)
        {
            return APIHandler<CoingeckoCoinData>.GetDataAsync($"https://api.coingecko.com/api/v3/coins/{id}").Result;
        }

        public static List<CoingeckoCoinData> GetCoins(List<string> ids)
        {
            List<CoingeckoCoinData> res = new List<CoingeckoCoinData>();
            foreach(string id in ids)
            {
                res.Add(GetCoin(id));
            }
            return res;
        }
    }
}
