using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_System
{
    public class Practical : Exam
    {
        public Practical(int time, int numberOfQuestions, Question[] questions) : base(time, numberOfQuestions, questions)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam");
            Console.WriteLine($"Time:  {Time}");
            Console.WriteLine($"Questions: {NumberOfQuestions}");

          

            Console.WriteLine($"\nYour Grade:{TakeExam()}");
            Console.WriteLine("\nCorrect Answers:");

            for (int i = 0; i < Questions.Length; i++)
            {
                if (Questions[i] == null) continue;
                Console.WriteLine(Questions[i].Header);
                Console.WriteLine(Questions[i].RightAnswer.AnswerText);
            }

        }
    }
}
