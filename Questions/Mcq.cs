using C43_G01_Exam02.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_Exam02.Questions
{
    internal  class Mcq : Question
    {
        public List<Answer> answers { get; set; } = new List<Answer>();
        public new Answer? RightAnswer { get; set; }
        public Mcq(string header, string body, int mark,  List<Answer> answer , Answer rightAnswer) : base(header, body, mark , rightAnswer)
        {
            answers = answer;
           
        }
        public override void ShowQ()
        {
            Console.WriteLine($"{Header}\n{Body}\nMark: {Mark}");
            for (int i = 0; i < answers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {answers[i].AnswerText}");
            }
        }
    }
}
