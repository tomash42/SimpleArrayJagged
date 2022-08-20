using System;

namespace SimpleArrayJagged
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======Calculating Field Rectangle=========");

            Console.WriteLine("Enter WIDHT :");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter HEIGHT :");
            int height = int.Parse(Console.ReadLine());


            if ((width < 0) || (height < 0) )
            {
                Console.WriteLine("Upss It is simple app ;)");
            }          
            else
            {


                //calculkation field
                int calculation = width * height;
                //Array Jagged 
                string[][] arr1 = new string[2][];
                arr1[0] = new string[height];
                arr1[1] = new string[width];
                Console.WriteLine("======Your Result========\n\n");
                //Loop for 
                for (int i = 0; i < arr1[0].Length; i++)
                {
                    Console.Write(arr1[0][i] = "\n");
                    for (int j = 0; j < arr1[1].Length; j++)
                    {
                        Console.Write(arr1[1][j] = "X");
                    }
                }
                //Result and End
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Your ractangle has dimension {calculation} ");
                Console.ResetColor();
            }
        }
    }
}
