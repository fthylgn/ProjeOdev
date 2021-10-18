using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IParagraphService
    {
        void ParagraphAdd(Paragraph paragraph);
        void ParagraphDelete(Paragraph paragraph);
        void ParagraphUpdate(Paragraph paragraph);
        List<Paragraph> GetList();
        Paragraph GetByID(int id);
    }
}
