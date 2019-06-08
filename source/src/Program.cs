using System;

namespace AccelerationDisplacementCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculation();

            calc.GetInput();
            calc.RunCalculation();
            calc.DisplayOutput();
        }
    }
}
