using C43_G01_Exam02.Answers;
using C43_G01_Exam02.Questions;
using C43_G01_Exam02.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_Exam02.Exam
{
    internal class Practical : Exams
    {
        public Practical(DateTime time, int questionsNumber, string subject) : base(time, questionsNumber, subject)
        {
        }

        public override void ShowEx()
        {
            Console.WriteLine($"Practical Exam for : {subject}");
            foreach (Question question in Questions)
            {
                question.ShowQ();
            }
            foreach (Question question in Questions)
            {
                if (question.GetType() == typeof(Mcq))
                {
                    Mcq mcq = (Mcq)question;
                    Console.WriteLine($"Correct answer: {mcq.RightAnswer}");
                }
            }
        }
    }
}
