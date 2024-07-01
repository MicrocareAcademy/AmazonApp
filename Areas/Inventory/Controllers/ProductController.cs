using AmazonApp.Areas.Inventory.Models;
using AmazonApp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AmazonApp.Areas.Inventory.Controllers
{
    [Area("Inventory")]
    public class ProductController : Controller
    {
        AmazonDBContext dBContext = new AmazonDBContext();

        public IActionResult ProductsList()
        {
            var products = dBContext.Products.ToList();
            return View(products);
        }

        public IActionResult AddProduct(AddProductModel model)
        {
            var product = new Product();

            product.Name = model.Name;
            product.Price = model.Price;
            product.Category = model.Category;

            dBContext.Products.Add(product);

            return View(model);
        }
        [HttpPost]
        public IActionResult SaveProduct(AddProductModel model)
        {
            var product = new Product();
            product.Name = model.Name;
            product.Price = model.Price;
            product.Category = model.Category;

            dBContext.Products.Add(product);
            dBContext.SaveChanges();
            return RedirectToAction("ProductsList");
        }
        public IActionResult EditProduct(int Id)
        {
            var productObj = dBContext.Products.FirstOrDefault(p => p.Id == Id);

            var model = new AddProductModel();
            model.Id = productObj.Id;
            model.Name = productObj.Name;
            model.Category = productObj.Category;
            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateProduct(AddProductModel model)
        {
            var productObj = dBContext.Products.Where(p => p.Id == model.Id).FirstOrDefault();
            productObj.Name = model.Name;
            productObj.Id = model.Id;
            productObj.Category = model.Category;
            dBContext.Products.Update(productObj);
            dBContext.SaveChanges();
            return RedirectToAction("ProductsList");


        }

        [HttpPost]
        public IActionResult DeleteProduct(int Id)
        {
            var productObj = dBContext.Products.Where(p => p.Id == Id).FirstOrDefault();
            dBContext.Products.Remove(productObj);
            dBContext.SaveChanges();
            return Json(true);
        }
    }


}
