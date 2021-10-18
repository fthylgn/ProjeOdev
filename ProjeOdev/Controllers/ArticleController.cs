using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace ProjeOdev.Controllers
{
    public class ArticleController : Controller
    {
        static ArticleManager manager = new ArticleManager(new EfArticleRepository());
        QuestionManager qmanager = new QuestionManager(new EfQuestionRepository());
        ExamManager examManager = new ExamManager(new EfExamRepository());

        static List<Article> articles;

        public IActionResult Index()
        {
            var art = manager.GetList();
            return View(art);
        }


        [HttpPost]
        public IActionResult Articles(ICollection<Question> qu)
        {
            if (qu is null)
            {
                throw new ArgumentNullException(nameof(qu));
            }
            
            Article art = articles.ElementAt((qu.ElementAt(0).ExamID));
            art.ArticleID = 0;
            manager.ArticleAdd(art);
            
            Exam ex = new Exam();
            ex.ArticleID = art.ArticleID;
            ex.AddTime = DateTime.Now;
            examManager.ExamAdd(ex);

            foreach (var item in qu)
            {
                item.ExamID = ex.ExamID;
                qmanager.QuestionAdd(item);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Articles()
        {
            articles = manager.GetLastArticles();
            return View(articles);
        }

        public IActionResult DeleteArticle(int id)
        {
            var article = manager.GetByID(id);
            manager.ArticleDelete(article);
            return RedirectToAction("Index");
        }
    }
}
