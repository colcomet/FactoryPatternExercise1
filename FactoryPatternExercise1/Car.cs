using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise1
{
    internal class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("I'm a car, and I'm driving!");
        }
    }
}
