using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcArticle.Models;

namespace MvcArticle.Controllers
{
    public class ArticleController : Controller
    {
        public List<Article> Articles { get; set; }

        public ArticleController()
        {
            Articles = new List<Article>();
            Articles.Add(new Article(0, "Titre article", "Contenu article"));
        }

        // GET: ArticleController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ArticleController/Details/5
        public ActionResult Details(int id)
        {
            Article article = Articles.First(article => article.id == id);
            return View(article);
        }

        // GET: ArticleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArticleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ArticleController/Edit/5
        public ActionResult Edit(int id)
        {
            Article article = Articles.First(article => article.id == id);
            return View(article);
        }

        // POST: ArticleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ArticleController/Delete/5
        public ActionResult Delete(int id)
        {
            Article article = Articles.First(article => article.id == id);
            return View(article);
        }

        // POST: ArticleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
