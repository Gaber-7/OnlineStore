using AutoMapper;
using Ecom.Core.DTO;
using Ecom.Core.Entites.Product;
using Ecom.Core.interfaces;
using Ecom.Core.Services;
using Ecom.Core.Sharing;
using Ecom.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ecom.Infrastructure.Repositries
{
    public class ProductRepositry : GenericRepositry<Product>, IProductRepositry
    {
        private readonly IImageManagementService imageManagementService;
        private readonly AppDbContext context;
        private readonly IMapper mapper;
        public ProductRepositry(AppDbContext context, IMapper mapper, IImageManagementService imageManagementService) : base(context)
        {
            this.imageManagementService = imageManagementService;
            this.context = context;
            this.mapper = mapper;
 
        }

        public async Task<IEnumerable<ProductDTO>> GetAllAsync(ProductParams productParams)    // Filter and sort products
        {
            var quary = context.Products
                .Include(p => p.Category)
                .Include(p => p.Photos)
                .AsNoTracking();

            // Filter by categoryId if provided
            if (productParams.categoryId.HasValue)
                quary = quary.Where(p => p.CategoryId == productParams.categoryId.Value);


                if (!string.IsNullOrEmpty(productParams.sort))
                {
                quary = productParams.sort switch
                {
                    "priceAsc" => quary.OrderBy(p => p.NewPrice),
                    "priceDesc" => quary.OrderByDescending(p => p.NewPrice),
                    _ => quary.OrderBy(p => p.Name),
                };
                }

         
            quary = quary.Skip((productParams.PageNumber - 1) * productParams.PageSize).Take(productParams.PageSize);   // Pagination

            var result = mapper.Map<List<ProductDTO>>(quary);
            return result;
        }


        public async Task<bool> AddAsync(AddProductDTO productDTO)              // Add a new product with images
        {
           if (productDTO is null) return false;
              var product = mapper.Map<Product>(productDTO);
            await context.Products.AddAsync(product);
            await context.SaveChangesAsync();
            // Save images and get their names..................
            var ImagePath = await imageManagementService.AddImageAsync(productDTO.Photo, productDTO.Name);   
            product.Photos = ImagePath.Select(path => new Photo        // Create Photo entities for each image name
            {
                ImageName = path,
                ProductId = product.Id
            }).ToList();                                 // Assign Photo entities to the product

            await context.AddRangeAsync(product.Photos);       // Add Photo entities to the context
            await context.SaveChangesAsync();
            return true;
        }     

        public async Task<bool> UpdateAsync(UpdateProductDTO updateProductDTO)            // Update an existing product and its images  
        {
           if (updateProductDTO is null)
           {
                return false;
           }
             var FindProduct = await context.Products.Include(m => m.Category)
                .Include(m => m.Photos)
                .FirstOrDefaultAsync(m => m.Id == updateProductDTO.Id);
           if (FindProduct is null)
           {
                return false;
           }
            mapper.Map(updateProductDTO, FindProduct);   // Map updated properties to the existing product
            var FindPhoto = await context.Photos.Where(m => m.ProductId == updateProductDTO.Id).ToListAsync();
            foreach (Photo item in FindPhoto)
            {
               imageManagementService.DeleteImageAsync(item.ImageName);
            }
            context.Photos.RemoveRange(FindPhoto);

            // Add new images
            var ImagePaths = await imageManagementService.AddImageAsync(updateProductDTO.Photo, updateProductDTO.Name);
            var Photos = ImagePaths.Select(path => new Photo
            {
                ImageName = path,
                ProductId = updateProductDTO.Id
            }).ToList();
            await context.Photos.AddRangeAsync(Photos);
            await context.SaveChangesAsync();

            return true;
        }    
        public async Task DeleteAsync(Product product)
        {

            var photo = await context.Photos.Where(m => m.ProductId == product.Id).ToListAsync();   // get all photos related to the product

            foreach (var item in photo)
            {
                imageManagementService.DeleteImageAsync(item.ImageName);   // delete each photo from storage
            }
            context.Photos.RemoveRange(photo);  // remove photo records from database
            context.Products.Remove(product);   // remove the product record from database
            await context.SaveChangesAsync();   // save changes to database
        }
    }
}
