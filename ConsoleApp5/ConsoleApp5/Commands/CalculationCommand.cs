using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Commands
{
    class CalculationCommand : ICommand
    {
        private AccelerationDisplacementModel _model;

        public CalculationCommand(AccelerationDisplacementModel model)
        {
            _model = model;
        }

        public void Execute()
        {
            var vi = _model.InitialVelocity;
            var t = _model.Time;
            var a = _model.Acceleration;

            _model.Displacement = (vi * t) + (.5 * a) * Math.Pow(t, 2);
        }
    }
}
