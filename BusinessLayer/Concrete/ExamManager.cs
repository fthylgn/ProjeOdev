using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ExamManager : IExamService
    {
        IExamDal _examDal;

        public ExamManager(IExamDal examDal)
        {
            _examDal = examDal;
        }

        public Exam GetByID(int id)
        {
            return _examDal.GetByID(id);
        }

        public List<Exam> GetList()
        {
            return _examDal.GetListAll();
        }

        public void ExamAdd(Exam exam)
        {
            _examDal.Insert(exam);
        }

        public void ExamDelete(Exam exam)
        {
            _examDal.Delete(exam);
        }

        public void ExamUpdate(Exam exam)
        {
            _examDal.Update(exam);
        }

        public Exam GetByIDWithFullContent(int id)
        {
            return _examDal.GetByIDWithFullContent(id);
        }

        public Exam GetByIDWithArticle(int id)
        {
            return _examDal.GetByIDWithArticle(id);
        }

        public List<Exam> GetListWithArticle()
        {
            return _examDal.GetListWithArticle();
        }
    }
}
