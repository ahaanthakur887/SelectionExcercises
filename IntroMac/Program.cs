namespace IntroMac
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(FizzBuzz(15));
            Console.WriteLine(VowelConsonant("a"));
            Console.WriteLine(DiceRoller());
            Console.WriteLine(Angles(137));
            Console.WriteLine(RockPaperScissors("Rock"));
            Console.WriteLine(Triangle(30, 30, 120));
            Console.ReadLine();
        }

        static string FizzBuzz(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (num % 3 == 0)
            {
                return "Fizz";
            }
            else if (num % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return Convert.ToString(num);
            }
        }

        static bool VowelConsonant(string letter)
        {
            switch(letter)
            {
                case "a" or "e" or "i" or "o" or "u":
                    return true;
                default:
                    return false;
            }
        }

        static string DiceRoller()
        {
            Random rnd = new Random();
            int d1 = rnd.Next(1,7);
            int d2 = rnd.Next(1, 7);
            int d3 = rnd.Next(1, 7);
            if (d1 == d2 && d1 == d3)
            {
                return "Three of a kind";
            }
            else if (d1 == d2 || d1 == d3 || d2 == d3)
            {
                return "You have a pair";
            }
            else
            {
                return "Sorry you lose";
            }
        }

        enum Sizes
        {
            Acute,
            RightAngle,
            Obtuse,
            Straight,
            Reflex
        }
        static string Angles(double AngleSize)
        {
            if (AngleSize < 90)
            {
                Sizes output = Sizes.Acute;
                return Convert.ToString(output);
            }
            else if (AngleSize == 90)
            {
                Sizes output = Sizes.RightAngle;
                return Convert.ToString(output);
            }
            else if (AngleSize > 90 && AngleSize < 180)
            {
                Sizes output = Sizes.Obtuse;
                return Convert.ToString(output);
            }
            else if (AngleSize == 180)
            {
                Sizes output = Sizes.Straight;
                return Convert.ToString(output);
            }
            else
            {
                Sizes output = Sizes.Reflex;
                return Convert.ToString(output);
            }
        }

        static string RockPaperScissors(string UserChoice)
        {
            int UserValue;
            if (UserChoice.ToLower() == "rock")
            {
                UserValue = 0;
            }
            else if (UserChoice.ToLower() == "paper")
            {
                UserValue = 1;
            }
            else if (UserChoice.ToLower() == "scissors")
            {
                UserValue = 2;
            }
            else
            {
                return "Invalid input";
            }
            Random rnd = new Random();
            int CPUChoice = rnd.Next(0, 3);
            if (UserValue - CPUChoice == 1 || UserValue - CPUChoice == -2)
            {
                return "Player Wins";
            }
            else if (UserValue - CPUChoice == 0)
            {
                return "It is a Draw";
            }
            else
            {
                return "CPU Wins";
            }
        }

        static string Triangle(int side1, int side2, int side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "Equilateral";
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                return "Iscosceles";
            }
            else
            {
                return "Scalene";
            }
        }

        static string ConcertSales()
        {
            Console.WriteLine("Enter the price of a ticket");
            double TicketPrice;
            if (double.TryParse(Console.ReadLine(), out TicketPrice) == false)
            {
                return "Invalid Input";
            }
            else
            {
                TicketPrice = Convert.ToDouble(Console.ReadLine());
            }
        }
    }
}