using System;

namespace FactoryPatternExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of wheels [2|4]");
            string input = Console.ReadLine();
            IVehicle vehicle = VehicleFactory.GetVehicle(input);
            if(vehicle == null)
            {
                Console.WriteLine($"There is no vehicle with {input} wheels.");
            }
            else
            {
                vehicle.Drive();
            }
        }
    }
}
