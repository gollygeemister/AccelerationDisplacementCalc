using System;
using AccelerationDisplacementCalc.Models;

namespace AccelerationDisplacementCalc.Commands
{
    class GetACommand : InputCommand
    {
        public GetACommand(AccelerationDisplacementModel model) : base(model) { }

        public override void Execute()
        {
            try
            {
                _model.Acceleration = double.Parse(GetInput());
            }
            catch (ArgumentOutOfRangeException e)
            {
                HandleInvalidInput(e);
            }
        }

        public override string GetInput()
        {
            Console.Write("Enter the rate of acceleration in m/s:");
            return Console.ReadLine();
        }
    }
}
