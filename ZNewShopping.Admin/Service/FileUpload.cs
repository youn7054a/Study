using BlazorInputFile;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ZNewShopping.Admin.Service
{
    public class FileUpload : IFileUpload
    {
        private readonly IWebHostEnvironment _environment;

        public FileUpload(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
        
        public async Task UploadAsync(IFileListEntry fileEntry)
        {
            try
            {
                //var path = Path.Combine(_environment.ContentRootPath, "Upload");
                var path = Path.Combine(@"3.34.209.209", "file");
                var ms = new MemoryStream();
                await fileEntry.Data.CopyToAsync(ms);
                using (FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    ms.WriteTo(file);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

        }

    }
}
