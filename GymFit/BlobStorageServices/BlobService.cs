using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.BlobStorageServices
{
    public class BlobService:IBlobService
    {


        private readonly BlobServiceClient _blobServiceClient;

        public BlobService(BlobServiceClient blobServiceClient)
        {
            _blobServiceClient = blobServiceClient;
        }

        public async Task<string> UploadFileBlobAsync(IFormFile file, string filename)
        {

            BlobContainerClient containerClient = _blobServiceClient.GetBlobContainerClient("productimagesgym");



            await containerClient.UploadBlobAsync(filename, file.OpenReadStream());

            return containerClient.Uri.AbsoluteUri + $"/{filename}";




        }


    }
}
