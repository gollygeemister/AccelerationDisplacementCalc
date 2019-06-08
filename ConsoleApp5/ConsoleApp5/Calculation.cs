using Assignment.Builders;
using Assignment.Drivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Calculation
    {
        private ICalculationDriver _calculationDriver;
        private IDriver _outputDriver;

        public Calculation()
        {
            var builder = new DriverBuilder();

            _calculationDriver = builder.CreateCommandDriver();
            _outputDriver = builder.CreateOutputDriver();
        }

        public void GetInput()
        {
            _calculationDriver.GetInput();
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
