using System;
using System.Collections.Generic;
using System.Text;

namespace AccelerationDisplacementCalc.Drivers
{
    interface ICalculationDriver : IDriver
    {
        void GetInput();
    }
}
