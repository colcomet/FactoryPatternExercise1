using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise1
{
    internal class Motorcycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("I am a motorcycle, and I'm driving!");
        }
    }
}
