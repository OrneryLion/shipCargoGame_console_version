using System;

namespace shipCargoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship();

            string welcomeMessage = "Welcome to Cargo Ship. The goal of this game is to load the ship to its max capacity by " +
                "adding motor cycles, cars, turcks, and train cars. A cycle takes 3 units of weight. A car takes 5 units. A truck takes 11 units. A train car takes 17 units.";

            Console.WriteLine(welcomeMessage);

            // repeats until the player gets the ship loaded to capacity
            while(ship.Capacity != ship.getShipLoad())
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("THe ship capacity is " + ship.Capacity);
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("The ship has " + ship.cycleCount + " motor cycles on board");
                Console.WriteLine("The ship has " + ship.carCount + " cars on board");
                Console.WriteLine("The ship has " + ship.truckCount + " trucks on board");
                Console.WriteLine("The ship has " + ship.trainCarCount + " train cars on board");
                Console.WriteLine("The ship currently has " + ship.getShipLoad() + " total units on baord");

                int x;
                Console.WriteLine("How many motor cycles would you like on board the Ship");
                x = int.Parse(Console.ReadLine());

                ship.cycleCount = x;



                Console.WriteLine("How many cars would you like on board the Ship");
                x = int.Parse(Console.ReadLine());

                ship.carCount = x;

                Console.WriteLine("How many trucks would you like on board the Ship");
                x = int.Parse(Console.ReadLine());

                ship.truckCount = x;

                Console.WriteLine("How many train cars would you like on board the Ship");
                x = int.Parse(Console.ReadLine());

                ship.trainCarCount = x;

                Console.WriteLine("The ship now has " + ship.getShipLoad() + " total units of weight on board");

                if(ship.overUnder() > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The ship still has room to spare. Load more items");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The ship has been overloaded. Take some items off");
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("the ship has been filled to capacity.");
            Console.ReadLine();
        }
    }
}
