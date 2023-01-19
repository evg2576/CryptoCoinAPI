using DobriyCoder.Core.Common;

namespace CryptoCoinAPI
{
    public class MarketCapPairData
    {
        public IErrors? errors { get; set; }
        public string coin1Symbol { get; set; }
        public string coin2Symbol { get; set; }
        public MarketCapCoinData? coin1 { get; set; }
        public MarketCapCoinData? coin2 { get; set; }
        public decimal? price => coin1.data?.ContainsKey(coin1Symbol) ?? false ? coin1.data?[coin1Symbol][0].quote?.ContainsKey(coin2Symbol) ?? false ? coin1.data?[coin1Symbol][0].quote?[coin2Symbol].price : null : null;
        public decimal? volume_24h => coin1.data?.ContainsKey(coin1Symbol) ?? false ? coin1.data?[coin1Symbol][0].quote?.ContainsKey(coin2Symbol) ?? false ? coin1.data?[coin1Symbol][0].quote?[coin2Symbol].volume_24h : null : null;
        public decimal? volume_change_24h => coin1.data?.ContainsKey(coin1Symbol) ?? false ? coin1.data?[coin1Symbol][0].quote?.ContainsKey(coin2Symbol) ?? false ? coin1.data?[coin1Symbol][0].quote?[coin2Symbol].volume_change_24h : null : null;
        public decimal? percent_change_1h => coin1.data?.ContainsKey(coin1Symbol) ?? false ? coin1.data?[coin1Symbol][0].quote?.ContainsKey(coin2Symbol) ?? false ? coin1.data?[coin1Symbol][0].quote?[coin2Symbol].percent_change_1h : null : null;
        public decimal? percent_change_24h => coin1.data?.ContainsKey(coin1Symbol) ?? false ? coin1.data?[coin1Symbol][0].quote?.ContainsKey(coin2Symbol) ?? false ? coin1.data?[coin1Symbol][0].quote?[coin2Symbol].percent_change_24h : null : null;
        public decimal? percent_change_7d => coin1.data?.ContainsKey(coin1Symbol) ?? false ? coin1.data?[coin1Symbol][0].quote?.ContainsKey(coin2Symbol) ?? false ? coin1.data?[coin1Symbol][0].quote?[coin2Symbol].percent_change_7d : null : null;
        public decimal? percent_change_30d => coin1.data?.ContainsKey(coin1Symbol) ?? false ? coin1.data?[coin1Symbol][0].quote?.ContainsKey(coin2Symbol) ?? false ? coin1.data?[coin1Symbol][0].quote?[coin2Symbol].percent_change_30d : null : null;
        public decimal? percent_change_60d => coin1.data?.ContainsKey(coin1Symbol) ?? false ? coin1.data?[coin1Symbol][0].quote?.ContainsKey(coin2Symbol) ?? false ? coin1.data?[coin1Symbol][0].quote?[coin2Symbol].percent_change_60d : null : null;
        public decimal? percent_change_90d => coin1.data?.ContainsKey(coin1Symbol) ?? false ? coin1.data?[coin1Symbol][0].quote?.ContainsKey(coin2Symbol) ?? false ? coin1.data?[coin1Symbol][0].quote?[coin2Symbol].percent_change_90d : null : null;
        public decimal? market_cap => coin1.data?.ContainsKey(coin1Symbol) ?? false ? coin1.data?[coin1Symbol][0].quote?.ContainsKey(coin2Symbol) ?? false ? coin1.data?[coin1Symbol][0].quote?[coin2Symbol].market_cap : null : null;
        public decimal? market_cap_dominance => coin1.data?.ContainsKey(coin1Symbol) ?? false ? coin1.data?[coin1Symbol][0].quote?.ContainsKey(coin2Symbol) ?? false ? coin1.data?[coin1Symbol][0].quote?[coin2Symbol].market_cap_dominance : null : null;
        public decimal? fully_diluted_market_cap => coin1.data?.ContainsKey(coin1Symbol) ?? false ? coin1.data?[coin1Symbol][0].quote?.ContainsKey(coin2Symbol) ?? false ? coin1.data?[coin1Symbol][0].quote?[coin2Symbol].fully_diluted_market_cap : null : null;
        public object? tvl => coin1.data?.ContainsKey(coin1Symbol) ?? false ? coin1.data?[coin1Symbol][0].quote?.ContainsKey(coin2Symbol) ?? false ? coin1.data?[coin1Symbol][0].quote?[coin2Symbol].tvl : null : null;
        public DateTime? last_updated => coin1.data?.ContainsKey(coin1Symbol) ?? false ? coin1.data?[coin1Symbol][0].quote?.ContainsKey(coin2Symbol) ?? false ? coin1.data?[coin1Symbol][0].quote?[coin2Symbol].last_updated : null : null;
    }
}
