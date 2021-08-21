using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class EfProductRepository : IProductRepository
    {
        // F i e l d s & P r o p e r t i e s 
        private MagicDbClass _magicDb;  // this field is holdng 

        // C o n s t r u c t o r s 
        public EfProductRepository(MagicDbClass magicDb) // every time we create an EfProductRepository the constructor is called ONCE 
        {
            _magicDb = magicDb;         // MagicDbClass contains the getters and setters to to return product objects to and from the base class is which is 
        }                                                   // DbContext a hidden class we dont know how it configures these classes yet. 

        // M e t h o d s 
        public IQueryable<Product> GetAllProducts()  // we are returning an IQueryable array of Product Objects
        {
            return _magicDb.Products; // products is in the magicDb class // 1hr50min in the video  
        }                       //  ij this class EfProductRepository we have _magicDb field that is saving 
    }
}
