using System;

namespace In_Class_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 2
            //Print trip options and cost
            Console.WriteLine("question 2");
            Console.WriteLine("");
            Console.WriteLine("three options");
            Console.WriteLine("marks in c# >=60");
            Console.WriteLine("marks in java>=55");
            Console.WriteLine("marks in python>=50");


            Console.WriteLine("write marks of csharp:");
            int CSharp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("write marks of java:");
            int Java = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("write marks of python:");
            int Python = Convert.ToInt32(Console.ReadLine());

            int totalMarks = CSharp + Java + Python;
            Console.WriteLine("totalMarks {0}",totalMarks);
             int markOfTwoSubjects = CSharp + Python;
            Console.WriteLine("totalMarksof two subject {0}", markOfTwoSubjects);







            string result = ((CSharp >= 60 && Java >= 55 && Python >= 50) ||
                 (CSharp + Java + Python >= 170 || CSharp + Python >= 150)) ? "Eligible for admission" : "not eligible for admission";

            Console.WriteLine("The student is {0}", result);
            Console.ReadLine();
        }
    }
}
