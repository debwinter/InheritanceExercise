using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird b1 = new Bird() { Name = "Tweety", Species = "Tweety Bird",
                Legs = 2, CanFly = true, Color = "yellow",
                CanSpeak = true, FavoriteSaying = "I tawt I taw a puddy tat!" };

            b1.Describe(b1);

            Console.WriteLine();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptile r1 = new Reptile() { Name = "Martin", Species = "Gecko",
                Legs = 4, Color = "green", Movement = "walk",
                CanCamouflage = true, LaysEggs = true, TopSpeed = 30 };

            r1.Describe(r1);
        }
    }
}
