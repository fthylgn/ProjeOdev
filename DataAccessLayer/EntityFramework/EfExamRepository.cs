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
    public class EfExamRepository : GenericRepository<Exam>, IExamDal
    {
        public Exam GetByIDWithArticle(int id)
        {
            using (var c = new Context())
            {
                return c.Exams.Include(x => x.Article).Where(y => y.ExamID == id).FirstOrDefault();
            }
        }

        public Exam GetByIDWithFullContent(int id)
        {
            using (var c = new Context())
            {
                return c.Exams.Include(a => a.Questions).Include(x => x.Article).ThenInclude(y => y.Paragraphs).Where(y => y.ExamID == id).FirstOrDefault();
            }
        }

        public List<Exam> GetListWithArticle()
        {
            using (var c = new Context())
            {
                return c.Exams.Include(x => x.Article).ToList();
            }
        }
    }
}
