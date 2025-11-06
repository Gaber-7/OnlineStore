using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Core.Entites.Product
{
    public class Category : BaseEntity<int> // this is parent class
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
