using AdventureWorks.Context;
using AdventureWorks.Models;
using AdventureWorks.Web.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdventureWorks.Web.Pages
{
    public class Checkout : PageModel
    {
        private readonly Settings _settings;
        private readonly IAdventureWorksCheckoutContext _checkoutContext;

        public Checkout(IOptions<Settings> settings, IAdventureWorksCheckoutContext checkoutContext)
        {
            _settings = settings.Value;
            _checkoutContext = checkoutContext;
        }

        [BindProperty]
        public Guid OrderNumber { get; set; } = Guid.Empty;

        [BindProperty]
        public List<Product> Products { get; set; } = new List<Product>();

        public async Task OnGetAsync()
        {
            if (_settings.CartAvailable)
            {
                var products = await _checkoutContext.GetProductsInCartAsync(_settings.UniqueIdentifier);
                await _checkoutContext.ClearCart(_settings.UniqueIdentifier);

                this.Products = products;
                this.OrderNumber = Guid.NewGuid();
            }
        }
    }
}