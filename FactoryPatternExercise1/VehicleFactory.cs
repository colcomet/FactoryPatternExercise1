using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise1
{
    internal static class VehicleFactory
    {
        public static IVehicle GetVehicle(string input)
        {
            switch (input.ToLower())
            {
                case "2":
                    return new Motorcycle();
                case "4":
                    return new Car();
            }
            return null;
        }
    }
}
