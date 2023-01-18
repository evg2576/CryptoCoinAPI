using DobriyCoder.Core.Common;

namespace CryptoCoinAPI
{
    public class CoingeckoPairData
    {
        public IErrors? Errors { get; set; }
        public string? id { get; set; }
        public string? symbol { get; set; }
        public string? name { get; set; }
        public string? vsSymbol { get; set; }

        //public object? asset_platform_id { get; set; }
        //public Dictionary<string, object>? platforms { get; set; }
        //public Dictionary<string, object>? detail_platforms { get; set; }
        //public double? block_time_in_minutes { get; set; }
        //public string? hashing_algorithm { get; set; }
        //public string[]? categories { get; set; }
        //public object? public_notice { get; set; }
        //public object[]? additional_notices { get; set; }
        //public Dictionary<string, object>? localization { get; set; }
        //public Dictionary<string, object>? description { get; set; }
        //public Dictionary<string, object>? links { get; set; }
        //public Dictionary<string, object>? image { get; set; }
        //public string? country_origin { get; set; }
        //public string? genesis_date { get; set; }
        //public double? sentiment_votes_up_percentage { get; set; }
        //public double? sentiment_votes_down_percentage { get; set; }
        //public double? market_cap_rank { get; set; }
        //public double? coingecko_rank { get; set; }
        //public double? coingecko_score { get; set; }
        //public double? developer_score { get; set; }
        //public double? community_score { get; set; }
        //public double? liquidity_score { get; set; }
        //public double? public_doubleerest_score { get; set; }
        public Market_DataPair? market_data { get; set; }
        //public Dictionary<string, object>? community_data { get; set; }
        //public Dictionary<string, object>? developer_data { get; set; }
        //public Dictionary<string, object>? public_doubleerest_stats { get; set; }
        //public object[]? status_updates { get; set; }
        public DateTime last_updated { get; set; }
        //public TickerPair[]? tickers { get; set; }
    }

    public class Market_DataPair
    {
        public Dictionary<string, decimal>? current_price { get; set; }
        //public object? total_value_locked { get; set; }
        //public object? mcap_to_tvl_ratio { get; set; }
        //public object? fdv_to_tvl_ratio { get; set; }
        //public object? roi { get; set; }
        public Dictionary<string, decimal>? ath { get; set; }
        public Dictionary<string, decimal>? ath_change_percentage { get; set; }
        public Dictionary<string, DateTime>? ath_date { get; set; }
        public Dictionary<string, decimal>? atl { get; set; }
        public Dictionary<string, decimal>? atl_change_percentage { get; set; }
        public Dictionary<string, DateTime>? atl_date { get; set; }
        public Dictionary<string, decimal>? market_cap { get; set; }
        //public double? market_cap_rank { get; set; }
        public Dictionary<string, decimal>? fully_diluted_valuation { get; set; }
        public Dictionary<string, decimal>? total_volume { get; set; }
        public Dictionary<string, decimal>? high_24h { get; set; }
        public Dictionary<string, decimal>? low_24h { get; set; }
        //public double? price_change_24h { get; set; }
        //public double? price_change_percentage_24h { get; set; }
        //public double? price_change_percentage_7d { get; set; }
        //public double? price_change_percentage_14d { get; set; }
        //public double? price_change_percentage_30d { get; set; }
        //public double? price_change_percentage_60d { get; set; }
        //public double? price_change_percentage_200d { get; set; }
        //public double? price_change_percentage_1y { get; set; }
        //public double? market_cap_change_24h { get; set; }
        //public double? market_cap_change_percentage_24h { get; set; }
        public Dictionary<string, decimal>? price_change_24h_in_currency { get; set; }
        public Dictionary<string, decimal>? price_change_percentage_1h_in_currency { get; set; }
        public Dictionary<string, decimal>? price_change_percentage_24h_in_currency { get; set; }
        public Dictionary<string, decimal>? price_change_percentage_7d_in_currency { get; set; }
        public Dictionary<string, decimal>? price_change_percentage_14d_in_currency { get; set; }
        public Dictionary<string, decimal>? price_change_percentage_30d_in_currency { get; set; }
        public Dictionary<string, decimal>? price_change_percentage_60d_in_currency { get; set; }
        public Dictionary<string, decimal>? price_change_percentage_200d_in_currency { get; set; }
        public Dictionary<string, decimal>? price_change_percentage_1y_in_currency { get; set; }
        public Dictionary<string, decimal>? market_cap_change_24h_in_currency { get; set; }
        public Dictionary<string, decimal>? market_cap_change_percentage_24h_in_currency { get; set; }
        //public decimal? total_supply { get; set; }
        //public decimal? max_supply { get; set; }
        //public decimal? circulating_supply { get; set; }
        public DateTime last_updated { get; set; }
    }

    //public class TickerPair
    //{
    //    public string? _base { get; set; }
    //    public string? target { get; set; }
    //    public Dictionary<string, object>? market { get; set; }
    //    public double? last { get; set; }
    //    public double? volume { get; set; }
    //    public Dictionary<string, decimal>? converted_last { get; set; }
    //    public Dictionary<string, decimal>? converted_volume { get; set; }
    //    public string? trust_score { get; set; }
    //    public double? bid_ask_spread_percentage { get; set; }
    //    public DateTime timestamp { get; set; }
    //    public DateTime last_traded_at { get; set; }
    //    public DateTime last_fetch_at { get; set; }
    //    public bool is_anomaly { get; set; }
    //    public bool is_stale { get; set; }
    //    public string? trade_url { get; set; }
    //    public object? token_info_url { get; set; }
    //    public string? coin_id { get; set; }
    //    public string? target_coin_id { get; set; }
    //}
}