
using System;
using static System.Math;

namespace SquareNewtonRoot
{
	public class SquareRootCalculator
	{
		private const double coefficient = 0.5;

		public double Number { get; private set; }
		public double Precision { get; private set; }
		public double Result { get; private set; }

		public SquareRootCalculator ( double number, double precision = 0.1 )
		{
			Number = number;
			Precision = precision;
		}

		public double CalculationNewtonMethod ( )
		{
			double prevValue = 0;
			double nextValue = Number / 2;

			while ( Abs( nextValue - prevValue ) > Precision )
			{
				prevValue = nextValue;
				nextValue = coefficient * ( prevValue + Number / prevValue );
			}

			return Result = nextValue;
		}

		public double CalculationRecursionMethod ( )
		{
			double prevValue = 0;
			double nextValue = Number / 2;

			return RecursionFunction( prevValue, nextValue );
		}

		private double RecursionFunction(double prevValue, double nextValue) {
			prevValue = nextValue;
			nextValue = coefficient * ( prevValue + Number / prevValue );
			return Abs( nextValue - prevValue ) > Precision ? RecursionFunction( prevValue, nextValue ) : nextValue;
		}
	}
}