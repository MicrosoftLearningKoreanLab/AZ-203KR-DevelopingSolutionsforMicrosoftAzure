using AdventureWorks.Models;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorks.Context
{
    public class AdventureWorksRedisContext : IAdventureWorksCheckoutContext
    {
        private readonly IDatabase _database;

        public AdventureWorksRedisContext(string connectionString)
        {
            ConnectionMultiplexer connection = ConnectionMultiplexer.Connect(connectionString);
            _database = connection.GetDatabase();
        }

        public async Task AddProductToCartAsync(string uniqueIdentifier, Product product)
        {
            RedisValue result = await _database.StringGetAsync(uniqueIdentifier);
            List<Product> products = new List<Product>();
            if (!result.IsNullOrEmpty)
            {
                List<Product> parsed = JsonConvert.DeserializeObject<List<Product>>(result.ToString());
                products.AddRange(parsed);
            }
            products.Add(product);
            string json = JsonConvert.SerializeObject(products);
            await _database.StringSetAsync(uniqueIdentifier, json);
        }

        public async Task<List<Product>> GetProductsInCartAsync(string uniqueIdentifier)
        {
            string json = await _database.StringGetAsync(uniqueIdentifier);
            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(json ?? "[]");            
            return products;
        }

        public async Task ClearCart(string uniqueIdentifier)
        {
            await _database.KeyDeleteAsync(uniqueIdentifier);
        }
    }
}