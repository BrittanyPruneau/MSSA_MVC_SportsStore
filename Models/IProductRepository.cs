using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public interface IProductRepository
    {
        public IQueryable<Product> GetAllProducts(); // this is an Interface Method it expects to receive Queryable type of Product objects. "like an array"
    }
}


