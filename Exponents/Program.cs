using System.Security.Cryptography.X509Certificates;

namespace Exponents
{
    internal class Program
    {

        static void Main(string[] args)
        {

            bool goAgain = true;


            while (goAgain == true)
            {
                Console.WriteLine("Hello, please enter an integer.");
                double number = double.Parse(Console.ReadLine());
                while (number <= 0)
                {
                    Console.WriteLine("That number was not valid, please try again.");
                    number = double.Parse(Console.ReadLine());


                }

                Console.WriteLine("Number   Squared   Cubed");
                Console.WriteLine("=========================");

                //for loop to increment from 1 to number that user enters

                for (int i = 1; i <= number; i++)
                {
                    double sqrt = GetSquares(i);
                    double cubert = GetCubes(i);
                    Console.WriteLine(i + "           " + sqrt + "        " + cubert);


                }

                goAgain = AskToContinue();
            }


        }
        //methods for my squares, cubes, and ask to continue
        public static double GetSquares(double number)
        {
                double squares = Math.Pow(number, 2);
                return squares;
        }

        public static double GetCubes(double number)
        {
            double cubes = Math.Pow(number, 3);
            return cubes;
        }

        
        public static bool AskToContinue()
        {
            Console.WriteLine("Would you like to again? Y/N.");
            string answer = Console.ReadLine().ToLower();

            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Sorry, that was an invalid response, please input a valid response.");
                return AskToContinue();
            }
        }
    }
}