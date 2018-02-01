using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an interactive console window
            //Prompt user to choose what to do whith the fricge
            //Call methods on Fridge object to do what the useer wants
            int userChoice;
            int foodRemoved;
            Fridge userFridge = new Fridge(false, "deluxe", 70, true);

            do
            {
                Console.WriteLine("Hello, welcome to the fridge app");
                Console.WriteLine("What would you like to do with your fridge?");
                Console.WriteLine("To dispense water, type 1");
                Console.WriteLine("To change the lightbulb, type 2");
                Console.WriteLine("To clean, type 3");
                Console.WriteLine("To take food, type 4");
                Console.WriteLine("To check food supplies, type 5");
                Console.WriteLine("to see all fridge details, type 6");
                //Console.WriteLine("To restart, type 7");
                Console.WriteLine("To quit, type 8");

                userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        userFridge.DispenseWater();
                        break;

                    case 2:
                        Console.WriteLine(userFridge.ChangeBulbs());
                        break;

                    case 3:
                        Console.WriteLine(userFridge.Clean());
                        break;

                    case 4:
                        Console.WriteLine("How much food do you want to remove?");
                        foodRemoved = int.Parse(Console.ReadLine());
                        userFridge.RemoveFood(foodRemoved);
                        Console.WriteLine("Food Amount is: " + userFridge.FoodAmount);
                        break;

                    case 5:
                        Console.WriteLine("Fridge is: " + userFridge.CheckSupplies());
                        break;

                    case 6:
                        Console.WriteLine("User Details");
                        Console.WriteLine("Is Fridge Clean: " + userFridge.IsClean );
                        Console.WriteLine("Dispenser Type: " + userFridge.DispenserType);
                        Console.WriteLine("Food Amount: " + userFridge.FoodAmount);
                        Console.WriteLine("Bulbs Work: " + userFridge.BulbsWork);
                        break;

                        
                }
                Console.WriteLine("");

            } while (userChoice != 8);

        }
    }
}
