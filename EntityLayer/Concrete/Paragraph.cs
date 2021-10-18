using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Paragraph
    {
        public int ParagraphID { get; set; }
        public string ParagraphText { get; set; }
        
        public int ArticleID { get; set; }
        public Article Article { get; set; }
    }
}
