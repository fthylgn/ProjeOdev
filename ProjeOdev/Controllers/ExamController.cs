using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeOdev.Controllers
{
    public class ExamController : Controller
    {
        ExamManager examManager = new ExamManager(new EfExamRepository());

        public IActionResult Index()
        {
            var exams = examManager.GetListWithArticle();
            return View(exams);
        }

        public IActionResult Exam(int id)
        {
            var exam = examManager.GetByIDWithFullContent(1);
            return View(exam);
        }


        public  JsonResult GetResult(int id)
        {
            var exam = examManager.GetByIDWithFullContent(id);


            var result = (from x in exam.Questions
                            select new
                            {
                                Id = ""+x.QuestionID,
                                Value = x.TrueChoice
                            }).ToList();

            return new JsonResult(result);
        }

        public IActionResult DeleteExam(int id)
        {
            var exam = examManager.GetByID(id);
            examManager.ExamDelete(exam);
            return RedirectToAction("Index");
        }
    }
}
