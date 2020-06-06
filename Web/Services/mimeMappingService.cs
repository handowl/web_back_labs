using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.StaticFiles;

namespace Web.Services
{
    public class MimeMappingService
    {
        public String GetContentType(String extension)
        {
            var provider = new FileExtensionContentTypeProvider();
            return provider.TryGetContentType($"file.{extension}", out var result) ? result : "application/unknown";
        }
    }
}
