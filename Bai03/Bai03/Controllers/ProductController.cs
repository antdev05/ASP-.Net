using Bai03.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bai03.Controllers
{
    public class ProductController : Controller
    {
        public static List<product> products = new List<product>()
        {
            new product(){id = 1, name = "Iphone", price = 200, description = "Dien thoai Iphone 18 Pro MAX"},
            new product(){id = 1, name = "SamSung", price = 150, description = "Dien Thoai SamSung FLip 9s"}
        };
        [HttpGet]
        // GET: ProductController
        public ActionResult Index()
        {
            return View(products);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(product prod)
        {
            products.Add(prod);
            return RedirectToAction(nameof(Index));
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            var edit_prod = products.FirstOrDefault(c => c.id == id);
            if(edit_prod == null)
            {
                return NotFound();

            }
            return View(edit_prod);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(product prod)
        {
            var prod_ton_tai = products.FirstOrDefault(c => c.id == prod.id);
            if(prod_ton_tai == null)
            {
                return NotFound();
            }
            prod_ton_tai.name = prod.name;
            return RedirectToAction(nameof(Index));
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteComfirm(int id)
        {
            var prod = products.FirstOrDefault(c => c.id == id);
            if (prod == null)
            {
                return NotFound();

            }
            products.Remove(prod);
            return RedirectToAction(nameof(Index));
        }
    }
}
