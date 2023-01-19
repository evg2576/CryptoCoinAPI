using DobriyCoder.Core.Common;

namespace CryptoCoinAPI
{
    public class MarketCapCoinData
    {
        public Status status { get; set; }
        public Dictionary<string, CoinData[]>? data { get; set; }
        public IErrors? errors { get; set; }
    }

    public class CoinData
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? symbol { get; set; }
        public string? slug { get; set; }
        public decimal? num_market_pairs { get; set; }
        public DateTime? date_added { get; set; }
        public List<Dictionary<string, string>>? tags { get; set; }
        public decimal? max_supply { get; set; }
        public decimal? circulating_supply { get; set; }
        public decimal? total_supply { get; set; }
        public decimal? is_active { get; set; }
        public object? platform { get; set; }
        public decimal? cmc_rank { get; set; }
        public decimal? is_fiat { get; set; }
        public object? self_reported_circulating_supply { get; set; }
        public object? self_reported_market_cap { get; set; }
        public object? tvl_ratio { get; set; }
        public DateTime? last_updated { get; set; }
        public Dictionary<string, Quote>? quote { get; set; }
    }

    public class Quote
    {
        public decimal? price { get; set; }
        public decimal? volume_24h { get; set; }
        public decimal? volume_change_24h { get; set; }
        public decimal? percent_change_1h { get; set; }
        public decimal? percent_change_24h { get; set; }
        public decimal? percent_change_7d { get; set; }
        public decimal? percent_change_30d { get; set; }
        public decimal? percent_change_60d { get; set; }
        public decimal? percent_change_90d { get; set; }
        public decimal? market_cap { get; set; }
        public decimal? market_cap_dominance { get; set; }
        public decimal? fully_diluted_market_cap { get; set; }
        public object? tvl { get; set; }
        public DateTime? last_updated { get; set; }
    }


    public class Status
    {
        public DateTime? timestamp { get; set; }
        public int? error_code { get; set; }
        public string? error_message { get; set; }
        public int? elapsed { get; set; }
        public int? credit_count { get; set; }
        public string? notice { get; set; }
    }
}
