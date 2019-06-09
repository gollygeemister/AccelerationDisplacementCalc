using AccelerationDisplacementCalc.Factories;
using AccelerationDisplacementCalc.Drivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccelerationDisplacementCalc
{
    class Calculation
    {
        private IDriver _inputDriver;
        private IDriver _calculationDriver;
        private IDriver _outputDriver;

        public Calculation(IDriver inputDriver, IDriver calculationDriver, IDriver outputDriver)
        {
            _inputDriver = inputDriver;
            _calculationDriver = calculationDriver;
            _outputDriver = outputDriver;
        }

        public void GetInput()
        {
            _inputDriver.Run();
        }

        public void RunCalculation()
        {
            _calculationDriver.Run();
        }

        public void DisplayOutput()
        {
            _outputDriver.Run();
        }
    }
}
