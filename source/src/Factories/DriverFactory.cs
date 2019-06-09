using AccelerationDisplacementCalc.Drivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccelerationDisplacementCalc.Factories
{
    class DriverFactory
    {
        private CommandFactory _factory;

        public DriverFactory()
        {
            _factory = new CommandFactory();
        }

        public IDriver CreateInputDriver()
        {
            return new InputDriver(_factory.CreateInputCommands());
        }

        public IDriver CreateCalculationDriver()
        {
            return new CalculationDriver(
                _factory.CreateCalculaitonCommand());
        }

        public IDriver CreateOutputDriver()
        {
            return new OutputDriver(_factory.CreateOutputCommand());
        }
    }
}
