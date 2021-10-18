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
    public class QuestionManager : IQuestionService
    {
        IQuestionDal _questionDal;

        public QuestionManager(IQuestionDal questionDal)
        {
            _questionDal = questionDal;
        }

        public List<Question> GetAllQuestionByArticleID(int id)
        {
            return _questionDal.GetAllQuestionByArticleID(id);
        }

        public List<Question> GetAllQuestionWithArticle(int id)
        {
            return _questionDal.GetAllQuestionWithArticle(id);
        }

        public Question GetByID(int id)
        {
            return _questionDal.GetByID(id);
        }

        public List<Question> GetList()
        {
            return _questionDal.GetListAll();
        }

        public void QuestionAdd(Question question)
        {
            _questionDal.Insert(question);
        }

        public void QuestionDelete(Question question)
        {
            _questionDal.Delete(question);
        }

        public void QuestionUpdate(Question question)
        {
            _questionDal.Update(question);
        }
    }
}
