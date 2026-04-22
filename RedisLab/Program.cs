using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.StackExchangeRedis;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static async Task Main(string[] args)
    {
        var services = new ServiceCollection();
        services.AddStackExchangeRedisCache(options => {
            options.Configuration = "localhost:6379";
            options.InstanceName = "RedisInstance";

        });


        var provider = services.BuildServiceProvider();
        var cache = provider.GetService<IDistributedCache>();

        string cacheKey = "ProductList";
        string cacheData = await cache.GetStringAsync(cacheKey);

        if (cacheData == null)
        {
            Console.WriteLine("Cache Missed: Fetching from the database");
            var productData = new { 
                product_1 = "Product_1",
                product_2 = "Product_2",
                product_3 = "Product_3"
            };

            var options = new DistributedCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromMinutes(10));

            await cache.SetStringAsync(cacheKey, productData.ToString(), options);
            Console.WriteLine("Product Data has been stored in cache: " + productData);

            string cacheCounter = "SharedCounter";
            string cacheValue = await cache.GetStringAsync(cacheCounter);

            int counter = cacheValue != null ? int.Parse(cacheValue) : 0;
            counter++;

            await cache.SetStringAsync(cacheCounter, counter.ToString());
            Console.WriteLine($"Updated counter: {counter}");
        }
        else
        {
            Console.WriteLine("Cache Hit: " + cacheData);
        }
    }
}