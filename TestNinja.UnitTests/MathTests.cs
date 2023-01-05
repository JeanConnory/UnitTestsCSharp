﻿using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
	[TestFixture]
	public class MathTests
	{

		private Math _math;

		//SetUp
		//TearDown

		[SetUp]
		public void SetUp()
		{
			_math = new Math();
		}

		[Test]
		[Ignore("Because I wanted to!")]
		public void Add_WhenCalled_ReturnTheSumOfArguments() 
		{
			var result = _math.Add(1, 2);

			Assert.That(result, Is.EqualTo(3));
		}

		[Test]
		[TestCase(2, 1, 2)]
		[TestCase(1, 2, 2)]
		[TestCase(1, 1, 1)]
		public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
		{
			var result = _math.Max(a, b);

			Assert.That(result, Is.EqualTo(expectedResult));
		}

		//[Test]
		//public void Max_FirstArgumentGreater_ReturnFirstArgument()
		//{			
		//	var result = _math.Max(1, 2);

		//	Assert.That(result, Is.EqualTo(2));
		//}

		//[Test]
		//public void Max_SecondArgumentGreater_ReturnSecondArgument()
		//{
		//	var result = _math.Max(2, 1);

		//	Assert.That(result, Is.EqualTo(2));
		//}

		//[Test]
		//public void Max_ArgumentAreEqual_ReturnTheSameArgument()
		//{
		//	var result = _math.Max(1, 1);

		//	Assert.That(result, Is.EqualTo(1));
		//}
	}
}