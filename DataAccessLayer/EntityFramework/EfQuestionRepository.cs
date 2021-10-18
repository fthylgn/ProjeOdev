using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfQuestionRepository : GenericRepository<Question>, IQuestionDal
    {
        public List<Question> GetAllQuestionByArticleID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Question> GetAllQuestionWithArticle(int id)
        {
            throw new NotImplementedException();
        }
    }
}
