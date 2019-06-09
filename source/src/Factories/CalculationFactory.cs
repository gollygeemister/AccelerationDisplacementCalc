using System;
using System.Collections.Generic;
using System.Text;

namespace AccelerationDisplacementCalc.Factories
{
    static class CalculationFactory
    {
        public static Calculation CreateCalculation()
        {
            var factory = new DriverFactory();

            return new Calculation(
                factory.CreateInputDriver(),
                factory.CreateCalculationDriver(),
                factory.CreateOutputDriver());
        }
    }
}
