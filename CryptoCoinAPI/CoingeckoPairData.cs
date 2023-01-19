using DobriyCoder.Core.Common;

namespace CryptoCoinAPI
{
    public class CoingeckoPairData
    {
        public IErrors? errors { get; set; }
        public string coin2Symbol { get; set; }
        public CoingeckoCoinData? coin1 { get; set; }
        public CoingeckoCoinData? coin2 { get; set; }
        public decimal? current_price => coin1?.market_data?.current_price?.ContainsKey(coin2Symbol) ?? false ? coin1?.market_data?.current_price?[coin2Symbol] : null;
        public object? total_value_locked => coin1?.market_data?.total_value_locked;
        public object? mcap_to_tvl_ratio => coin1?.market_data?.mcap_to_tvl_ratio;
        public object? fdv_to_tvl_ratio => coin1?.market_data?.fdv_to_tvl_ratio;
        public object? roi => coin1?.market_data?.roi;
        public decimal? ath => coin1?.market_data?.ath?.ContainsKey(coin2Symbol) ?? false ? coin1?.market_data?.ath?[coin2Symbol] : null;
        public decimal? ath_change_percentage => coin1?.market_data?.ath_change_percentage?.ContainsKey(coin2Symbol) ?? false ? coin1?.market_data?.ath_change_percentage?[coin2Symbol] : null;
        public DateTime? ath_date => coin1?.market_data?.ath_date?.ContainsKey(coin2Symbol) ?? false ? coin1?.market_data?.ath_date?[coin2Symbol] : null;
        public decimal? atl => coin1?.market_data?.atl?.ContainsKey(coin2Symbol) ?? false ? coin1?.market_data?.atl?[coin2Symbol] : null;
        public decimal? atl_change_percentage => coin1?.market_data?.atl_change_percentage?.ContainsKey(coin2Symbol) ?? false ? coin1?.market_data?.atl_change_percentage?[coin2Symbol] : null;
        public DateTime? atl_date => coin1?.market_data?.atl_date?.ContainsKey(coin2Symbol) ?? false ? coin1?.market_data?.atl_date?[coin2Symbol] : null;
        public decimal? market_cap => coin1?.market_data?.market_cap?.ContainsKey(coin2Symbol) ?? false ? coin1?.market_data?.market_cap?[coin2Symbol] : null;
        public double? market_cap_rank => coin1?.market_data?.market_cap_rank;
        public decimal? fully_diluted_valuation => coin1?.market_data?.fully_diluted_valuation?.ContainsKey(coin2Symbol) ?? false ? coin1?.market_data?.fully_diluted_valuation?[coin2Symbol] : null;
        public decimal? total_volume => coin1?.market_data?.total_volume?.ContainsKey(coin2Symbol) ?? false ? coin1?.market_data?.total_volume?[coin2Symbol] : null;
        public decimal? high_24h => coin1?.market_data?.high_24h?.ContainsKey(coin2Symbol) ?? false ? coin1?.market_data?.high_24h?[coin2Symbol] : null;
        public decimal? low_24h => coin1?.market_data?.low_24h?.ContainsKey(coin2Symbol) ?? false ? coin1?.market_data?.low_24h?[coin2Symbol] : null;
        public double? price_change_24h => coin1?.market_data?.price_change_24h;
        public double? price_change_percentage_24h => coin1?.market_data?.price_change_percentage_24h;
        public double? price_change_percentage_7d => coin1?.market_data?.price_change_percentage_7d;
        public double? price_change_percentage_14d => coin1?.market_data?.price_change_percentage_14d;
        public double? price_change_percentage_30d => coin1?.market_data?.price_change_percentage_30d;
        public double? price_change_percentage_60d => coin1?.market_data?.price_change_percentage_60d;
        public double? price_change_percentage_200d => coin1?.market_data?.price_change_percentage_200d;
        public double? price_change_percentage_1y => coin1?.market_data?.price_change_percentage_1y;
        public double? market_cap_change_24h => coin1?.market_data?.market_cap_change_24h;
        public double? market_cap_change_percentage_24h => coin1?.market_data?.market_cap_change_percentage_24h;
        public decimal? price_change_24h_in_currency => coin1?.market_data?.price_change_24h_in_currency?.ContainsKey(coin2Symbol) ?? false ? coin1?.market_data?.price_change_24h_in_currency?[coin2Symbol] : null;
        public decimal? price_change_percentage_1h_in_currency => coin1?.market_data?.price_change_percentage_1h_in_currency?.ContainsKey(coin2Symbol) ?? false ? coin1?.market_data?.price_change_percentage_1h_in_currency?[coin2Symbol] : null;
        public decimal? price_change_percentage_24h_in_currency => coin1?.market_data?.price_change_percentage_24h_in_currency?.ContainsKey(coin2Symbol) ?? false ? coin1?.market_data?.price_change_percentage_24h_in_currency?[coin2Symbol] : null;
        public decimal? price_change_percentage_7d_in_currency => coin1?.market_data?.price_change_percentage_7d_in_currency?.ContainsKey(coin2Symbol) ?? false ? coin1?.market_data?.price_change_percentage_7d_in_currency?[coin2Symbol] : null;
        public decimal? price_change_percentage_14d_in_currency => coin1?.market_data?.price_change_percentage_14d_in_currency?.ContainsKey(coin2Symbol) ?? false ? coin1?.market_data?.price_change_percentage_14d_in_currency?[coin2Symbol] : null;
        public decimal? price_change_percentage_30d_in_currency => coin1?.market_data?.price_change_24h_in_currency?.ContainsKey(coin2Symbol) ?? false ? coin1?.market_data?.price_change_24h_in_currency?[coin2Symbol] : null;
        public decimal? price_change_percentage_60d_in_currency => coin1?.market_data?.price_change_24h_in_currency?.ContainsKey(coin2Symbol) ?? false ? coin1?.market_data?.price_change_24h_in_currency?[coin2Symbol] : null;
        public decimal? price_change_percentage_200d_in_currency => coin1?.market_data?.price_change_24h_in_currency?.ContainsKey(coin2Symbol) ?? false ? coin1?.market_data?.price_change_percentage_1h_in_currency?[coin2Symbol] : null;
        public decimal? price_change_percentage_1y_in_currency => coin1?.market_data?.price_change_percentage_1h_in_currency?.ContainsKey(coin2Symbol) ?? false ? coin1?.market_data?.price_change_percentage_24h_in_currency?[coin2Symbol] : null;
        public decimal? market_cap_change_24h_in_currency => coin1?.market_data?.price_change_percentage_24h_in_currency?.ContainsKey(coin2Symbol) ?? false ? coin1?.market_data?.price_change_percentage_7d_in_currency?[coin2Symbol] : null;
        public decimal? market_cap_change_percentage_24h_in_currency => coin1?.market_data?.price_change_percentage_7d_in_currency?.ContainsKey(coin2Symbol) ?? false ? coin1?.market_data?.price_change_24h_in_currency?[coin2Symbol] : null;
        public decimal? total_supply => coin1?.market_data?.total_supply;
        public decimal? max_supply => coin1?.market_data?.max_supply;
        public decimal? circulating_supply => coin1?.market_data?.circulating_supply;
        public DateTime? last_updated => coin1?.market_data?.last_updated;
    }
}