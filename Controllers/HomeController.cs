using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        // Fields and Properties
        private IProductRepository _repository; // fields _field   so we know its not a parameter like below. 

        //Constructors 
        public HomeController(IProductRepository repository) // give me an IProductReposity , actually a FakeProductRepository. Look in Startup.cs you'll see it. 
                                                             // dependency injection
                                                             // inversion of control 
        {
            _repository = repository; // _repository field becomes the parameter passed in.
        }


        // Methods 
        public IActionResult Index()
        {
            IQueryable<Product> allProducts = _repository.GetAllProducts(); //  another example is if we create field  string name = sdlfkja; string has many different methods loaded with it. 
            return View(allProducts);
        }
    }
}
