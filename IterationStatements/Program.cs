namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        public static void PrintNumns1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void UpByThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool TooNumsSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Write a method to check whether a given number is even or odd
        public static string EvenOrOdd(int num)
        {
            if(num % 2 == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
        }

        //Write a method to check whether a given number is positive or negative
        public static bool IsPositive(int num )
        {
            return num > 0;
            
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static bool CanVote()
        {
            Console.WriteLine("Please enter your age:");
            var canParse = int.TryParse(Console.ReadLine(), out int age);

            while(canParse == false)
            {
                Console.WriteLine("Please enter a valid age:");
                canParse = int.TryParse(Console.ReadLine(), out age);
            }

            if(age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static bool IsInTenRange()
        {
            Console.WriteLine("Give me a number:");
            var num = int.Parse(Console.ReadLine());

            if(num <= 10 && num >= -10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MultThru12(int num)
        {
            for(int i = 1; i <=12; i++)
            {
                Console.WriteLine($"{i} x {num} = {i * num}");
            }
        }

        //Call the methods to test them in the Main method below
        //static void Main(string[] args)
        static void Main(string[] args)
        {
            PrintNumns1000();

            UpByThree();

            var same = TooNumsSame(3, 2);
            Console.WriteLine(same);


            Console.WriteLine(EvenOrOdd(9));

            Console.WriteLine(IsPositive(-10));

            var vote = CanVote();
            Console.WriteLine(vote);

            var ten = IsInTenRange();
            Console.WriteLine(ten);
        }




    }
}

