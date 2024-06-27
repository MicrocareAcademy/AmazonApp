﻿using Microsoft.AspNetCore.Mvc;

namespace AmazonApp.Areas.Inventory.Controllers
{
    [Area("Inventory")]
    public class CategoryController : Controller
    {
        public IActionResult GetCategories()
        {
            return View("CategoriesList");
        }

        public IActionResult GetElectronicsList()
        {
            return View("ViewElectronicsList");
        }

        public IActionResult GetClothingList()
        {
            return View("ViewClothingList");
        }

        public IActionResult GetFurnitureList()
        {
            return View("ViewFurnitureList");
        }
    }
}
