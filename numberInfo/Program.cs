using System;


namespace numberInfo
{
    class Program
    { 
        static void Main(string[] args)
        {
            string first;
            int num1;
            string second;
            int num2;
         
            Console.WriteLine("Enter two numbers! Don't use Zero or any non-numeric characters!");

            Console.WriteLine("What is your first number!?");
            first = Console.ReadLine();

            while (!int.TryParse(first, out num1) || first == "0")
            {
                Console.WriteLine("Cant you read! NO 0'S or LETTERS, What is your first Number!?");
                first = Console.ReadLine();
            }
            num1 = Convert.ToInt32(first);
            
            Console.WriteLine("What is your second number!?");
            second = Console.ReadLine();

            while (!int.TryParse(second, out num2) || second  == "0")
            {
                Console.WriteLine("Cant you read! NO 0'S or LETTERS, What is your second Number!?");
                second = Console.ReadLine();
            }

            num2 = Convert.ToInt32(second);

            Console.WriteLine("Ready. Press Enter!?"); Console.ReadLine();                       
                      
            Console.WriteLine("The Results are in!");             
            Console.WriteLine(first + " + " + second + " = " + MathMethods.numPlus(num1, num2));
            Console.WriteLine(first + " - " + second + " = " + MathMethods.numMinus(num1, num2));
            Console.WriteLine(first + " * " + second + " = " + MathMethods.numMulti(num1, num2));
            Console.WriteLine(first + " / " + second + " = " + MathMethods.numDiv(num1, num2));
            Console.WriteLine("The Square Root of " + first + " and " + second  + " added together = " + MathMethods.numSqu(num1, num2));
            Console.ReadLine();
        }
    }
}
