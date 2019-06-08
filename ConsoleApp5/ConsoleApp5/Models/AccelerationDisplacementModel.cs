using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Models
{
    class AccelerationDisplacementModel
    {
        private enum Limits
        {
            VI_LOWER_LIMIT = 0,
            T_LOWER_LIMIT,
            A_LOWER_LIMIT,
            VI_UPPER_LIMIT,
            T_UPPER_LIMIT,
            A_UPPER_LIMIT
        }

        private double[] LIMIT_VALUES = { 0.01, 0.01, 0.01, 100, 60, 50};

        private double _initialVelocity;

        private double _time;

        private double _acceleration;

        public AccelerationDisplacementModel(double initialVelocity = 0.0, double time = 0.0, double acceleration = 0.0, double displacement = 0.0)
        {
            _initialVelocity = initialVelocity;
            _time = time;
            _acceleration = acceleration;
            Displacement = displacement;
        }

        public double InitialVelocity
        {
            get
            {
                return _initialVelocity;
            }

            set
            {
                if(value < LIMIT_VALUES[(int)Limits.VI_LOWER_LIMIT] || value > LIMIT_VALUES[(int)Limits.VI_UPPER_LIMIT])
                {
                    throw new ArgumentOutOfRangeException("Vi data", "out of range");
                }

                _initialVelocity = value;
            }
        }

        public double Time
        {
            get
            {
                return _time;
            }

            set
            {
                if (value < LIMIT_VALUES[(int)Limits.T_LOWER_LIMIT] || value > LIMIT_VALUES[(int)Limits.T_UPPER_LIMIT])
                {
                    throw new ArgumentOutOfRangeException("T data", "out of range");
                }

                _time = value;
            }
        }

        public double Acceleration
        {
            get
            {
                return _acceleration;
            }

            set
            {
                if (value < LIMIT_VALUES[(int)Limits.A_LOWER_LIMIT] || value > LIMIT_VALUES[(int)Limits.A_UPPER_LIMIT])
                {
                    throw new ArgumentOutOfRangeException("A data", "out of range");
                }

                _acceleration = value;
            }
        }

        public double Displacement { get; set; }
    }
}
