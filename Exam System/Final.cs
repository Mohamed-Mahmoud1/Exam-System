using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_System
{
    public class Final : Exam
    {
        public Final(int time, int numberOfQuestions, Question[] questions) : base(time, numberOfQuestions, questions)
        {
        }

        public override void ShowExam()
        {

            Console.WriteLine("Final Exam");
            Console.WriteLine($"Time:  {Time}");
            Console.WriteLine($"Questions: {NumberOfQuestions}");

            
            Console.WriteLine($"\nYour Grade:{TakeExam()}");



        }

           
        
    }
}
