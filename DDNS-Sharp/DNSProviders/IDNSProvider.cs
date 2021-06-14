
using System;

namespace DDNS_Sharp.DNSProviders
{
    public interface IDNSProvider
    {
        public string AccessId { get; set; }
        public string AccessToken { get; set; }

    }
}