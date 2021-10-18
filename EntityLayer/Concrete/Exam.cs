using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Exam
    {
        [Key]
        public int ExamID{ get; set; }
        public DateTime AddTime{ get; set; }

        public int ArticleID { get; set; }
        public Article Article { get; set; }
        public List<Question> Questions { get; set; }
    }
}
