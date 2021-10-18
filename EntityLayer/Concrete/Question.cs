using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Question
    {
        public int QuestionID { get; set; }
        public string QuestionText { get; set; }
        public string ChoiceA { get; set; }
        public string ChoiceB { get; set; }
        public string ChoiceC { get; set; }
        public string ChoiceD { get; set; }
        public string TrueChoice { get; set; }

        public int ExamID { get; set; }
        public Exam Exam { get; set; }
    }
}
