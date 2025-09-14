using Ecom.Core.interfaces;
using Ecom.Infrastructure.Data;
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

        public IProductRepositry ProductRepositry { get; }

        public IGategoryRepositry CategoryRepositry { get; }

        public IPhotoRepositry PhotoRepositry { get; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            CategoryRepositry = new GategoryRepositry(_context);
            ProductRepositry = new ProductRepositry(_context);
            PhotoRepositry = new PhotoRepositry(_context);
        }
    }
}