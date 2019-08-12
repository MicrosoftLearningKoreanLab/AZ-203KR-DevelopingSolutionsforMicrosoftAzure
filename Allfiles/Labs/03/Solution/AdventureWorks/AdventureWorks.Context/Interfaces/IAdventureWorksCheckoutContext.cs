using AdventureWorks.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdventureWorks.Context
{
    public interface IAdventureWorksCheckoutContext
    {
        Task AddProductToCartAsync(string uniqueIdentifier, Product product);

        Task<List<Product>> GetProductsInCartAsync(string uniqueIdentifier);

        Task ClearCart(string uniqueIdentifier);
    }
}