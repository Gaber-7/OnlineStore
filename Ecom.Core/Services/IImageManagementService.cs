using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Core.Services
{
    public interface IImageManagementService
    {
      Task<List<string>> AddImageAsync(IFormFileCollection files, string Src);      // Method to add images
      void DeleteImageAsync(string Src);             // Method to delete an image
    }
}
