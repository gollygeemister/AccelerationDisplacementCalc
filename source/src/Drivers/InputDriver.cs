using AccelerationDisplacementCalc.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccelerationDisplacementCalc.Drivers
{
    class InputDriver : IDriver
    {
        private IEnumerable<ICommand> _inputCommands;

        public InputDriver(IEnumerable<ICommand> inputCommands)
        {
            _inputCommands = inputCommands;
        }

        public void Run()
        {
            foreach (var command in _inputCommands)
            {
                command.Execute();
            }
        }
    }
}
