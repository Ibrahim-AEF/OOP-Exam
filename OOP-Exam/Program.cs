namespace OOP_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Exam Type : [1 for Practical | 2 for Final] : ");
            int examtype = int.Parse(Console.ReadLine());
            Exam exam = new Exam();
            exam.ExamType = examtype == 1 ? "Practical" : "Final";
            Console.WriteLine("Enter Numbere Of Questions : ");
            int NumOfQuestions = int.Parse(Console.ReadLine());
            for (int i = 0; i < NumOfQuestions; i++)
            {
                Console.WriteLine($"Enter Question {i + 1} Details : ");
                Question question = new Question();
                Console.WriteLine("Enter Question Body : ");
                question.Body = Console.ReadLine();
                Console.WriteLine("Enter Question Marks : ");
                question.Mark = int.Parse(Console.ReadLine());
                question.Choices = new List<string>();
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter Choice {j + 1}: ");
                    question.Choices.Add(Console.ReadLine());
                }
                Console.Write("Enter Correct Choice Number (1 - 2 - 3): ");
                int CorrectChoice;
                while (!int.TryParse(Console.ReadLine(), out CorrectChoice) || CorrectChoice < 1 || CorrectChoice > 3)
                {
                    Console.WriteLine("Invalid input. Please enter 1, 2, 3 for the correct choice.");
                }
                question.CorrectAnswer = CorrectChoice;
                exam.Questions.Add(question);
                exam.TotalMarks += question.Mark;
            }
            Console.WriteLine("Do You Want To Start The Exam ? (Yes/No) : ");
            string word = Console.ReadLine();
            if (word == "Yes" || word == "yes")
            {
                exam.StartExam();
            }
            else
            {
                Console.WriteLine("Thank You :)");
            }
        }
    }
}
