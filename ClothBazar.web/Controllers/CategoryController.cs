using ClothBazar.Entities;
using ClothBazar.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothBazar.web.Controllers
{
    public class CategoryController : Controller
    {
        CategoriesService CategoriesService = new CategoriesService();

        [HttpGet]
        public ActionResult Index()
        {
            var categories = CategoriesService.GetCategories();
            return View(categories);
        }
        // GET: Category
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category Category)
        {
            CategoriesService.SaveCategory(Category);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var category = CategoriesService.GetCategory(id);
            return View(category);
        }
        [HttpPost]
        public ActionResult edit(Category Category)
        {
            CategoriesService.EditCategory(Category);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var category = CategoriesService.GetCategory(id);
            return View(category);
        }
        [HttpPost]
        public ActionResult Delete(Category Category)
        {
            var category = CategoriesService.GetCategory(Category.ID);
            //var category=cont
            CategoriesService.deleteCategory(category.ID);

            return RedirectToAction("Index");
        }
    }
}