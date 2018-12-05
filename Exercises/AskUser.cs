using System;

namespace Exercises
{
    public class AskUser
    {
        public static void ChooseANumber()
        {
            Console.WriteLine("Enter a number between 1 and 10...");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public static void FindMax()
        {
            Console.WriteLine("Enter two numbers to find out which one is larger...");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2)
            {
                Console.WriteLine("{0} is greater than {1}.", num1, num2);
            }
            else if (num1 < num2)
            {
                Console.WriteLine("{0} is greater than {1}.", num2,  num1);
            }
            else
            {
                Console.WriteLine("The numbers are equal.");
            }
        }

        public static void LandscapeOrPortrait()
        {
            Console.WriteLine("Enter the width and height of the image.\nWidth...");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Height...");
            int height = Convert.ToInt32(Console.ReadLine());
            if(width > height)
            {
                Console.WriteLine("The image is landscape.");
            }
            else if(width < height)
            {
                Console.WriteLine("The image is portrait.");

            }
            else
            {
                Console.WriteLine("The image is square.");

            }

        }
        public static void SpeedOfVehical()
        {
            Console.WriteLine("What is the speed limit?");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the speed of the vehical?");
            int speedOfVehical = Convert.ToInt32(Console.ReadLine());
            bool speeding = speedOfVehical > speedLimit;
            int demeritPoints = (speedOfVehical - speedLimit) / 5 + 1;
            if (speeding)
            {
                Console.WriteLine("You've incurred {0} Demerit Points.", demeritPoints);
                if(demeritPoints > 11)
                {
                    Console.WriteLine("License Suspended.");
                }
            }
            else
            {
                Console.WriteLine("Ok");
            }

        }
    }
}

