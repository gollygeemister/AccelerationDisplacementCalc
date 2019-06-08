using System;
using System.Collections.Generic;
using System.Text;

namespace AccelerationDisplacementCalc.Commands
{
    interface IInputCommand : ICommand
    {
        string GetInput();
        void HandleInvalidInput(Exception e);
    }
}
