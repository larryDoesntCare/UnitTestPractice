using System;
using System.Collections.Generic;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace ConstraintSyntax {
	[TestFixture]
	public class SampleTests {
		// for this demonstration
		// there is no SUT, just simple asserts in the 
		// TestFixture that show the nUnit constraint syntax

		[TestCase]
		public void BooleanTest() {
			// classic nUnit assert 
			int headCount = 20;
			Assert.IsTrue(headCount > 10);

			// with constraint syntax
			Assert.That(headCount > 10);

		}
		[TestCase]
		public void EqualTest() {
			// classic nUnit assert 
			string greeting = "welcome";
			Assert.AreEqual("welcome", greeting);

			// with constraint syntax
			Assert.That(greeting, new EqualConstraint("welcome"));
			Assert.That(greeting, Is.EqualTo("welcome"));
			Assert.That(greeting, Is.Not.EqualTo("hello"));
			Assert.That(greeting, Is.EqualTo("Welcome").IgnoreCase);
		}

		[TestCase]
		public void EqualModifiersTest() {

			// EqualTo, Numeric modifiers
			// in float math, rounding error can make
			// 3.0 == 2.9999999
			var floatMathResult = 2.9999999;
			Assert.That(floatMathResult, Is.EqualTo(3.0).Within(0.0000001));
			Assert.That(82, Is.EqualTo(100).Within(20).Percent);

			// EqualTo, DateTime modifiers
			DateTime date1 = DateTime.Parse("7/15/2020");
			DateTime date2 = DateTime.Parse("7/17/2020");

			Assert.That(date1, Is.EqualTo(date2).Within(3).Days);

		}

		[TestCase]
		public void SameAsTest() {
			// test for object identity
			var tour1 = new Tour { TourName = "Chicago" };
			var tour2 = new Tour { TourName = "Barcelona" };

			var tourCopy = tour1;
			Assert.That(tour1, Is.SameAs(tourCopy));

		}

		[TestCase]
		public void ComparisonTest() {
			Assert.That(100, Is.GreaterThan(75));
			Assert.That(100, Is.LessThanOrEqualTo(200));
		}

		[TestCase]
		public void ConditionTest() {
			Tour tourNull = null;
			Tour tourInstantiated = new Tour { TourName = "Singapore" };

			Assert.That(tourNull,Is.Null);
			Assert.That(tourInstantiated, Is.Not.Null);


			var tours = new List<Tour>();
			tours.Add(tourNull);
			tours.Add(tourInstantiated);
			Assert.That(tours, Is.Not.Empty);
		}
		[TestCase]
		public void TypeTest() {
			Tour tour = new Tour { TourName = "Stockholm" };
			Assert.That(tour, Is.TypeOf(typeof(ConstraintSyntax.Tour)));
		}
		[TestCase]
		public void CollectionTest() {
			var colors = new List<string> { "red", "blue", "green", "yellow" };
			var otherColors = new List<string> { "blue", "yellow" };
			Assert.That(colors, Is.Unique);
			Assert.That(otherColors, Is.SubsetOf(colors));
		}

	}

}
