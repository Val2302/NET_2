using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareNewtonRoot;

namespace UnitTest
{
	[TestClass]
	public class SquareRootTest
	{
		[TestMethod]
		public void CalculationNewtonMethodTest ( )
		{
			var number = 12345;
			var result1 = new SquareRootCalculator( number, 0.000001 ).CalculationNewtonMethod();
			var result2 = Math.Sqrt( number );
			Assert.AreEqual( result1, result2 );
		}

		[TestMethod]
		public void CalculationRecursionMethodTest ( )
		{
			var number = 12345;
			var result1 = new SquareRootCalculator( number, 0.000001 ).CalculationRecursionMethod();
			var result2 = Math.Sqrt( number );
			Assert.AreEqual( result1, result2 );
		}
	}
}
