using System;
using AccelerationDisplacementCalc.Models;

namespace AccelerationDisplacementCalc.Commands
{
    class GetTCommand : InputCommand
    {

        public GetTCommand(AccelerationDisplacementModel model) : base(model) { }

        public override void Execute()
        {
            try
            {
                _model.Time = double.Parse(GetInput());
            }
            catch (ArgumentOutOfRangeException e)
            {
                HandleInvalidInput(e);
            }
        }

        public override string GetInput()
        {
            Console.Write("Enter the time the vehicle travels in seconds:");
            return Console.ReadLine();
        }
    }
}
