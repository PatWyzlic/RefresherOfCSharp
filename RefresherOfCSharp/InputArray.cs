using System;
namespace RefresherOfCSharp

//Average grade calculator
{
    public class InputArray
    {
        public InputArray()
        {
            //Introduction of grade calculator
            Console.WriteLine("Hello welcome to the average grade calculator");
            Console.WriteLine("How many grades would you like to enter?");
            Console.WriteLine("(Whole numbers only)");
            int size = Convert.ToInt32(Console.In.ReadLine());
            int[] gradesInSchool = new int[size];

            Console.WriteLine($"Please enter {size} grades");

            //For loop to enter numbers for grades
            for (int i = 0; i < gradesInSchool.Length; i++)
            {
                gradesInSchool[i] = Convert.ToInt32(Console.In.ReadLine());
                
            }

            //Intialization and declaration of total for adding grades
            int total = 0;
            
            for (int i = 0; i < gradesInSchool.Length; i++)
            {
                if(i == 0)
                {
                    Console.Write("(");
                }
                Console.Write(gradesInSchool[i]);
                if (i < gradesInSchool.Length - 1)
                {
                    Console.Write("+");
                }
                if (i == gradesInSchool.Length - 1)
                {
                    Console.Write($") / {size}");

                }
                //Addition of grades
                total += gradesInSchool[i];
            }
           
            //Output of final average grade
            Console.WriteLine(" =");
            Console.WriteLine("\nAverage Grade:");
            Console.WriteLine(total / size);
        }
    }
}
