using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_System
{
    internal class TrueOrFalse : Question
    {
        public TrueOrFalse(string header, string body, int mark, Answers[] answerList, Answers rightAnswer) : base(header, body, mark, answerList, rightAnswer)
        {
            
        }
    }
}
