using StackExchange.Redis;

namespace MultiShop.Basket.Settings
{
    public class RedisService
    {
        public string _Host { get; set; }
        public int _port { get; set; }
        private ConnectionMultiplexer _connectionMultiplexer;

        public RedisService(string host, int port)
        {
            _Host = host;
            _port = port;
        }
        public void Connect() => _connectionMultiplexer = ConnectionMultiplexer.Connect($"{_Host}:{_port}");
        public IDatabase GetDb(int db = 1)=>_connectionMultiplexer.GetDatabase(0);
    }
}
