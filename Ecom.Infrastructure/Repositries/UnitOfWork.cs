using AutoMapper;
using Ecom.Core.interfaces;
using Ecom.Core.Services;
using Ecom.Infrastructure.Data;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Infrastructure.Repositries
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IImageManagementService _imageManagementService;
        private readonly IConnectionMultiplexer redis;

        public IProductRepositry ProductRepositry { get; }

        public IGategoryRepositry CategoryRepositry { get; }

        public IPhotoRepositry PhotoRepositry { get; }

        public ICustomerBasketRepositry CustomerBasket { get; }

        public UnitOfWork(AppDbContext context, IMapper mapper, IImageManagementService imageManagementService ,IConnectionMultiplexer redis)
        {
            _context = context;
            _mapper = mapper;
            _imageManagementService = imageManagementService;
            this.redis = redis;
            CategoryRepositry = new GategoryRepositry(_context);
            ProductRepositry = new ProductRepositry(_context , _mapper , _imageManagementService);
            PhotoRepositry = new PhotoRepositry(_context);
            CustomerBasket = new CustomerBasketRepositry(redis);


        }
    }
}