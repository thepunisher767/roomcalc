using System;

namespace CircleRadius
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueFlag = true;
            Console.WriteLine("Welcome to the ROOM CALCULATOR!!!!!!");

            while (continueFlag)
            {
                Console.Write("\n" + "Please enter the length of the room in feet: ");
                double length = DblValidation(Console.ReadLine());

                Console.Write("Please enter the width of the room in feet: ");
                double width = DblValidation(Console.ReadLine());

                Console.Write("Please enter the height of the room in feet: ");
                double height = DblValidation(Console.ReadLine());

                double area = length * width;
                double perimiter = length * 2 + width * 2;
                double volume = length * width * height;

                if (area <= 250)
                {
                    Console.WriteLine("\n" + "The area of the room is " + area + "sq/ft, and the perimiter of the room is " + perimiter + "ft." + "\n" + "The volume of the room is " + volume + " cubic feet. This is a SMALL room!" + "\n");
                }
                if (area > 250 && area < 650)
                {
                    Console.WriteLine("\n" + "The area of the room is " + area + "sq/ft, and the perimiter of the room is " + perimiter + "ft." + "\n" + "The volume of the room is " + volume + " cubic feet. This is a MEDIUM room!" + "\n");
                }
                if (area > 650)
                {
                    Console.WriteLine("\n" + "The area of the room is " + area + "sq/ft, and the perimiter of the room is " + perimiter + "ft." + "\n" + "The volume of the room is " + volume + " cubic feet. This is a LARGE room!" + "\n");
                }

                Console.Write("Would you like to calculate another room? (Enter y to continue): ");
                string continueInput = Console.ReadLine();
                if (continueInput != "y")
                {
                    continueFlag = false;
                }
            }
            Console.Write("\n" + "Ok byeeeeeeee!!!!!!" + "\n\n");
        }
        public static double DblValidation(string input)
        {
            double validDblOutput;
            while (!double.TryParse(input, out validDblOutput) || validDblOutput < 0)
            {
                Console.WriteLine("Must be a valid non-negative number.");
                Console.Write("Try again please: ");
                input = Console.ReadLine();
            }
            return validDblOutput;
        }

    }
}