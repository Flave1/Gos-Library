using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GOSLibraries.Options
{
    public class RedisCacheSettings
    {
        public bool Enabled { get; set; }
        public string RedisConnectionString { get; set; }
    }

   
}
