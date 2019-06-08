using Assignment.Drivers;
using Assignment.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Builders
{
    class DriverBuilder
    {
        private CommandFactory _factory;

        public DriverBuilder()
        {
            _factory = new CommandFactory();
        }

        public ICalculationDriver CreateCommandDriver()
        {
            return new CalculationDriver(
                _factory.GetInputCommands(),
                _factory.GetCalculaitonCommand());
        }

        public IDriver CreateOutputDriver()
        {
            return new OutputDriver(_factory.GetOutputCommand());
        }
    }
}
