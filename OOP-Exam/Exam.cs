using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class Exam
    {
        public string ExamType { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();
        public int TotalMarks { get; set; } = 0;
        public void StartExam()
        {
            int score = 0;
            foreach (var questions in Questions)
            {
                Console.WriteLine($"Q: {questions.Body} ({questions.Mark} Marks");
                for (int i = 0; i < questions.Choices.Count; i++)
                {
                    Console.WriteLine($"{i + 1} : {questions.Choices[i]}");
                }
                int answer;
                while (true)
                {
                    Console.Write("Your Answer (Enter a valid choice number): ");
                    if (int.TryParse(Console.ReadLine(), out answer) && answer > 0 && answer <= questions.Choices.Count)
                        break;

                    Console.WriteLine("Invalid choice. Please enter a valid number corresponding to the choices.");
                }
                if (answer == questions.CorrectAnswer)
                {
                    Console.WriteLine("Correct Answer :)");
                    score += questions.Mark;
                }
                else
                {
                    Console.WriteLine("Wrong Answer :(");
                }
            }
            Console.WriteLine($"Your Score : {score}/{TotalMarks}");
        }
    }
}
