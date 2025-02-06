using C43_G01_Exam02.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_Exam02.Questions
{
    internal  class TrueOrFalse : Question
    {
        public TrueOrFalse(string header, string body, int mark, Answer rightAnswer) : base(header, body, mark, rightAnswer)
        {
        }
        public override void ShowQ()
        {
            Console.WriteLine($"{Header}\n{Body}\nMark: {Mark}\nTrue or False?");
        }
    }
    
}
