using System;
using System.Reflection;
{
    //int maxSides = 6;
    //int minSides = 1;
 

    //int die1 = GetRandom();
    //int die2 = GetRandom(numSides);
    //int totalRolled = die1 + die2;


    Console.WriteLine("Welcome to the Grand Circus Casino!");
    Console.WriteLine("How many sides should each die have?");
    int numSides = int.Parse(Console.ReadLine());

    bool restart = true;
    while (restart == true)
    {

        //How many sides
        while (true)
        {
            Console.WriteLine("How many sides should each die have?");

            if (numSides >= 2 && numSides <= 6)
            {
                Console.WriteLine(($"{numSides} sided dice!"));
                break;
            }
            else;
            {
                Console.WriteLine("Invalid number. Please try again.");
            }

        }
        //Selecting random numbers
        static int getRandom(int s)
        {
            Random random = new Random();
            return random.Next(s);
        }
        int die1 = getRandom(numSides);
        int die2 = getRandom(numSides);
        int totalRolled = die1 + die2;

        Console.WriteLine($"Dice 1: {die1}");
        Console.WriteLine($"Dice 2: {die2}");
        Console.WriteLine($"Total: {totalRolled}");

        //Types
        if (die1 == 1 && die2 == 1)
        {
            Console.WriteLine("Snake Eyes!");
        }
        if (die1 == 1 && die2 == 2)
        {
            Console.WriteLine("Ace Deuce!");
        }
        if (die1 == 6 && die2 == 6)
        {
            Console.WriteLine("Box Cars!");
        }
        if (die1 + die2 == 7 || die1 + die2 == 11)
        {
            Console.WriteLine($"{totalRolled}!");
        }
        if (die1 + die2 == 7 || die1 + die2 == 11)
        {
            Console.WriteLine($"{totalRolled}!");
        }
        if (die1 + die2 == 2 || die1 + die2 == 3 || die1 + die2 == 12)
        {
            Console.WriteLine($"{totalRolled}!");
        }

        Console.WriteLine("Would you like to roll again?");
        string response = Console.ReadLine();
        if (response == "y")
        {
            restart = true;
            Console.WriteLine("Roll again!");
        }
        else if (response == "n")
        {
            restart = false;
            Console.WriteLine("Goodbye!");
            break;
        }
        else
        {
            Console.WriteLine("Invalid response. Please try again.");
        }
    }


    //static int GetRandom()
    //{
    //    Random r = new Random();
    //    return r.Next(1, 1);
    //}
    //int dice1 = GetRandom(numSides);

}





//while (true)
//{
//    static int numSides(int s)
//    {
//        int numSides = int.Parse(Console.ReadLine());
//        if (s <= 2 && s >= 6)
//        {
//            Console.WriteLine(($"{numSides} sided dice!"));
//        }
//        else;
//        {
//            Console.WriteLine("Invalid number. Please try again.");
//        }
//    }
//}









//static int numSides()
//{
//    int numSides = int.Parse(Console.ReadLine());
//}

//static int numSides()
//{
//    Sides s = new Sides()
//}


