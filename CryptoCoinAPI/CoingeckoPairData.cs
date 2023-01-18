namespace CryptoCoinAPI
{
    public class CoingeckoPairData
    {
        public class Rootobject
        {
            public Bitcoin bitcoin { get; set; }
            public Ethereum ethereum { get; set; }
        }

        public class Bitcoin
        {
            public int btc { get; set; }
            public float eth { get; set; }
        }

        public class Ethereum
        {
            public float btc { get; set; }
            public int eth { get; set; }
        }

    }
}
