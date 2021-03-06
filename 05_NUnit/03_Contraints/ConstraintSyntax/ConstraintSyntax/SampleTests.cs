﻿using System;
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
			

		}
		[TestCase]
		public void EqualTest() {
			// classic nUnit assert 
			string greeting = "welcome";
			Assert.AreEqual("welcome", greeting);

			// with constraint syntax


		}

		[TestCase]
		public void FloatingPointTest() {
			// Work with floating point numbers 
			// assert between scalar and floating point numbers


			// specify a tolerance for equals


		}

		[TestCase]
		public void SameAsTest() {
			// test for object identity
			var tour1 = new Tour { TourName = "Chicago" };
			var tour2 = new Tour { TourName = "Barcelona" };

			var tourCopy = tour1;


		}

		[TestCase]
		public void ComparisonTest() {

		}

		[TestCase]
		public void ConditionTest() {
			Tour tourNull = null;
			Tour tourInstantiated = new Tour { TourName = "Singapore" };

			var tours = new List<Tour>();
			tours.Add(tourNull);
			tours.Add(tourInstantiated);

		}
		[TestCase]
		public void TypeTest() {
			Tour tour = new Tour { TourName = "Stockholm" };
			;
		}
		[TestCase]
		public void CollectionTest() {
			var colors = new List<string> { "red", "blue", "green", "yellow" };
			var otherColors = new List<string> { "blue", "yellow" };

		}

	}

}
