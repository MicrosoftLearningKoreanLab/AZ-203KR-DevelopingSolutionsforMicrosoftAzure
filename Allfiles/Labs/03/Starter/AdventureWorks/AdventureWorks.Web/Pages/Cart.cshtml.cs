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
    public class Cart : PageModel
    {
        private readonly Settings _settings;
        private readonly IAdventureWorksProductContext _productContext;
        private readonly IAdventureWorksCheckoutContext _checkoutContext;

        public Cart(IOptions<Settings> settings, IAdventureWorksProductContext productContext, IAdventureWorksCheckoutContext checkoutContext)
        {
            _settings = settings.Value;
            _productContext = productContext;
            _checkoutContext = checkoutContext;
        }

        [BindProperty]
        public List<Product> Products { get; set; } = new List<Product>();

        public async Task OnGetAsync(Guid? add)
        {
            if (_settings.CartAvailable)
            {
                if (add.HasValue)
                {
                    Product product = await _productContext.FindProductAsync(add.Value);
                    await _checkoutContext.AddProductToCartAsync(_settings.UniqueIdentifier, product);
                }
                this.Products = await _checkoutContext.GetProductsInCartAsync(_settings.UniqueIdentifier);
            }
        }

        public async Task<ActionResult> OnPostClearAsync()
        {
            await _checkoutContext.ClearCart(_settings.UniqueIdentifier);
            return Page();
        }

        public ActionResult OnPostCheckout()
        {
            return RedirectToPage(nameof(Checkout));
        }
    }
}