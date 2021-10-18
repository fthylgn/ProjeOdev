using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IExamService
    {
        void ExamAdd(Exam exam);
        void ExamDelete(Exam exam);
        void ExamUpdate(Exam exam);
        List<Exam> GetList();
        Exam GetByID(int id);
        Exam GetByIDWithFullContent(int id);
        Exam GetByIDWithArticle(int id);
        List<Exam> GetListWithArticle();
    }
}
