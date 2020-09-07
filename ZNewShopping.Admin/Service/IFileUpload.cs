﻿using BlazorInputFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZNewShopping.Admin.Service
{
    public interface IFileUpload
    {
        Task UploadAsync(IFileListEntry file);
    }
}
