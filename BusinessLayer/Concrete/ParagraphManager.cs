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
    public class ParagraphManager : IParagraphService
    {
        IParagraphDal _paragraphDal;

        public ParagraphManager(IParagraphDal paragraphDal)
        {
            _paragraphDal = paragraphDal;
        }

        public Paragraph GetByID(int id)
        {
            return _paragraphDal.GetByID(id);
        }

        public List<Paragraph> GetList()
        {
            return _paragraphDal.GetListAll();
        }

        public void ParagraphAdd(Paragraph paragraph)
        {
            _paragraphDal.Insert(paragraph);
        }

        public void ParagraphDelete(Paragraph paragraph)
        {
            _paragraphDal.Delete(paragraph);
        }

        public void ParagraphUpdate(Paragraph paragraph)
        {
            _paragraphDal.Update(paragraph);
        }
    }
}
