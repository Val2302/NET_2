using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace DecimalToBinaryNumberConverter
{
	public static class DecimalToBinaryConverter
	{
		public static string Convert ( int number )
		{
			if ( number > 1 )
			{
				var result = string.Empty;
				int divisionResidue;

				do
				{
					divisionResidue = number % 2;
					result = divisionResidue + result;
					number /= 2;
				} while ( number > 0 );

				return result;
			}

			return number.ToString( );
		}
	}
}
