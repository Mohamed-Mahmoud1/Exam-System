using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Exam_System
{
    public class Subject
    {


        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam ExamOfSubject { get; set; }
        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;

        }
        public void CreateExam()
        {
            Console.WriteLine("Choose Exam Type:");
            Console.WriteLine("1. Final");
            Console.WriteLine("2. Practical");

            int examType = int.Parse(Console.ReadLine());

            Console.Write("Enter Exam Time: ");
            int time = int.Parse(Console.ReadLine());

            Console.Write("Enter Number Of Questions: ");
            int numberOfQuestions = int.Parse(Console.ReadLine());

            Question[] questions = new Question[numberOfQuestions];

            for (int i = 0; i < numberOfQuestions; i++)
            {
                Console.WriteLine("\nQuestion " + (i + 1));

                int questionType=examType==1 ? 1 : 2;

                if (examType == 1)
                {
                    Console.WriteLine("1. MCQ");
                    Console.WriteLine("2. True/False");

                    questionType = int.Parse(Console.ReadLine());
                }

                Console.Write("Enter Header: ");
                string header = Console.ReadLine();

                Console.Write("Enter Body: ");
                string body = Console.ReadLine();

                Console.Write("Enter Mark: ");
                int mark = int.Parse(Console.ReadLine());

                Answers[] answers;

                if (questionType == 2)
                {
                    answers = new Answers[2];
                    answers[0] = new Answers(1, "True");
                    answers[1] = new Answers(2, "False");
                }
                else
                {
                    Console.Write("Enter Number Of Answers: ");
                    int answerCount = int.Parse(Console.ReadLine());

                    answers = new Answers[answerCount];

                    for (int j = 0; j < answerCount; j++)   
                    {
                        Console.Write($"Enter Answer {j + 1}: ");
                        string answerText = Console.ReadLine();

                        answers[j] = new Answers(j + 1, answerText);
                    }
                }
                string enter = questionType == 1 ? "Enter Right Answer: " : "Enter Right Answer (1 for True, 2 for False): ";
                Console.Write(enter);
                int rightAnswerId = int.Parse(Console.ReadLine());
                Answers rightanswer=new Answers(rightAnswerId,answers[rightAnswerId-1].AnswerText);
               

                if (questionType == 1)
                {
                    questions[i] = new MCQ(header, body, mark, answers, rightanswer);
                }
                else
                {
                    questions[i] = new TrueOrFalse(header, body, mark, answers, rightanswer);
                }
            }

            if (examType == 1)
            {
                ExamOfSubject = new Final(time, numberOfQuestions, questions);
               
            }
            else
            {

                ExamOfSubject = new Practical(time, numberOfQuestions,questions);
            }
        }


    }
}
