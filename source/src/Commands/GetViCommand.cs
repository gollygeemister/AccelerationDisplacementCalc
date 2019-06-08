using System;
using AccelerationDisplacementCalc.Models;

namespace AccelerationDisplacementCalc.Commands
{
    class GetViCommand : InputCommand
    {

        public GetViCommand(AccelerationDisplacementModel model) : base(model) { }

        public override void Execute()
        {
            try
            {
                _model.InitialVelocity = double.Parse(GetInput());
            }
            catch(ArgumentOutOfRangeException e)
            {
                HandleInvalidInput(e);
            }
        }

        public override string GetInput()
        {
            Console.Write("Enter the vehicle's initial velocity in m/s:");
            return Console.ReadLine();
        }
    }
}
