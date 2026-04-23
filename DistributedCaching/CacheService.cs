using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributedCaching;

public class CacheService
{
    private readonly IDistributedCache _cache;
    public CacheService(IDistributedCache cache)
    {
        _cache = cache;
    }

    public async Task SetCacheAsync(string key, string value, TimeSpan expiration)
    {
        var options = new DistributedCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = expiration
        };
        await _cache.SetStringAsync(key, value, options);
    }

    public async Task<string> GetCacheAsync(string key)
    {
        return await _cache.GetStringAsync(key);
    }

    public async Task SetSqlCacheAsync(string key, string value, TimeSpan expiration)
    {
        var options = new DistributedCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = expiration
        };
        await _cache.SetStringAsync(key, value, options);
    }

    public async Task<string> GetSqlCacheAsync(string key)
    {
        return await _cache.GetStringAsync(key);
    }
}
