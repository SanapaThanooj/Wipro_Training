using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
     class Quiz
    {
        public string Text { get; set; }
        public Dictionary<char,string> Options;
        public char CorrectAnswer;
        public Quiz(string text, Dictionary<char, string> options, char correctAnswer)
        {
            Text = text;
            Options = options;
            CorrectAnswer = correctAnswer;
        }
        public void DisplayQuiz()
        {
            Console.WriteLine(Text);
            foreach (var option in Options)
            {
                Console.WriteLine($"{option.Key}: {option.Value}");
            }
            Console.Write("Enter your answer (A, B, C, D): ");
            char userAnswer = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (char.ToUpper(userAnswer) == CorrectAnswer)
            {
                Console.WriteLine("Correct Answer!");
            }
            else
            {
                Console.WriteLine($"Wrong Answer! The correct answer is {CorrectAnswer}");
            }
        }
    }
    class Program
    {
        static void Main()
        {
            var quiz1 = new Quiz(
                "What is the capital of France?",
                new Dictionary<char, string>
                {
                    {'A', "Berlin"},
                    {'B', "Madrid"},
                    {'C', "Paris"},
                    {'D', "Rome"}
                },
                'C'
            );
            var quiz2 = new Quiz(
                "What is 2 + 2?",
                new Dictionary<char, string>
                {
                    {'A', "3"},
                    {'B', "4"},
                    {'C', "5"},
                    {'D', "6"}
                },
                'B'
            );
            var quiz3 = new Quiz(
                "What is the largest planet in our solar system?",
                new Dictionary<char, string>
                {
                    {'A', "Earth"},
                    {'B', "Mars"},
                    {'C', "Jupiter"},
                    {'D', "Saturn"}
                },
                'C'
            );
            quiz1.DisplayQuiz();
            Console.WriteLine();
            quiz2.DisplayQuiz();
            Console.WriteLine();
            quiz3.DisplayQuiz();
            Console.WriteLine("Thank you for participating in the quiz! Press any key to exit.");
        }
    }
}
