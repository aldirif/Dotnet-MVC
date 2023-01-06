using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMvc.Models;


namespace WebMvc.Controllers
{
    public class ProductController : Controller
    {
        private static List<ProductViewModel> _productViewModels = new List<ProductViewModel>()
        {
            new ProductViewModel(1, "Juz Mangga", "Minuman", 10000),
            new ProductViewModel(2, "Juz Alpukat", "Minuman", 10000),
            new ProductViewModel(3, "Mie Goreng Tante (Tanpa Telor)", "Makanan", 7500),
            new ProductViewModel(4, "Mie Goreng Telor", "Makanan", 15000),
            new ProductViewModel(5, "Es Teh Manis", "Minuman", 4000),
            new ProductViewModel(6, "Es Jeruk", "Minuman", 5000),
            new ProductViewModel(7, "Es Dawet Ayu", "Minuman", 5000)
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("Id, Name, Category, Price")] ProductViewModel product)
        {
            _productViewModels.Add(product);
            return Redirect("List");
        }

        public IActionResult List()
        {
            return View(_productViewModels);
        }

        public IActionResult Edit(int? id)
        {
            // find with lambda
            ProductViewModel product = _productViewModels.Find(x => x.Id.Equals(id));
            return View(product);
        }

        [HttpPost]
        public IActionResult Update(int id, [Bind("Id, Name, Category, Price")] ProductViewModel product)
        {
            // hapus data lama
            ProductViewModel productOld = _productViewModels.Find(x => x.Id.Equals(id));
            _productViewModels.Remove(productOld);

            // input data baru
            _productViewModels.Add(product);
            return Redirect("List");
        }

        public IActionResult Details(int id)
        {
            // find with linq
            ProductViewModel product = (
                    from p in _productViewModels
                    where p.Id.Equals(id)
                    select p
                ).SingleOrDefault(new ProductViewModel());
            return View(product);
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            // find data dulu
            ProductViewModel product = _productViewModels.Find(x => x.Id.Equals(id));

            // remove from list
            _productViewModels.Remove(product);

            return Redirect("List");
        }
    }
}
