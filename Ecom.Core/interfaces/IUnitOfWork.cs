using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Core.interfaces
{
    public interface IUnitOfWork 
    {
       public IProductRepositry ProductRepositry { get; }
       public IGategoryRepositry CategoryRepositry { get; }
       public IPhotoRepositry PhotoRepositry { get; }
    }
}
