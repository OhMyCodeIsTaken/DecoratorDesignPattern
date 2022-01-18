﻿using System;

namespace DecoratorGun
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            The Decorator DP is used to add or modify an object's behavior. It is similar to normal
            inheritance, with one key difference - the Decorator DP allows this modification to happen
            during run time, and not only during design time (like inheritance).

            In our example, we have a basic pistol, the pistol can be upgraded using the Decorator DP during runtime,
            by using weapon upgrades that adhere to the Decorator DP (lines 30 and 34).
                **/

            string input;

            Gun pistol = new Pistol();

            while (true)
            {
                PrintInstructions();

                input = Console.ReadLine();

                if (input == "D" || input == "d")
                {
                    pistol = new ExtraGunpowderUpgrade(pistol);
                }
                else if (input == "F" || input == "f")
                {
                    pistol = new QuickFireUpgrade(pistol);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Invalid Input!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    continue;
                }

                Console.WriteLine("The Pistol's DPS is: " + pistol.DamagePerSecond);
                
            }
            
        }

        static void PrintInstructions()
        {
            Console.WriteLine("\n\nChoose your upgrade (press the appropriate key):");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("D: ");
            Console.Write("Damage Upgrade       ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("F: ");
            Console.Write("Fire Rate Upgrade       ");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
