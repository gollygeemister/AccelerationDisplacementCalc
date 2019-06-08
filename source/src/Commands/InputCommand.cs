using AccelerationDisplacementCalc.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccelerationDisplacementCalc.Commands
{
    abstract class InputCommand : IInputCommand
    {
        protected AccelerationDisplacementModel _model;

        public InputCommand(AccelerationDisplacementModel model)
        {
            _model = model;
        }

        public abstract void Execute();
        public abstract string GetInput();

        public void HandleInvalidInput(Exception e)
        {
            if(e is ArgumentOutOfRangeException exception)
            {
                Console.WriteLine(exception.ParamName + " is out of range.");
            }
        }
    }
}
