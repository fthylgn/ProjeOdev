using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IExamDal : IGenericDal<Exam>
    {
        Exam GetByIDWithArticle(int id);
        Exam GetByIDWithFullContent(int id);

        List<Exam> GetListWithArticle();
    }
}
