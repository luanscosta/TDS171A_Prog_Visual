using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDS171A_Diogo.Models;

namespace TDS171A_Diogo.Controllers
{
    public class CategoriesController : Controller
    {
        private static IList<Category> categoryList = new List<Category>() {
            new Category() { CategoryId = 1, Name = "Ruivas", Description = "Mulheres tocadas pelo fogo" },
            new Category() { CategoryId = 2, Name = "Morenas", Description = "Mulheres do jeito certo" },
            new Category() { CategoryId = 3, Name = "Loiras", Description = "Mulheres meh......" }
        };

        // GET: Categories
        public ActionResult Index()
        {
            return View(categoryList.OrderBy(c => c.Name));
        }

        public ActionResult Create()
        {
            return View();
        }

        // {CategoryId:0, Name:"Cat1"} 
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create (Category category)
        {
            categoryList.Add(category);
            category.CategoryId =
                categoryList.Max(c => c.CategoryId) + 1;
            return RedirectToAction("Index");
        }
        public ActionResult Details(long id)
        {
            var category = categoryList
                .Where(c => c.CategoryId == id)
                .First();

         //   category = category
           //     .First(c => c.CategoryId == id);

            return View(category);
        }

        public ActionResult Edit (long id)
        {
            var category = categoryList
                .Where(c => c.CategoryId == id)
                .First();
                return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(Category modified)
        {
            var category = categoryList
                 .Where(c => c.CategoryId == modified.CategoryId)
                 .First();

            category.Name = modified.Name;
            category.Description = modified.Description;

            return RedirectToAction("Index");
        }

        public ActionResult Delete (long id)
        {
            var category = categoryList
                .Where(c => c.CategoryId == id)
                .First();
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Delete (Category toDelete)
        {
            var category = categoryList
                 .Where(c => c.CategoryId == toDelete.CategoryId)
                 .First();

            categoryList.Remove(category);

            return RedirectToAction("Index");
        }
    }
}