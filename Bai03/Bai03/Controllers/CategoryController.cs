using Bai03.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Bai03.Controllers
{
    public class CategoryController : Controller
    {
        public static List<Category> categorys = new List<Category>()
        {
            new Category(){id = 1, name = "em Nam"},
            new Category(){id = 2, name = "em Hoa" }
        };
        // GET: CategoryController
        [HttpGet]
        public ActionResult Index()
        {
            return View(categorys);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category cate)
        {
            categorys.Add(cate);
            return RedirectToAction(nameof(Index));
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            var EditCategory = categorys.FirstOrDefault(c => c.id == id);
            if(EditCategory == null)
            {
                return NotFound();
            }
            return View(EditCategory);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category cate)
        {
            var existingCategory = categorys.FirstOrDefault(c => c.id == cate.id);
            if(existingCategory == null)
            {
                return NotFound();

            }
            existingCategory.name = cate.name;
            return RedirectToAction(nameof(Index));
            
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoryController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
    
        public ActionResult DeleteComfirm(int id)
        {
            var category = categorys.FirstOrDefault(c => c.id == id);
            if(category == null)
            {
                return NotFound();
            }
            categorys.Remove(category);
            return RedirectToAction(nameof(Index));

        }
    }
}
