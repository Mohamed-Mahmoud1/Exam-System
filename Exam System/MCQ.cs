using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_System
{
    public class MCQ : Question
    {
        public MCQ(string header, string body, int mark, Answers[] answerList, Answers rightAnswer) :base(header, body, mark, answerList, rightAnswer)
        {
            
        }

    }
}
