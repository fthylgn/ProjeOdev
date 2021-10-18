using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Article
    {
        public int ArticleID { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleUrl { get; set; }

        public List<Paragraph> Paragraphs { get; set; }
        public List<Exam> Exams { get; set; }
    }
}
