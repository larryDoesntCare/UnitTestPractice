using System;

namespace TestingLib {

	[AttributeUsage(AttributeTargets.Method)]
	public class CheckThisMethod : Attribute {
	}
}