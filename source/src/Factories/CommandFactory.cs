using AccelerationDisplacementCalc.Commands;
using AccelerationDisplacementCalc.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccelerationDisplacementCalc.Factories
{
    class CommandFactory
    {
        private AccelerationDisplacementModel _model;

        public CommandFactory()
        {
            _model = new AccelerationDisplacementModel();
        }

        public IEnumerable<ICommand> CreateInputCommands()
        {
            ICommand[] commands =
            {
                new GetViCommand(_model),
                new GetTCommand(_model),
                new GetACommand(_model)
            };

            return commands;
        }

        public ICommand CreateCalculaitonCommand()
        {
            return new CalculationCommand(_model);
        }

        public ICommand CreateOutputCommand()
        {
            return new OutputCommand(_model);
        }
    }
}
