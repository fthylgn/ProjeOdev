using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface IQuestionService
    {
        void QuestionAdd(Question question);
        void QuestionDelete(Question question);
        void QuestionUpdate(Question question);
        List<Question> GetList();
        Question GetByID(int id);

        List<Question> GetAllQuestionByArticleID(int id);
        List<Question> GetAllQuestionWithArticle(int id);
    }
}
