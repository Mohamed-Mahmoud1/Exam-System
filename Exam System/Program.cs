namespace Exam_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            Subject subject = new Subject(100, "Math");
            subject.CreateExam();
            subject.ExamOfSubject.ShowExam();

        }
    }
}
