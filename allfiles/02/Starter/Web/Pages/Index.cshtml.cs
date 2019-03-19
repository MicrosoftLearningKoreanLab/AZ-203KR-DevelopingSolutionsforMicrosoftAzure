using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Web.Pages
{
    public class IndexModel : PageModel
    {
        private HttpClient _httpClient;
        private Options _options;

        public List<string> ThumbnailImageList { get; private set; }

        public List<string> FullImageList { get; private set; }

        public IndexModel(HttpClient httpClient, Options options)
        {
            _httpClient = httpClient;
            _options = options;
        }

        public async Task OnGetAsync()
        {
            var imagesUrl = _options.ApiUrl;
            var thumbsUrl = Flurl.Url.Combine(imagesUrl, "/thumbs/");

            Task<string> getFullImages = _httpClient.GetStringAsync(imagesUrl);
            Task<string> getThumbnailImages = _httpClient.GetStringAsync(thumbsUrl);
            await Task.WhenAll(getFullImages);

            string fullImagesJson = getFullImages.Result;
            IEnumerable<string> fullImagesList = JsonConvert.DeserializeObject<IEnumerable<string>>(fullImagesJson);
            this.FullImageList = fullImagesList.ToList<string>();

            string thumbImagesJson = getThumbnailImages.Result;
            IEnumerable<string> thumbImagesList = JsonConvert.DeserializeObject<IEnumerable<string>>(thumbImagesJson);
            this.ThumbnailImageList = thumbImagesList.ToList<string>();
        }


        [BindProperty]
        public IFormFile Upload { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (Upload != null && Upload.Length > 0)
            {
                var imagesUrl = _options.ApiUrl;

                using (var image = new StreamContent(Upload.OpenReadStream()))
                {
                    image.Headers.ContentType = new MediaTypeHeaderValue(Upload.ContentType);
                    var response = await _httpClient.PostAsync(imagesUrl, image);
                }
            }
            return RedirectToPage("/Index");
        }
    }
}