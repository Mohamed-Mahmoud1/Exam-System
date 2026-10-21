using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_System
{
    public abstract class Exam
    {

        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }
        public Exam(int time, int numberOfQuestions, Question[] questions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Questions = questions;
        }


        public int TakeExam()
        {
            {
                int grade = 0;

                for (int i = 0; i < Questions.Length; i++)
                {
                    if (Questions[i] == null) continue;
                    Console.WriteLine($"\nQuestion {i + 1}");
                    Questions[i].ShowQuestion();

                    Console.Write("Enter answer: ");
                    int answerId = int.Parse(Console.ReadLine());

                    if (answerId == Questions[i].RightAnswer.AnswerId)
                    {
                        grade += Questions[i].Mark;
                    }
                }

                return grade;
            }
        }

        public abstract void ShowExam();
    

    }
}
