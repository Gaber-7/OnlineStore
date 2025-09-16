using Ecom.Core.Services;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Infrastructure.Service
{
    public class ImageManagementService : IImageManagementService
    {
        private readonly IFormatProvider _formatProvider;
        public ImageManagementService(IFormatProvider formatProvider)
        {
            _formatProvider = formatProvider;
        }
        public Task<List<string>> AddImageAsync(IFormFileCollection files, string Src)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteImageAsync(string Src)
        {
            throw new NotImplementedException();
        }
    }
}
