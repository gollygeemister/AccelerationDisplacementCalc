using Assignment.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Drivers
{
    class CalculationDriver : ICalculationDriver
    {
        private IEnumerable<ICommand> _inputCommands;
        private ICommand _calculationCommand;

        public CalculationDriver(IEnumerable<ICommand> inputCommands, ICommand calculationCommand)
        {
            _inputCommands = inputCommands;
            _calculationCommand = calculationCommand;
        }

        public void GetInput()
        {
            foreach(var command in _inputCommands)
            {
                command.Execute();
            }
        }

        public void Run()
        {
            _calculationCommand.Execute();
        }
    }
}
