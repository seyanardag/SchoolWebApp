using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUI.CustomServices.Abstract
{
    public interface IFileUploadService
    {
        Task<string> UploadFileAsync(IFormFile file, string? folderPath);
        Task DeleteFileAsync(string? filePath);
        Task<string> UpdateFileAsync(IFormFile newFile, string? existingFilePath, string? folderPath);

    }
}
