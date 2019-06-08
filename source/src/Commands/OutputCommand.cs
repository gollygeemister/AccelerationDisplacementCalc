using AccelerationDisplacementCalc.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccelerationDisplacementCalc.Commands
{
    class OutputCommand : ICommand
    {
        private AccelerationDisplacementModel _model;

        public OutputCommand(AccelerationDisplacementModel model)
        {
            _model = model;
        }

        public void Execute()
        {
            var outputString = string.Format(
                "\n" +
                "************************************************\n" +
                "*       The Distance travelled in meters       *\n" +
                "*       is :{0} meters                     *\n" +
                "*       vi:{1} a:{2} t:{3}            *\n" +
                "************************************************",
                _model.Displacement.ToString("0.00").PadLeft(7, ' '), 
                _model.InitialVelocity.ToString("0.00").PadLeft(6, ' '),
                _model.Acceleration.ToString("0.00").PadLeft(6, ' '),
                _model.Time.ToString("0.00").PadLeft(6, ' '));

            Console.WriteLine(outputString);
        }
    }
}
