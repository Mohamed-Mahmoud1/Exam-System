using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_System
{
    public abstract class Question
    {

        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answers[] AnswerList { get; set; }
        public Answers RightAnswer { get; set; }
        public Question(string header, string body, int mark, Answers[] answerList, Answers rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = answerList;
            RightAnswer = rightAnswer;
        }

        public virtual void ShowQuestion()
        {
            Console.WriteLine(Header);
            Console.WriteLine(Body);
            Console.WriteLine($"Mark: {Mark}");

            for (int i = 0; i < AnswerList.Length; i++)
            {
                Console.WriteLine(AnswerList[i]);
            }
        }

      

    }

}


