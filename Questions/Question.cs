using C43_G01_Exam02.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_Exam02.Questions
{
    internal abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer RightAnswer { get; set; }
        public Question(string header, string body, int mark , Answer rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            RightAnswer = rightAnswer;
        }
        public override string ToString()
        {
            return $"{Header} , {Body} , {Mark}";
        }
        public abstract void ShowQ();

    }
}
