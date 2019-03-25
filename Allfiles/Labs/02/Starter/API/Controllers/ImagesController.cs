using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("/")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private HttpClient _httpClient;
        private Options _options;

        public ImagesController(HttpClient httpClient, Options options)
        {
            _httpClient = httpClient;
            _options = options;
        }

        private async Task<CloudBlobContainer> GetCloudBlobContainer(string containerName)
        {
            CloudStorageAccount account = CloudStorageAccount.Parse(_options.StorageConnectionString);
            CloudBlobClient blobClient = account.CreateCloudBlobClient();
            CloudBlobContainer container = blobClient.GetContainerReference(containerName);
            await container.CreateIfNotExistsAsync();
            return container;
        }

        [Route("/")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            CloudBlobContainer container = await GetCloudBlobContainer(_options.FullImageContainerName);
            BlobContinuationToken continuationToken = null;
            List<IListBlobItem> results = new List<IListBlobItem>();
            do
            {
                var response = await container.ListBlobsSegmentedAsync(continuationToken);
                continuationToken = response.ContinuationToken;
                results.AddRange(response.Results);
            }
            while (continuationToken != null);
            Console.Out.WriteLine("Got Images");
            return Ok(results.Select(blob => blob.Uri.AbsoluteUri));
        }

        [Route("/thumbs")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> GetThumbs()
        {
            CloudBlobContainer container = await GetCloudBlobContainer(_options.ThumbnailImageContainerName);
            BlobContinuationToken continuationToken = null;
            List<IListBlobItem> results = new List<IListBlobItem>();
            do
            {
                var response = await container.ListBlobsSegmentedAsync(continuationToken);
                continuationToken = response.ContinuationToken;
                results.AddRange(response.Results);
            }
            while (continuationToken != null);
            Console.Out.WriteLine("Got Thumbs");
            return Ok(results.Select(blob => blob.Uri.AbsoluteUri));
        }

        [Route("/")]
        [HttpPost]
        public async Task<ActionResult> Post()
        {
            Stream image = Request.Body;
            CloudBlobContainer container = await GetCloudBlobContainer(_options.FullImageContainerName);
            string blobName = Guid.NewGuid().ToString().ToLower().Replace("-", String.Empty);
            CloudBlockBlob blockBlob = container.GetBlockBlobReference(blobName);
            await blockBlob.UploadFromStreamAsync(image);
            return Created(blockBlob.Uri, null);
        }
    }
}