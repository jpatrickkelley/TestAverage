using System;

namespace TestAverage
{
    class Program
    {
        static void Main()

        {
             


            Console.WriteLine("What is your first test score?");

            var FirstAnswer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your second test score?");

             var SecondAnswer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your third test score?");

           var ThirdAnswer = Convert.ToInt32(Console.ReadLine());

           var AddedAnswers = FirstAnswer + SecondAnswer + ThirdAnswer;

            var AvgAnswers = AddedAnswers / 3;

            Console.WriteLine("Your average test score is " + AvgAnswers);
        }
    }
}



