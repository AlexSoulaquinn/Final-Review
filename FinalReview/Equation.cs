using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalReview
{
    class Equation
    {
        public double Left { get; set; }
        public double Right { get; set; }

        public Equation()
        {

        }

        public Equation(double Left, double Right)
        {
            Left = 0;
            Right = 0;
        }

        public double Add()
        {
            return Left + Right;
        }

        public double Subtract()
        {
            return Left - Right;
        }

        public double Multiply()
        {
            return Left * Right;
        }

        public double LeftToThePower(int power)
        {
            return Math.Pow(Left, power);
        }

        public double RightToThePower(int power)
        {
            return Math.Pow(Right, power);
        }
    }
}
