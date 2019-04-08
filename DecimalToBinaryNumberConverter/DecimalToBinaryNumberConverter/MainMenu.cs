
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace DecimalToBinaryNumberConverter
{
    public class MainMenu
    {
        public void Show ( )
        {
            WriteLine( "Calculating square root:" );
            int number = ReadPrintingValue();
			
			var	strBinary = DecimalToBinaryConverter.Convert(number);
			WriteLine( $"Convert number to binary: {strBinary}" );

			ReadKey();
        }

		private int ReadPrintingValue( ) {
			Write("Decimal number = ");
			var isParsed = int.TryParse( ReadLine(), out var value );
			return isParsed && value >= 0 ? value : ReadPrintingValue( );
		}
    }
}