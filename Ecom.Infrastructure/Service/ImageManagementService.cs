using Ecom.Core.Services;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.FileProviders;

namespace Ecom.Infrastructure.Service
{
    public class ImageManagementService : IImageManagementService
    {

        private readonly IFileProvider fileProvider;   // Dependency for file operations
        public ImageManagementService( IFileProvider fileProvider)      
        {
            this.fileProvider = fileProvider;
        }
        public async Task<List<string>> AddImageAsync(IFormFileCollection files, string Src)      // Method to add images
        {

            var SaveImageSrc = new List<string>();  // List to store the paths of saved images
            var ImageDirectory = Path.Combine("wwwroot", "Images", Src);   // Define the directory to save images
            if (!Directory.Exists(ImageDirectory))     // Check if the directory exists  ==  if(Directory.Exists(ImageDirectory) is not true)
            {
                Directory.CreateDirectory(ImageDirectory);
            }
            foreach (var item in files)    // Iterate through each file in the collection
            {
                if (item.Length > 0)   // Check if the file has content
                {
                    var ImageName = item.FileName;   // Get the file name
                    var ImageSrc = $"Images/{Src}/{ImageName}";   // Construct the relative path for the image
                   var root = Path.Combine(ImageDirectory, ImageName);   // Construct the full path for saving the image

                    using (var stream = new FileStream(root, FileMode.Create))   // Create a file stream to write the file
                    {
                        await item.CopyToAsync(stream);   // Copy the file content to the stream
                    }
                    SaveImageSrc.Add(ImageSrc);   // Add the relative path to the list
                }
            }
            return SaveImageSrc;   // Return the list of saved image paths

        }
        public void DeleteImageAsync(string Src)
        {
            var Info = fileProvider.GetFileInfo(Src);   // Get file information using IFileProvider
            var root = Info.PhysicalPath;          // Get the physical path of the file
            File.Delete(root);   // Delete the file from the file system 
        }
    }
}
