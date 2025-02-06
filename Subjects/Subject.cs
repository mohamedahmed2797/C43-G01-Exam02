using C43_G01_Exam02.Answers;
using C43_G01_Exam02.Exam;
using C43_G01_Exam02.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_Exam02.Subjects
{
    internal class Subject 
    {

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exams? exams { get; set; }

        public Subject(int subjectId, string subjectName  )
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }
        public void CreateExam()
        {
            Console.Write("Please Enter The Type Of Exam You Want To Create(1 for practical and 2 for final) : ");
            int examType = 0;
            bool isParsed = false;
            while (!isParsed)
            {
                isParsed = int.TryParse(Console.ReadLine(), out examType);
                if (examType != 1 && examType != 2)
                {
                    Console.WriteLine("Invalid input. Please enter 1 for Practical Exam or 2 for Final Exam.");
                    isParsed = false;
                }
                Console.Write("Please enter the time of the exam in minutes: ");
                int examTime = int.Parse(Console.ReadLine());
                Console.Write("Please enter the number of questions you created: ");
                int questionsNumber = int.Parse(Console.ReadLine());

                if (examType == 1)
                {
                    exams = new Practical(DateTime.Now, examTime, SubjectName);
                    DateTime startTime = DateTime.Now;

                    for (int i = 0; i < questionsNumber; i++)
                    {
                        Console.WriteLine("Please select the question type for question " + (i + 1));
                        Console.WriteLine("1 for MCQ");
                        Console.WriteLine("2 for True/False");
                        int questionType = int.Parse(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine($"Enter the header for question {i + 1}: ");
                        string header = Console.ReadLine();

                        Console.WriteLine($"Enter the mark for question {i + 1}: ");
                        int mark = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Enter the body for question {i + 1}: ");
                        string body = Console.ReadLine();
                        List <Answer> answers = new List<Answer>();
                        for (int j = 0; j < 2; j++)
                        {
                            Console.WriteLine($"Enter answer {j + 1}: ");
                            string answerText = Console.ReadLine();
                            answers.Add(new Answer(j + 1, answerText));
                        }
                        Console.WriteLine("Enter the number of the correct answer: ");
                        int correctAnswerIndex = int.Parse(Console.ReadLine());
                        Answer correctAnswer = answers[correctAnswerIndex - 1];
                        Mcq mcq = new Mcq(header, body, mark, answers, correctAnswer);
                        exams.Questions.Add(mcq);
                    }
                    DateTime endTime = DateTime.Now;
                    TimeSpan duration = endTime - startTime;

                    Console.Clear();

                    exams.ShowEx();
                    Console.WriteLine($"the elapsed time {duration.Minutes} {duration.Seconds} ");
                
            }
                else if (examType == 2)
                {
                    exams = new Practical(DateTime.Now, examTime, SubjectName);
                    DateTime startTime = DateTime.Now;
                    exams = new Final(DateTime.Now, examTime, SubjectName);

                    for (int i = 0; i < questionsNumber; i++)
                    {
                        Console.WriteLine($"Enter the header for question {i + 1}: ");
                        string header = Console.ReadLine();

                        Console.WriteLine($"Enter the mark for question {i + 1}: ");
                        int mark = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Enter the body for question {i + 1}: ");
                        string body = Console.ReadLine();


                        List<Answer> answers = new List<Answer>();

                        for (int j = 0; j < 2; j++)
                        {
                            Console.WriteLine($"Enter answer {j + 1}: ");
                            string answerText = Console.ReadLine();
                            answers.Add(new Answer(j + 1, answerText));
                        }


                        Console.WriteLine("Enter the number of the correct answer: ");
                        int correctAnswerIndex = int.Parse(Console.ReadLine());
                        Answer correctAnswer = answers[correctAnswerIndex - 1];
                        Mcq mcq = new Mcq(header, body, mark, answers, correctAnswer);
                        exams.Questions.Add(mcq);
                    }
                    DateTime endTime = DateTime.Now;
                    TimeSpan duration = endTime - startTime;

                    Console.Clear();

                    exams.ShowEx();

                    Console.WriteLine($"the elapsed time {duration.Minutes} {duration.Seconds} ");




                }
            }
            }

        public override string ToString()
        {
        return ($"{SubjectId} , {SubjectName}");
        }

       
    }
}
