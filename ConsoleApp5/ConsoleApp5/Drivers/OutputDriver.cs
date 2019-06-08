using Assignment.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Drivers
{
    class OutputDriver :IDriver
    {
        private ICommand _outputCommand;

        public OutputDriver(ICommand outputCommand)
        {
            _outputCommand = outputCommand;
        }

        public void Run()
        {
            _outputCommand.Execute();
        }
    }
}
