using System;
namespace FactoryPattern
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Pick between Math, History, and Chemistry for a question");
            string SubjectQuestion = Console.ReadLine();

            IQuestion question = QuestionFactory.GetQuest(SubjectQuestion);
            question.Build();
            Console.ReadLine();
        }



    }

}