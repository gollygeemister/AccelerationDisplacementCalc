using AccelerationDisplacementCalc.Factories;
using System;

namespace AccelerationDisplacementCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = CalculationFactory.CreateCalculation();

            calc.GetInput();
            calc.RunCalculation();
            calc.DisplayOutput();
        }
    }
}
