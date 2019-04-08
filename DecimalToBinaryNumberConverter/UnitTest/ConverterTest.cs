using System;
using DecimalToBinaryNumberConverter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
	[TestClass]
	public class ConverterTest
	{
		[TestMethod]
		public void ConvertToBinaryTest ( )
		{
			var decimalNumber = 12345;
			var binaryResult1 = DecimalToBinaryConverter.Convert( decimalNumber );
			var binaryResult2 = Convert.ToString(decimalNumber, 2);
			Assert.AreEqual( binaryResult1, binaryResult2 );
		}
	}
}
