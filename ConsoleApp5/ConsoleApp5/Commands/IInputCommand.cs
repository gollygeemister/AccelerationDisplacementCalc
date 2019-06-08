using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Commands
{
    interface IInputCommand : ICommand
    {
        string GetInput();
        void HandleInvalidInput(Exception e);
    }
}
