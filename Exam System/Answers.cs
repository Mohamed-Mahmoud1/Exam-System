using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_System
{
    public class Answers
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answers(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }

  
        public override string ToString()
        {
            return $"{AnswerId}, {AnswerText}";
        }

    }
}
