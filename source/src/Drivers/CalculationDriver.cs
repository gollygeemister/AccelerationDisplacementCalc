using AccelerationDisplacementCalc.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccelerationDisplacementCalc.Drivers
{
    class CalculationDriver : IDriver
    {
        private ICommand _calculationCommand;

        public CalculationDriver(ICommand calculationCommand)
        {
            _calculationCommand = calculationCommand;
        }

        public void Run()
        {
            _calculationCommand.Execute();
        }
    }
}
