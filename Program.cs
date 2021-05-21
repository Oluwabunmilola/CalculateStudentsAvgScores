using System;
using System.IO;
using System.Runtime.Serialization;

namespace AbstractClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            fristPerson precious = new fristPerson(70, 70, 60);
            secondPerson Mick = new secondPerson(90.67, 78.3, 89, 70);
            var avg1 = precious.getPercentage();
            Console.WriteLine("Precious, your average score is " +Math.Round(avg1,2));

            var avg2 = Mick.getPercentage();
            Console.WriteLine("Mick, your average score is " +Math.Round(avg2,2));

            
        }
    }


}