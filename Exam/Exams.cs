using C43_G01_Exam02.Questions;
using C43_G01_Exam02.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_Exam02.Exam
{
    internal abstract  class Exams 
    {
        public DateTime Time { get; set; }
        public int QuestionsNumber { get; set; }
        public List<Question> Questions { get; set; }
        public string subject { get; set; }

        public Exams(DateTime time, int questionsNumber, string subject)
        {
            Time = time;
            QuestionsNumber = questionsNumber;
            Questions = new List<Question>();
            this.subject = subject;
        }

        public abstract void ShowEx();
        
       
    }
}
