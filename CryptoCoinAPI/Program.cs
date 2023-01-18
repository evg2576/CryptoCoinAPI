//по классу на каждое апи

//    по 4 метода 
//    GetCoin(string id монеты)
//    GetCoins(List ) return list
//    GetPair(string айди монентной пары)
//    GetPairs(list)
// use ierrors! out argument metoda

using CryptoCoinAPI;
using DobriyCoder.Core.Common;
using DobriyCoder.Core.Exceptions;
using System.Net.Http.Json;
using System.Net;
using Flurl.Http;
using System.Web;
using System;
using System.Text;

Coingecko coingecko = new Coingecko();

//var coin = await coingecko.GetCoin("bitcoin");
//    coin.PrintAsJson();

var coinList = await coingecko.GetCoins(new List<string> { "bitcoin", "darkknight", "01coin" });
foreach (var coin in coinList)
    coin.PrintAsJson();

//////////////////////////////////

//var pair = Coingecko.GetPair("bitcoin, bnb", out IErrors? errors);
//if (errors is not null)
//    pair.PrintAsJson();

/// ///////////////////////////////////////

//string API_KEY = "b54bcf4d-1bca-4e8e-9a24-22ff2c3d462c";

//var headers = new Dictionary<string, string>();
//headers.Add("X-CMC_PRO_API_KEY", API_KEY);
//headers.Add("Accept", "application/json");

//var query = new Dictionary<string, string>();
//query.Add("start", "1");
//query.Add("limit", "5000");
//query.Add("convert", "USD");

//var res = APIHandler<object>.GetDataAsync("https://sandbox-api.coinmarketcap.com/v1/cryptocurrency/listings/latest", headers: headers, queryParameters: query);
//res.PrintAsJson();

//var result = await "https://sandbox-api.coinmarketcap.com/v1/cryptocurrency/listings/latest"
//    .WithHeader("Accept", "application/json")
//    .WithHeader("X-CMC_PRO_API_KEY", API_KEY)
//    .SetQueryParams(query)
//    .GetAsync()
//    .ReceiveJson();
//result.PrintAsJson();


//class CSharpExample
//{
//    private static string API_KEY = "b6a54e2d-2076-4929-ac2c-b48e1aa5bd7d";

//    public static void Main(string[] args)
//    {
//        try
//        {
//            Console.WriteLine(makeAPICall());
//        }
//        catch (WebException e)
//        {
//            Console.WriteLine(e.Message);
//        }
//    }

//    static string makeAPICall()
//    {
//        var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v1/cryptocurrency/map");
//        var queryString = HttpUtility.ParseQueryString(string.Empty);
//        queryString["limit"] = "1000";


//        queryString["symbol"] = "BTC,ETH";
//        //queryString["convert"] = "USD";

//        URL.Query = queryString.ToString();

//        var client = new WebClient();
//        client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
//        client.Headers.Add("Accepts", "application/json");
//        return client.DownloadString(URL.ToString());

//    }

//}