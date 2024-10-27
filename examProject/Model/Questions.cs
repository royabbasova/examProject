using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examProject.Model
{
    internal class Questions
    {

        public string Text { get; set; }
        public List<string> Answers { get; set; }
        public int RightAnswerID { get; set; }
        public string Category { get; set; }

        public bool CheckRightAnswer(int answerId)
        {
            return answerId == RightAnswerID;
        }

    }
}
