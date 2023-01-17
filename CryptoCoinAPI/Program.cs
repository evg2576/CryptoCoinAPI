//по классу на каждое апи

//    по 4 метода 
//    GetCoin(string id монеты)
//    GetCoins(List ) return list
//    GetPair(string айди монентной пары)
//    GetPairs(list)
// use ierrors! out argument metoda

using CryptoCoinAPI;
using DobriyCoder.Core.Exceptions;

//var coin = Coingecko.GetCoin("bitcoin");
//coin.PrintAsJson();

var coinList = Coingecko.GetCoins(new List<string> { "bitcoin"/*, "darkknight" */});
foreach(var coin in coinList)
    coin.PrintAsJson();