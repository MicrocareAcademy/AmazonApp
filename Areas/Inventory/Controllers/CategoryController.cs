//using Microsoft.AspNetCore.Mvc;
//using AmazonApp.Entities;

//using Microsoft.EntityFrameworkCore;
//using AmazonApp.Areas.Inventory.Models;



//namespace AmazonApp.Areas.Inventory.Controllers
//{
//    [Area("Inventory")]
//    public class CategoryController : Controller
//    {
//        AmazonDBContext dBContext = new AmazonDBContext();

//        public IActionResult CategoriesList()
//        {
//            var categories = dBContext.Categories.ToList();

//            return View("CategoriesList");
//        }

//        public IActionResult AddCategory(AddCategoryModel model)
//        {
//            var category = new Category();

//            category.CategoryId = model.CategoryId;
//            category.CategoryName = model.CategoryName;
//            category.CategoryDescription = model.CategoryDescription;
//            category.CategoryStatus = model.CategoryStatus;


//            dBContext.Categories.Add(category);

//            return View(model);
//        }
//        [HttpPost]
//        public IActionResult SaveCategory(AddCategoryModel model)
//        {
//            var category = new Category();
//            category.CategoryId = model.CategoryId;
//            category.CategoryName = model.CategoryName;
//            category.CategoryDescription = model.CategoryDescription;
//            category.CategoryStatus = model.CategoryStatus;
            

//            dBContext.Categories.Add(category);
//            dBContext.SaveChanges();
//            return RedirectToAction("CategoriesList");
//        }

//        public IActionResult EditCategory(int CategoryId)
//        {
//            var categoryObj = dBContext.Categories.FirstOrDefault(p => p.CategoryId == CategoryId);

//            var model = new AddCategoryModel();
//            model.CategoryId = categoryObj.CategoryId;
//            model.CategoryName = categoryObj.CategoryName;
//            model.CategoryDescription = categoryObj.CategoryDescription;
//            model.CategoryStatus = categoryObj.CategoryStatus;
          
//            return View(model);
//        }

//        [HttpPost]
//        public IActionResult UpdateCategory(AddCategoryModel model)
//        {
//            var categoryObj = dBContext.Categories.Where(p => p.CategoryId == model.CategoryId).FirstOrDefault();
//            categoryObj.CategoryName = model.CategoryName;
//            categoryObj.CategoryDescription = model.CategoryDescription;
//            categoryObj.CategoryStatus = model.CategoryStatus;

//            dBContext.SaveChanges();
//            return RedirectToAction("CategoriesList");

//        }

//        [HttpPost]
//        public IActionResult DeleteCategory(int CategoryId)
//        {
//            var categoryObj = dBContext.Categories.Where(p => p.CategoryId == CategoryId  ).FirstOrDefault();
//            dBContext.Categories.Remove(categoryObj);
//            dBContext.SaveChanges();
//            return Json(true);
//        }
//    }
//}

