using System;

namespace TestAverage
{
    class Program
    {


string[] test = new string[3];

int i = 0;

double sum = 0;

 
for (i = 0; i<test.Length; i++)

{

Console.Write("Enter your test score " + (i + 1) + ": ");

test[i] =

Console.ReadLine();

}


for (i = 0; i<test.Length; i++)

{

sum = sum +

Convert.ToDouble(test[i].Trim());

}

Console.WriteLine("\nThis is your average = " + (sum / test.Length));

Console.Write("\nPress the [Enter] key to exit.");

Console.ReadLine();
    }
    }
    }

