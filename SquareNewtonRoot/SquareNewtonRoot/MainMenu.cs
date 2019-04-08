
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace SquareNewtonRoot
{
	public class MainMenu
	{
		public void Show ( )
		{
			WriteLine( "Calculating square root:" );

			double number = ReadPrintingValue( "Number" );
			double precision = ReadPrintingValue( "Precision" );

			var calculator = new SquareRootCalculator( number, precision );
			var result = calculator.CalculationNewtonMethod( );
			WriteLine( $"Result = {result}" );
			var result1 = calculator.CalculationRecursionMethod( );
			WriteLine( $"Result = {result1}" );
			ReadKey( );
		}

		private double ReadPrintingValue ( string valueName )
		{
			Write( $"{valueName} = " );
			var isParsed = double.TryParse( ReadLine( ), out var value );
			return isParsed ? value : ReadPrintingValue( valueName );
		}
	}
}