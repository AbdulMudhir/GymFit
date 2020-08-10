using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.BlobStorageServices
{
    public interface IBlobService { 
       public Task<string> UploadFileBlobAsync(IFormFile file, string filename);

}
}
