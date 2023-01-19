using CryptoCoinAPI;
using DobriyCoder.Core.Exceptions;
using Flurl.Http;

Coingecko coingecko = new Coingecko();

//var coin = await coingecko.GetCoin("bitcoin");
//coin.PrintAsJson();

//var coinList = await coingecko.GetCoins(new List<string> { "bitcoin", "darkknight", "01coin" });
//foreach (var coin in coinList)
//    coin.PrintAsJson();

var pair = await coingecko.GetPair("bitcoin-bnb");
pair.PrintAsJson();

//var pair = await coingecko.GetPairs(new List<string> { "bitcoin-bnb", "bitcoin-eth" });
//pair.PrintAsJson();

/////////////////////////////////////////////////////////////

CoinMarketCapClient coinMarketCap = new CoinMarketCapClient();

//var coin = await coinMarketCap.GetCoin("BTC");
//coin.PrintAsJson();

//var coinList = await coinMarketCap.GetCoins(new List<string> { "BTC", "ETH"});
//foreach (var coin in coinList)
//    coin.PrintAsJson();

//var pair = await coinMarketCap.GetPair("BTC-usd");
//pair.PrintAsJson();

//var pair = await coinMarketCap.GetPairs(new List<string> { "btc-bnb", "btc-eth" });
//pair.PrintAsJson();